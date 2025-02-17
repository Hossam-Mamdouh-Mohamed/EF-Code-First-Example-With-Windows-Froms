using System.ComponentModel;
using System.Diagnostics;
using EntityFramework_Day3_Lab.application.Services;
using EntityFramework_Day3_Lab.Domain.Model;
using EntityFramework_Day3_Lab.Presentation;

namespace Day6_Lab
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Name validation
            if (textBox1.Text.Length < 5)
            {
                label5.Visible = true;
                isValid = false;
            }
            else
            {
                label5.Visible = false;
            }

            // Email validation
            if (!textBox2.Text.Contains("@"))
            {
                label6.Visible = true;
                isValid = false;
            }
            else
            {
                label6.Visible = false;
            }
          

            if (isValid)
            {
                label8.Visible = true;
                MessageBox.Show("The User was Added Successfully");
                UserServices userServices = new UserServices();
                User user = new User();
                user.Name = textBox1.Text;
                user.Email = textBox2.Text;
                userServices.Adduser(user);
                Login login = new Login();
                this.Hide();
                login.ShowDialog();

            }
            else
            {
                label8.Visible = false;
            }
        }
    }
}

