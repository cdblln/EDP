using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Register
{
    public partial class ForgotPassword : Form
    {
        private const string Server = "localhost";
        private const string Database = "perfume_ecom";
        private const string Username = "root";
        private const string Password = "12345";
        private const string Port = "3306";
        private const string TableName = "customers";

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            // You can add any real-time validation or feedback here if needed
            // For example, checking for a valid email format as the user types.
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string email = emailTextbox.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CheckIfEmailExists(email))
            {
                ShowPasswordInputDialog(email);
            }
            else
            {
                MessageBox.Show("Email address not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPasswordInputDialog(string email)
        {
            Form passwordInputForm = new Form()
            {
                Text = "Enter New Password",
                Width = 300,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false
            };

            Label newPasswordLabel = new Label() { Text = "New Password:", Location = new Point(20, 20), Width = 100 };
            TextBox newPasswordTextBox = new TextBox() { Location = new Point(130, 17), Width = 150, PasswordChar = '●' };

            Label confirmPasswordLabel = new Label() { Text = "Confirm Password:", Location = new Point(20, 50), Width = 100 };
            TextBox confirmPasswordTextBox = new TextBox() { Location = new Point(130, 47), Width = 150, PasswordChar = '●' };

            Button okButton = new Button() { Text = "OK", Location = new Point(100, 90), DialogResult = DialogResult.OK };
            Button cancelButton = new Button() { Text = "Cancel", Location = new Point(190, 90), DialogResult = DialogResult.Cancel };

            passwordInputForm.Controls.Add(newPasswordLabel);
            passwordInputForm.Controls.Add(newPasswordTextBox);
            passwordInputForm.Controls.Add(confirmPasswordLabel);
            passwordInputForm.Controls.Add(confirmPasswordTextBox);
            passwordInputForm.Controls.Add(okButton);
            passwordInputForm.Controls.Add(cancelButton);

            passwordInputForm.AcceptButton = okButton;
            passwordInputForm.CancelButton = cancelButton;

            if (passwordInputForm.ShowDialog() == DialogResult.OK)
            {
                string newPassword = newPasswordTextBox.Text;
                string confirmPassword = confirmPasswordTextBox.Text;

                if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please enter and confirm your new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowPasswordInputDialog(email); // Re-show the dialog
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("New passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowPasswordInputDialog(email); // Re-show the dialog
                    return;
                }

                // DO NOT HASH THE PASSWORD HERE AS REQUESTED
                string plainTextPassword = newPassword;

                if (UpdatePasswordInDatabase(email, plainTextPassword))
                {
                    MessageBox.Show("Password has been changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Go back to the LoginPage
                    LoginPage loginPage = new LoginPage(); // Assuming your login form class is named LoginPage
                    loginPage.Show();
                    this.Hide(); // Hide the ForgotPassword form
                }
                else
                {
                    MessageBox.Show("An error occurred while updating the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckIfEmailExists(string email)
        {
            string connectionString = $"Server={Server};Port={Port};Database={Database};Uid={Username};Pwd={Password};";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM {TableName} WHERE email = @email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private bool UpdatePasswordInDatabase(string email, string password)
        {
            string connectionString = $"Server={Server};Port={Port};Database={Database};Uid={Username};Pwd={Password};";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"UPDATE {TableName} SET password = @password WHERE email = @email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            emailTextbox.Focus();
        }
    }
}