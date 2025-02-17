using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Day6_Lab;
using EntityFramework_Day3_Lab.application.Services;
using EntityFramework_Day3_Lab.Domain.Model;
using Microsoft.VisualBasic.ApplicationServices;
using User = EntityFramework_Day3_Lab.Domain.Model.User;

namespace EntityFramework_Day3_Lab.Presentation
{
    public partial class Login : Form
    {
        UserServices userServices=new UserServices();
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1 == null || textBox2 == null)
            {
                MessageBox.Show("Please Enter data to login");
            }
            if (textBox1.Text.Length < 3 || !textBox2.Text.Contains("@"))
            {
                MessageBox.Show("Please Enter valid data to login");
            }
            else
            {

                User user = new User();
                User user1 = new User();
                user.Name = textBox1.Text;
                user.Email = textBox2.Text;
                user1= userServices.userlogin(user);
                if (user1.Id!=-1)
                {
                    this.Hide();
                    Index index = new Index(user1.Id);
                    index.ShowDialog();
                }
                if (user1.Id==-1)
                {
                    MessageBox.Show("Invalid User Data,Try Again");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
               
            }
        }
    }
}
