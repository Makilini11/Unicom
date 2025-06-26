using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem.Views
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void LoadCourses()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CourseController.GetCourses();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a course name.");
                return;
            }
            CourseController.AddCourse(name);
            LoadCourses();
            textBox1.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string name = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Course name cannot be empty.");
                return;
            }

            CourseController.UpdateCourse(id, name);
            LoadCourses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            var confirm = MessageBox.Show("Delete this course?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                CourseController.DeleteCourse(id);
                LoadCourses();
            }
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
