using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4_Ver2
{
    public partial class ForgotPassword : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=3306;Database=merchshop;Uid=root;Pwd=denn;";

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void resetpassBtn_Click_1(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string newPassword = newpassword_textbox.Text;
            string confirmPassword = confnewpass_textbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            if (ResetPassword(username, newPassword))
            {
                MessageBox.Show("Your password has been reset.");
                this.Hide(); // Hide the current ForgotPass form
                Login loginForm = new Login();
                loginForm.Show(); // Show the LogIn form again
            }
            else
            {
                MessageBox.Show("Failed to reset password. Please try again later.");
            }
        }

        private bool ResetPassword(string username, string newPassword)
        {
            string query = "UPDATE accounts SET password = @newPassword WHERE username = @username";

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@username", username);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        private void showpassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the checkbox is checked
            if (showpassCheckbox.Checked)
            {
                // If checked, show the actual password by setting UseSystemPasswordChar to false
                newpassword_textbox.UseSystemPasswordChar = false;
                confnewpass_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                // If unchecked, show dots for password input
                newpassword_textbox.UseSystemPasswordChar = true;
                confnewpass_textbox.UseSystemPasswordChar = true;
            }
        }

        private void LogInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide the current SignUp form
            Login loginForm = new Login();
            loginForm.Show(); // Show the LogIn form again
        }
    }
}

