using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Add this for MySQL

namespace Register
{
    public partial class LoginPage : Form
    {
        private const string Server = "localhost";
        private const string Database = "perfume_ecom";
        private const string Username = "root";
        private const string Password = "12345";
        private const string Port = "3306";

        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            RegisterPage secondForm = new RegisterPage(); // Replace with your actual RegisterPage class name if different
            secondForm.Show();
            this.Hide(); // Hides the current form
        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            // You can add input validation or other logic here
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            // You can add input validation or other logic here
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextbox.Text;
            string password = passTextBox.Text;

            string connectionString = $"Server={Server};Port={Port};Database={Database};Uid={Username};Pwd={Password};";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM customers WHERE email = @email AND password = @password"; // Assuming you have a 'users' table with 'email' and 'password' columns
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            // Optionally navigate to the next page after successful login
                             Home homePage = new Home();
                             homePage.Show();
                             this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}