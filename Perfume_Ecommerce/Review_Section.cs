using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP
{
    public partial class reviewSection : UserControl
    {
        // Database connection details (from user)
        private const string Server = "localhost";
        private const string Database = "perfume_ecom";
        private const string Username = "root";
        private const string Password = "12345";
        private const string Port = "3306"; // Added Port

        private string connectionString;

        public reviewSection()
        {
            InitializeComponent();
            InitializeDatabaseConnection(); // Initialize connection string
            LoadReviewData();
        }

        private void InitializeDatabaseConnection()
        {
            // Build the connection string
            connectionString = $"Server={Server};Database={Database};Uid={Username};Pwd={Password};Port={Port};"; //Added Port to connection String
        }

        private void LoadReviewData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select data from the view (same as before)
                    string query = "SELECT customer_name, brand_name, perfume_name, rating, review_text FROM detailed_feedback_section";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView (assuming your UserControl has a DataGridView named reviewGridView)
                            reviewGridView.DataSource = dataTable; //  Name of your DataGridView.

                            // Change column headers
                            reviewGridView.Columns["customer_name"].HeaderText = "Customer Name";
                            reviewGridView.Columns["brand_name"].HeaderText = "Brand Name";
                            reviewGridView.Columns["perfume_name"].HeaderText = "Perfume Name";
                            reviewGridView.Columns["review_text"].HeaderText = "Feedback";

                            // Optional: Auto-size columns
                            reviewGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void excelSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Navigate to project root
                string currentDir = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = Directory.GetParent(currentDir).Parent.Parent.Parent.FullName;

                // Add timestamp to filename
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"ReviewExport_{timestamp}.csv"; // Changed filename

                string filePath = Path.Combine(projectRoot, fileName);

                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // Write headers - adjusted for review data
                    writer.WriteLine("Customer Name,Brand Name,Perfume Name,Rating,Review Text");

                    // Write each row from DataGridView
                    foreach (DataGridViewRow row in reviewGridView.Rows) //iterating through reviewGridView
                    {
                        if (!row.IsNewRow)
                        {
                            string customerName = row.Cells["customer_name"].Value?.ToString();
                            string brandName = row.Cells["brand_name"].Value?.ToString();
                            string perfumeName = row.Cells["perfume_name"].Value?.ToString();
                            string rating = row.Cells["rating"].Value?.ToString();
                            string reviewText = row.Cells["review_text"].Value?.ToString();

                            writer.WriteLine($"{customerName},{brandName},{perfumeName},{rating},{reviewText}");
                        }
                    }
                }

                MessageBox.Show($"File saved successfully:\n{filePath}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating file: " + ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
