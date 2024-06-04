using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPOTracker
{
    public partial class DashboardForm : Form
    {
        private readonly string _currentUsername;
        public DashboardForm(string currentUsername)
        {
            InitializeComponent();
            _currentUsername = currentUsername;
        }

        private void SignOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthenticationService authService = new AuthenticationService();
            authService.SignOutUser(_currentUsername);
            //// Update the user status to signed out
            //UpdateUserStatusToSignedOut();

            // Close the dashboard form
            this.Close();

            // Show the main form (login form)
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void UpdateUserStatusToSignedOut()
        {
            // Implement the logic to update the user status to signed out in the database
            // For example, you can update a "IsSignedIn" field in the Users table
            string username = GetCurrentUsername(); // Implement this method to get the current user's username

            using (var context = new FormDbContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Username == username);
                if (user != null)
                {
                    user.IsSignedIn = false; // Assuming you have an IsSignedIn field in your User class
                    context.SaveChanges();
                }
            }
        }

        private string GetCurrentUsername()
        {
            // Implement this method to retrieve the current logged-in user's username
            // For example, you might have stored the username in a static property or a session variable
            return "currentUsername"; // Replace with actual implementation
        }
    }
}
