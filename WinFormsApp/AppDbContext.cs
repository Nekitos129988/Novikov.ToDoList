using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
