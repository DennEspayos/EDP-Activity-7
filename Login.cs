using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Activity4_Ver2
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LOGINbtn_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.");
                return;
            }


            if (AuthenticateUser(username, password))
            {

                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            string connectionString = "Server=localhost;Port=3306;Database=merchshop;Uid=root;Pwd=denn;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM accounts WHERE username = @username AND password = @password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }


            }
        }

        private void CreateNewAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the CreateAccountForm
            CreateAccount createAccountForm = new CreateAccount();
            createAccountForm.Show();

            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void F_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // When the "Forgot Password?" link is clicked, open the ForgotPass form
            ForgotPassword forgotPassForm = new ForgotPassword();
            forgotPassForm.Show();

            this.Hide();
        }

        private void showpass_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the checkbox is checked
            if (showpass_checkbox.Checked)
            {
                // If checked, show the actual password by setting UseSystemPasswordChar to false
                password_textbox.UseSystemPasswordChar = false;
                
            }
            else
            {
                // If unchecked, show dots for password input
                password_textbox.UseSystemPasswordChar = true;
            }
        }
    }
}

