using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class Main : Form
    {
        private User currentUser;
        public Main(User user)
        {
            InitializeComponent();
            currentUser = user;
            SetRoleAccess(user.Role);
        }
        private void SetRoleAccess(string role)
        {
            courses.Visible = role == "Admin";
            student.Visible = role == "Admin";
            exam.Visible = role == "Admin" || role == "Staff";
            marks.Visible = role != "Student";
            time.Visible = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked.");
        }



        private void courses_Click(object sender, EventArgs e)
        {
            var form = new CourseForm();
            form.MdiParent = this;
            form.Show();
        }

        private void log_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren) form.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
