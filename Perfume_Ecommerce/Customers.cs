using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Register
{
    public partial class Customers : UserControl
    {
        private const string Server = "localhost";
        private const string Database = "perfume_ecom";
        private const string Username = "root";
        private const string Password = "12345";
        private const string Port = "3306";

        private MySqlConnection connection;
        private string _originalEmail; // Add this variable to store the original email

        public Customers()
        {
            InitializeComponent();
            this.Load += Customers_Load;  // This hooks the correct Load event handler
        }
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid.Rows[e.RowIndex];

                firstName.Text = row.Cells["first_name"].Value.ToString();
                lastName.Text = row.Cells["last_name"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                _originalEmail = email.Text; // Store the original email when the cell is clicked
                string gender = row.Cells["gender"].Value.ToString();

                maleRadio.Checked = (gender == "Male");
                femaleRadio.Checked = (gender == "Female");
            }
        }


        private void Customers_Load(object sender, EventArgs e)  // This should match the hooked event
        {
            string connStr = $"server={Server};port={Port};uid={Username};pwd={Password};database={Database};";
            connection = new MySqlConnection(connStr);

            try
            {
                connection.Open();
                string query = "SELECT first_name, last_name, email, gender FROM customers"; // Make sure the table name is correct

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGrid.DataSource = table; // Assumes dataGrid is your DataGridView

                dataGrid.CellClick += dataGrid_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void ClearForm()
        {
            firstName.Text = "";
            lastName.Text = "";
            email.Text = "";
            pass.Text = "";
            confPass.Text = "";
            maleRadio.Checked = false;
            femaleRadio.Checked = false;

            // Enable password fields for add user
            pass.Enabled = true;
            confPass.Enabled = true;

            // Do not clear search box
        }
        private void editUser_Click(object sender, EventArgs e)
        {
            string gender = maleRadio.Checked ? "Male" : (femaleRadio.Checked ? "Female" : "");
            string first = firstName.Text.Trim();
            string last = lastName.Text.Trim();
            string newEmail = email.Text.Trim();  // Get the new email from the textbox
            string originalEmail = _originalEmail; // Retrieve the stored original email

            if (string.IsNullOrEmpty(originalEmail))
            {
                MessageBox.Show("Original email not found. Please select a user from the grid first.");
                return;
            }

            // Ensure the fields are not empty
            if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last) || string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            // Check if the new email already exists in the database (if it's different from the original email)
            if (newEmail != originalEmail)
            {
                string checkEmailQuery = "SELECT COUNT(*) FROM customers WHERE email = @Email";
                using (MySqlCommand checkEmailCmd = new MySqlCommand(checkEmailQuery, connection))
                {
                    checkEmailCmd.Parameters.AddWithValue("@Email", newEmail);

                    try
                    {
                        connection.Open();
                        int emailExists = Convert.ToInt32(checkEmailCmd.ExecuteScalar());
                        if (emailExists > 0)
                        {
                            MessageBox.Show("The email is already taken by another user.");
                            return; // Stop further execution if the email is already taken
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error checking email: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            // Proceed with the update query
            string updateQuery = "UPDATE customers SET first_name = @First, last_name = @Last, gender = @Gender, email = @NewEmail WHERE email = @OriginalEmail";

            using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
            {
                cmd.Parameters.AddWithValue("@First", first);
                cmd.Parameters.AddWithValue("@Last", last);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@NewEmail", newEmail); // Always set the new email
                cmd.Parameters.AddWithValue("@OriginalEmail", originalEmail); // Use original email for WHERE clause

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully.");
                        ClearForm(); // Assuming you have a method to clear the form fields
                        RefreshTable(); // Assuming you have a method to refresh the data grid or list
                    }
                    else
                    {
                        MessageBox.Show("No changes were made. Please verify the details.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }









        private void searchUser_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchUser.Text.Trim();
            string query = $"SELECT first_name, last_name, email, gender FROM customers WHERE first_name LIKE @Keyword OR last_name LIKE @Keyword OR email LIKE @Keyword";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGrid.DataSource = table;
            }
        }
        private void RefreshTable()
        {
            string query = "SELECT first_name, last_name, email, gender FROM customers";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGrid.DataSource = table;
            }
        }




        private void LoadCustomerData()
        {
            try
            {
                string connStr = $"server={Server};port={Port};uid={Username};pwd={Password};database={Database};";
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();
                    string query = "SELECT first_name, last_name, email, gender FROM customers";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGrid.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
        }


        private void addUser_Click(object sender, EventArgs e)
        {
            string gender = maleRadio.Checked ? "Male" : (femaleRadio.Checked ? "Female" : "");
            string first = firstName.Text.Trim();
            string last = lastName.Text.Trim();
            string emailText = email.Text.Trim();
            string password = pass.Text.Trim();
            string confirmPassword = confPass.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last) ||
                string.IsNullOrWhiteSpace(emailText) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                connection.Open();

                // Check if email already exists
                string checkEmail = "SELECT COUNT(*) FROM customers WHERE email = @Email";
                using (MySqlCommand checkEmailCmd = new MySqlCommand(checkEmail, connection))
                {
                    checkEmailCmd.Parameters.AddWithValue("@Email", emailText);
                    int emailExists = Convert.ToInt32(checkEmailCmd.ExecuteScalar());

                    if (emailExists > 0)
                    {
                        MessageBox.Show("User with this email already exists.");
                        return;
                    }
                }

                // Check if full name already exists
                string checkName = "SELECT COUNT(*) FROM customers WHERE first_name = @First AND last_name = @Last";
                using (MySqlCommand checkNameCmd = new MySqlCommand(checkName, connection))
                {
                    checkNameCmd.Parameters.AddWithValue("@First", first);
                    checkNameCmd.Parameters.AddWithValue("@Last", last);
                    int nameExists = Convert.ToInt32(checkNameCmd.ExecuteScalar());

                    if (nameExists > 0)
                    {
                        MessageBox.Show("A user with the same first and last name already exists.");
                        return;
                    }
                }

                // Insert user
                string insertQuery = "INSERT INTO customers (first_name, last_name, email, password, gender) " +
                                     "VALUES (@First, @Last, @Email, @Password, @Gender)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@First", first);
                    insertCmd.Parameters.AddWithValue("@Last", last);
                    insertCmd.Parameters.AddWithValue("@Email", emailText);
                    insertCmd.Parameters.AddWithValue("@Password", password); // plain text
                    insertCmd.Parameters.AddWithValue("@Gender", gender);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully.");
                    ClearForm();
                }

                LoadCustomerData(); // Refresh the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}