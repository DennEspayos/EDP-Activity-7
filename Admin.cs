using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace Activity4_Ver2
{
    public partial class Admin : Form
    {
        private const string ConnectionString = "Server=localhost;Port=3306;Database=merchshop;Uid=root;Pwd=denn;";
        private DataTable accountsData;
        private DataGridView userAccountsDataGridView;

        public Admin()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadUserData();
            InitializeIcon();

        }

        private void InitializeDataGridView()
        {
            userAccountsDataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
            };
            accountsPanel.Controls.Add(userAccountsDataGridView);
            userAccountsDataGridView.Size = new Size(647, 194);
            userAccountsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            userAccountsDataGridView.CellClick += UserAccountsDataGridView_CellClick;
        }

        private void InitializeIcon()
        {
            // Assuming you already have an iconPictureBox in your form
            UserIcon.Click +=UserIcon_Click;
        }

        private void LoadUserData()
        {
            accountsData = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                string query = "SELECT account_id, username, email FROM accounts";
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(accountsData);
                    userAccountsDataGridView.DataSource = accountsData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UserAccountsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < userAccountsDataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = userAccountsDataGridView.Rows[e.RowIndex];

                usnTextbox.Text = selectedRow.Cells["username"].Value.ToString();
                emailTextbox.Text = selectedRow.Cells["email"].Value.ToString();
            }
        }

        private void UpdateChanges()
        {
            int accountId;
            string newUsername = usnTextbox.Text;
            string newEmail = emailTextbox.Text;

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Please enter both username and email before updating.");
                return;
            }

            if (!int.TryParse(userAccountsDataGridView.CurrentRow.Cells["account_id"].Value.ToString(), out accountId))
            {
                MessageBox.Show("Invalid account ID.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the new username already exists
                    string checkUsernameQuery = "SELECT COUNT(*) FROM accounts WHERE username = @newUsername";
                    MySqlCommand checkUsernameCommand = new MySqlCommand(checkUsernameQuery, connection);
                    checkUsernameCommand.Parameters.AddWithValue("@newUsername", newUsername);
                    int count = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return;
                    }

                    // Update the username and email for the specific user
                    string updateQuery = "UPDATE accounts SET username = @newUsername, email = @newEmail WHERE account_id = @accountId";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@newUsername", newUsername);
                    updateCommand.Parameters.AddWithValue("@newEmail", newEmail);
                    updateCommand.Parameters.AddWithValue("@accountId", accountId);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully!");
                        LoadUserData(); // Reload the user data to reflect the changes
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user information: " + ex.Message);
                }
            }
        }




        private void Update_Click(object sender, EventArgs e)
        {
            UpdateChanges();

            LoadUserData();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchCriteria = searchTextbox.Text;


            string query = "SELECT account_id, username, email FROM accounts WHERE email LIKE @search OR username LIKE @search";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@search", "%" + searchCriteria + "%");

                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable searchResults = new DataTable();
                    adapter.Fill(searchResults);
                    userAccountsDataGridView.DataSource = searchResults;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        /*private bool accounts(string email, string username)
        {

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM accounts WHERE username = @username";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error checking username availability: " + ex.Message);
                    return false;
                }
            }


            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO accounts (username, email) VALUES (@username, @email)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error inserting user account: " + ex.Message);
                    return false;
                }
            }
        } */

        private void UserIcon_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Check if the Dashboard form is already open
            Dashboard dashboardForm = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();

            if (dashboardForm != null)
            {
                // If the Dashboard form is open, bring it to the front
                dashboardForm.Show();
            }
            else
            {
                // If the Dashboard form is not open, create and show a new instance
                Dashboard newDashboardForm = new Dashboard();
                newDashboardForm.Show();
            }
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Login LoginForm = new Login();
            LoginForm.Show(); // Show the LogIn form again
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

