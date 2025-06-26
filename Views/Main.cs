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
            this.IsMdiContainer = true;

            currentUser = user;
        }
         /*   SetRoleAccess(user.Role);
        }
        private void SetRoleAccess(string role)
        {
            courses.Visible = role == "Admin";
            student.Visible = role == "Admin";
            exam.Visible = role == "Admin" || role == "Staff";
            marks.Visible = role != "Student";
            time.Visible = true;
        }*/

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
            
            form.Show();
        }

        private void log_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addNewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addstu = new AddStudentForm();
            addstu.Show(this);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
           
            user.Show(this);

        }

        private void timetablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimetableForm timetable = new TimetableForm();
            timetable.Show(this);
        }

        private void attendancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendenceForm attendenceForm = new AttendenceForm();
            attendenceForm.Show(this);
        }

        private void examsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamForm exam = new ExamForm();
            exam.Show(this);
        }

        private void marksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkForm mark = new MarkForm();
            mark.Show(this);
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseForm course = new CourseForm();
            course.Show(this);
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
