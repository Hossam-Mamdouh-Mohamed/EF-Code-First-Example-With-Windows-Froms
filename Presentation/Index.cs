using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework_Day3_Lab.application.Services;
using EntityFramework_Day3_Lab.Domain.Model;
using EntityFramework_Day3_Lab.Infrastructure.Context;

namespace EntityFramework_Day3_Lab.Presentation
{
    public partial class Index : Form
    {
        UserServices UserServices = new UserServices();
        public int Id { get; set; }
        public Index(int id)
        {
            InitializeComponent();
            Id = id;
            var Result = UserServices.GetUser(id);
            this.Text = $"Welcome {Result.Name}";
            var R01 = UserServices.GetCategories();

            comboBox3.DataSource = R01;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Id";

            comboBox1.DataSource = Enum.GetValues(typeof(Priority));
            comboBox2.DataSource = Enum.GetValues(typeof(Status));

        }

        private void Index_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UserServices.GetTasks(Id).Select(p => new { p.Id, p.Title, p.Description, p.DueDate, p.Status, p.Priority, Catagory = p.Category.Name, User = p.User.Name }).ToList();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                comboBox6.DataSource = Enum.GetValues(typeof(Priority));
                comboBox5.DataSource = Enum.GetValues(typeof(Status));
                var R01 = UserServices.GetCategories();

                comboBox4.DataSource = R01;
                comboBox4.DisplayMember = "Name";
                comboBox4.ValueMember = "Id";
                // Populate the update form controls with the selected task's data
                textBox4.Text = selectedRow.Cells["Title"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Description"].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(selectedRow.Cells["DueDate"].Value);
                comboBox6.SelectedItem = Enum.Parse(typeof(Priority), selectedRow.Cells["Priority"].Value.ToString());
                comboBox5.SelectedItem = selectedRow.Cells["Status"].Value.ToString();
                comboBox4.SelectedItem = selectedRow.Cells["Catagory"].Value.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            var Result = UserServices.GetUser(Id);
            string title = textBox1.Text;
            string description = textBox2.Text;
            DateTime dueDate = dateTimePicker1.Value;
            Priority priority = (Priority)comboBox2.SelectedItem;
            Status status = (Status)comboBox1.SelectedItem;
            Category category = (Category)comboBox3.SelectedItem;

            if (title.Length >= 5 && description.Length >= 10)
            {
                TaskItem item = new TaskItem()
                {
                    User = Result,
                    Title = title,
                    Description = description,
                    DueDate = dueDate,
                    Priority = priority,
                    Status = status,
                    Category = category
                };

                UserServices.AddTaskitem(item);
                MessageBox.Show("The Task Was Added Successfully");
                textBox1.Clear();
                textBox2.Clear();
                Index_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Enter Valid Data");
                Index_Load(sender, e);
            }
        }

        private void button2_Click1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int taskId = (int)selectedRow.Cells["Id"].Value; // Assuming you have an Id column

                var task = UserServices.GetTask(taskId);

                if (task != null)
                {
                    task.Title = textBox4.Text;
                    task.Description = textBox3.Text;
                    task.DueDate = dateTimePicker2.Value;
                    task.Priority = (Priority)comboBox5.SelectedItem;
                    task.Status = (Status)comboBox6.SelectedItem;
                    task.Category = (Category)comboBox4.SelectedItem;
                    UserServices.updatetask(task);
                    Index_Load(sender, e);
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int taskId = (int)selectedRow.Cells["Id"].Value;
                var task = UserServices.GetTask(taskId);
                UserServices.deleteTaskitem(task);
                Index_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sorting_and_Filter sorting_And_Filter = new Sorting_and_Filter(Id);
            sorting_And_Filter.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification(Id);
            notification.ShowDialog();
        }
    }
}
