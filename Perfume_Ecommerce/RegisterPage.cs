using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Register
{
    public partial class RegisterPage : Form
    {
        // Your MySQL connection details
        private const string Server = "localhost";
        private const string Database = "perfume_ecom";
        private const string Username = "root";
        private const string Password = "12345";
        private const string Port = "3306";

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            // Get the text from the textboxes
            string firstName = firstText.Text.Trim();
            string lastName = lastText.Text.Trim();
            string password = passText.Text;
            string confirmPassword = confText.Text;
            string gender = male.Checked ? "Male" : (female.Checked ? "Female" : ""); // Get selected gender
            string email = emailText.Text.Trim(); // Assuming emailtext is the correct name

            // Perform password validation
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop the registration process if passwords don't match
            }

            // Check if any required fields are empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if neither male nor female radio button is checked
            if (!male.Checked && !female.Checked)
            {
                MessageBox.Show("Please select your gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = $"Server={Server};Port={Port};Database={Database};Uid={Username};Pwd={Password};";

            // SQL query to insert data
            string query = "INSERT INTO customers (first_name, last_name, password, gender, email) VALUES (@firstName, @lastName, @password, @gender, @email)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@password", password); // In a real application, you should hash the password!
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@email", email);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optionally clear the form after successful registration
                            firstText.Clear();
                            lastText.Clear();
                            emailText.Clear();
                            passText.Clear();
                            male.Checked = false;
                            female.Checked = false;
                            confText.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error connecting to database or executing query: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void logbut_Click(object sender, EventArgs e)
        {
            LoginPage secondForm = new LoginPage(); // Replace with your actual RegisterPage class name if different
            secondForm.Show();
            this.Hide(); // Hides the current form
        }
    }
}
