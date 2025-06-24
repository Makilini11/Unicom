using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Views;

namespace UnicomTICManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Migration.CreateTables();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            /*using (LoginForm login = new LoginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // If login success, run main form (e.g., DashboardForm)
                    Application.Run(new MainForm()); // or DashboardForm or any other main form
                }
                else
                {
                    // Exit if login fails or user cancels
                    Application.Exit();
                }
            }*/
            string dbPath = @"D:\uni\UnicomTICManagementSystem";
            string connectionString = $"Data Source={dbPath};Version=3;";

        }
    }
}




   

