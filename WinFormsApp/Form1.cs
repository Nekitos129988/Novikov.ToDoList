using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button_1_Click(object sender, EventArgs e)
        {
            Form2 ToDoList = new Form2();
            ToDoList.ShowDialog();

            UpdateDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            AppDbContext dbContext = new AppDbContext();

            dataGridView2.Columns.Add("Id", "Номер");
            dataGridView2.Columns.Add("Title", "Заголовок");
            dataGridView2.Columns.Add("Content", "Описание");
            dataGridView2.Columns.Add("CreatedAt", "Дата создания");

            Note[] notes = dbContext.Notes.ToArray();
            foreach (Note note in notes)
            {
                object[] values = new object[]
                {
                    note.Id,
                    note.Title,
                    note.Content,
                    note.CreateAt.ToString("dd.MM.yyyy HH:mm:ss")
                };

                dataGridView2.Rows.Add(values);
            }
        }
    }
}
