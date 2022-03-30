using System;
using System.Windows.Forms;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();

            Note note = new Note();
            note.Title = textBox1.Text;
            note.Content = textBox2.Text;
            note.CreateAt = DateTime.Now;

            dbContext.Notes.Add(note);
            dbContext.SaveChanges();

            Close();
        }
    }
}
