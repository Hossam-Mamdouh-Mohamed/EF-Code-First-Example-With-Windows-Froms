using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using EntityFramework_Day3_Lab.application.Services;
using EntityFramework_Day3_Lab.Domain.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Status = EntityFramework_Day3_Lab.Domain.Model.Status;

namespace EntityFramework_Day3_Lab.Presentation
{
    public partial class Sorting_and_Filter : Form
    {
        public int userid;
        UserServices UserServices = new UserServices();

        public Sorting_and_Filter(int id)
        {
            InitializeComponent();
            userid = id;
            comboBox1.DataSource = Enum.GetValues(typeof(Priority));
            comboBox2.DataSource = Enum.GetValues(typeof(Status));
        }

        private void Sorting_and_Filter_Load(object sender, EventArgs e)
        {

            var result = UserServices.GetTasks(userid).ToList();
            dataGridView1.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string str = textBox1.Text;
                var result = UserServices.SearchTasks(str, userid).ToList();
                dataGridView1.DataSource = result;
            }
            else
                MessageBox.Show("Enter Text to Search");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Priority priority = (Priority)comboBox1.SelectedItem;
            //Status status = (Status)comboBox1.SelectedItem;
            int num = (int)priority;
            var result = UserServices.SearchTaskpriority(num, userid).ToList();
            dataGridView1.DataSource = new List<TaskItem>();
            dataGridView1.DataSource = result;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Status status = (Status)comboBox2.SelectedItem;
            //Status status = (Status)comboBox1.SelectedItem;
            int num = (int)status;
            var result = UserServices.SearchTaskStatus(num, userid).ToList();
            dataGridView1.DataSource = new List<TaskItem>();
            dataGridView1.DataSource = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = UserServices.SortDesc(userid).ToList();
            dataGridView1.DataSource = new List<TaskItem>();
            dataGridView1.DataSource = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = UserServices.SortAsc(userid).ToList();
            dataGridView1.DataSource = new List<TaskItem>();
            dataGridView1.DataSource = result;
        }
    }
}
