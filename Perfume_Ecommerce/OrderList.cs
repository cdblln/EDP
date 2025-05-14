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
    public partial class OrderList : UserControl // Assuming your UserControl is named OrderList
    {
        // Database connection details
        private const string Server = "localhost";
        private const string Database = "perfume_ecom";
        private const string Username = "root";
        private const string Password = "12345";
        private const string Port = "3306";
        // Connection string (IMPORTANT: Store this securely)
        private string ConnectionString = "Server=" + Server + ";Database=" + Database + ";Uid=" + Username + ";Pwd=" + Password + ";Port=" + Port + ";";


        public OrderList()
        {
            InitializeComponent();
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // SQL query to select data from the customer_orders view
                    string query = "SELECT order_id, first_name, last_name, order_date FROM customer_orders";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            orderGridView.DataSource = dataTable;

                            // Change column headers
                            orderGridView.Columns["order_id"].HeaderText = "Order ID";
                            orderGridView.Columns["first_name"].HeaderText = "First Name";
                            orderGridView.Columns["last_name"].HeaderText = "Last Name";
                            orderGridView.Columns["order_date"].HeaderText = "Order Date";

                            // Optional: Auto-size columns for better display
                            orderGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                // Save to user's Documents folder
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Add timestamp to filename
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"OrderExport_{timestamp}.csv";

                string filePath = Path.Combine(documentsPath, fileName);

                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // Write headers
                    writer.WriteLine("Order ID,First Name,Last Name,Order Date");

                    // Write each row from DataGridView
                    foreach (DataGridViewRow row in orderGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string orderId = row.Cells["order_id"].Value?.ToString();
                            string firstName = row.Cells["first_name"].Value?.ToString();  // Use the changed header
                            string lastName = row.Cells["last_name"].Value?.ToString(); // Use the changed header
                            string orderDate = row.Cells["order_date"].Value?.ToString();  // Use the changed header

                            writer.WriteLine($"{orderId},{firstName},{lastName},{orderDate}");
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
