﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPOTracker
{
    public partial class MainForm : Form
    {
        private readonly AuthenticationService _authService;
        public MainForm()
        {
            InitializeComponent();
            _authService = new AuthenticationService();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBox.Text;
            string password = PasswordTxtBox.Text;

            if (_authService.AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open DashboardForm
                DashboardForm dashboardForm = new DashboardForm(username);
                dashboardForm.Show();

                // Hide the LoginForm
                this.Hide();
            }
            //if (ValidateUser(username, password))
            //{
            //    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    // Proceed to Dashboard

            //    // Open CalculatorForm
            //    DashboardForm dashboardForm = new DashboardForm();
            //    dashboardForm.Show();

            //    // Hide the MainForm
            //    this.Hide();
            //}

            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private bool ValidateUser(string username, string password)
        //{
        //    // Retrieve the connection string from App.config
        //    string connectionString = ConfigurationManager.ConnectionStrings["MyLocalDbConnectionString"].ConnectionString;
        //    string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@Username", username);
        //        command.Parameters.AddWithValue("@Password", password);

        //        try
        //        {
        //            connection.Open();
        //            int result = (int)command.ExecuteScalar();
        //            return result == 1;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Database connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //    }
        //}

        private void CreateAcclinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.ShowDialog();
        }

        private bool ValidateUser(string username, string password)
        {
            using (var context = new FormDbContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Username == username);
                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                    user.IsSignedIn = true;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

    }
}
