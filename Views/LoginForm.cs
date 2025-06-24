using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textusername.Text;
            string password = textpassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password required.");
                return;
            }
           

            var user = LoginController.AuthenticateUser(username, password);
            if (user != null)
            {
                this.Hide();
                Main dashboard = new Main(user);
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }
        private void username_Click(object sender, EventArgs e)
        {
           
        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked == true)
            {
                textpassword.UseSystemPasswordChar = false;

            }
            else
            {
                textpassword.UseSystemPasswordChar = true;
            }

        }
    }
}
