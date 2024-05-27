using MySql.Data.MySqlClient;
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

    public partial class CreateAccount : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=merchshop;Uid=root;Pwd=denn;";

    public CreateAccount()
        {
            InitializeComponent();
        }
    private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

    private void LogInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide the current SignUp form
            Login loginForm = new Login();
            loginForm.Show(); // Show the LogIn form again
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = pass_textbox.Text;
            string confirmpass = confpass_textbox.Text;
            string email = email_textbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmpass)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            if (user_account(username, password, email))
            {
                MessageBox.Show("Sign up successful!");
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Failed to sign up. Please try again.");
            }
        }

        private bool user_account(string username, string password, string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO accounts (username, password, email) VALUES (@username, @password, @email)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
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
    }
}



