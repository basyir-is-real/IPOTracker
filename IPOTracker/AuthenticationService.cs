using IPOTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPOTracker
{
    public class AuthenticationService
    {
        public bool RegisterUser(string username, string password)
        {
            using (var context = new FormDbContext())
            {
                if (context.Users.Any(u => u.Username == username))
                {
                    throw new Exception("Username already exists.");
                }

                var salt = BCrypt.Net.BCrypt.GenerateSalt();
                var hash = BCrypt.Net.BCrypt.HashPassword(password, salt);

                var user = new User
                {
                    Username = username,
                    PasswordHash = hash,
                    Salt = salt
                };

                context.Users.Add(user);
                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    // Log or display the inner exception for debugging
                    MessageBox.Show($"An error occurred while updating the entries: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    // Log or display the general exception for debugging
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            using (var context = new FormDbContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Username == username);
                if (user == null)
                {
                    return false;
                }

                return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
            }
        }
    }
}
