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

namespace EntityFramework_Day3_Lab.Presentation
{
    public partial class Notification : Form
    {
        int user_id;
        UserServices UserServices02 = new UserServices();

        public Notification(int Id)
        {
            InitializeComponent();
            user_id = Id;

        }

        private void Notification_Load(object sender, EventArgs e)
        {
            var result = UserServices02.GetTasks(user_id).Where(T=>T.DueDate<DateTime.Now && (T.Status ==Status.Pending || T.Status==Status.InProgress)).ToList();
            dataGridView1.DataSource = result;
        }
    }
}
