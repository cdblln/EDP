using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Register
{
    public partial class Perfumes : UserControl
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable perfumeTable;

        private const string Server = "localhost";
        private const string Database = "perfume_ecom";
        private const string Username = "root";
        private const string Password = "12345";
        private const string Port = "3306";

        public Perfumes()
        {
            InitializeComponent();
            string connectionString = $"Server={Server};Port={Port};Database={Database};Uid={Username};Pwd={Password};";
            connection = new MySqlConnection(connectionString);
        }

        private void Perfumes_Load(object sender, EventArgs e)
        {
            RefreshTable();
            LoadBrands();
            LoadCategories();

            perfumeDataGrid.SelectionChanged += perfumeDataGrid_SelectionChanged;
            searchPerfumeTextBox.TextChanged += searchPerfumeTextBox_TextChanged;

            perfumeDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            perfumeDataGrid.MultiSelect = false;

        }

        private void LoadBrands()
        {
            var brandDict = new Dictionary<int, string>
            {
                { 7, "Armani" }, { 8, "Burberry" }, { 13, "Byredo" }, { 9, "Calvin Klein" },
                { 1, "Chanel" }, { 14, "Creed" }, { 2, "Dior" }, { 11, "Dolce & Gabbana" },
                { 4, "Gucci" }, { 12, "Jo Malone" }, { 15, "Maison Francis Kurkdjian" },
                { 10, "Prada" }, { 3, "Tom Ford" }, { 5, "Versace" }, { 6, "Yves Saint Laurent" }
            };

            brand.DataSource = new BindingSource(brandDict, null);
            brand.DisplayMember = "Value";
            brand.ValueMember = "Key";
        }

        private void LoadCategories()
        {
            var categoryDict = new Dictionary<int, string>
            {
                { 9, "Aromatic" }, { 8, "Chypre" }, { 6, "Citrus" }, { 1, "Floral" },
                { 4, "Fresh" }, { 5, "Fruity" }, { 7, "Gourmand" }, { 10, "Leather" },
                { 3, "Oriental" }, { 2, "Woody" }
            };

            categories.DataSource = new BindingSource(categoryDict, null);
            categories.DisplayMember = "Value";
            categories.ValueMember = "Key";
        }

        private void RefreshTable()
        {
            string query = @"
                SELECT 
                    p.perfume_id,
                    p.perfume_name AS PerfumeName,
                    b.brand_name AS Brand,
                    c.category_name AS Category,
                    p.price AS Price,
                    p.quantity AS Quantity
                FROM perfumes p
                INNER JOIN brands b ON p.brand_id = b.brand_id
                INNER JOIN categories c ON p.category_id = c.category_id";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                perfumeDataGrid.DataSource = table;

                if (perfumeDataGrid.Columns.Contains("perfume_id"))
                    perfumeDataGrid.Columns["perfume_id"].Visible = false;
            }
        }

        private void searchPerfumeTextBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchPerfumeTextBox.Text.Trim();
            string query = @"
                SELECT 
                    p.perfume_id,
                    p.perfume_name AS PerfumeName,
                    b.brand_name AS Brand,
                    c.category_name AS Category,
                    p.price AS Price,
                    p.quantity AS Quantity
                FROM perfumes p
                INNER JOIN brands b ON p.brand_id = b.brand_id
                INNER JOIN categories c ON p.category_id = c.category_id
                WHERE p.perfume_name LIKE @Keyword 
                   OR b.brand_name LIKE @Keyword 
                   OR c.category_name LIKE @Keyword";

            try
            {
                dataAdapter = new MySqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                perfumeTable = new DataTable();
                dataAdapter.Fill(perfumeTable);
                perfumeDataGrid.DataSource = perfumeTable;

                if (perfumeDataGrid.Columns.Contains("perfume_id"))
                    perfumeDataGrid.Columns["perfume_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching perfumes: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addPerfumeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(perfumeNameTextbox.Text) ||
                brand.SelectedItem == null ||
                categories.SelectedItem == null ||
                string.IsNullOrWhiteSpace(priceTextbox.Text) ||
                string.IsNullOrWhiteSpace(quantityTextbox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connection.Open();
                string query = @"INSERT INTO perfumes (perfume_name, brand_id, category_id, price, quantity)
                                 VALUES (@Name, @BrandId, @CategoryId, @Price, @Quantity)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", perfumeNameTextbox.Text);
                cmd.Parameters.AddWithValue("@BrandId", ((KeyValuePair<int, string>)brand.SelectedItem).Key);
                cmd.Parameters.AddWithValue("@CategoryId", ((KeyValuePair<int, string>)categories.SelectedItem).Key);
                cmd.Parameters.AddWithValue("@Price", priceTextbox.Text);
                cmd.Parameters.AddWithValue("@Quantity", quantityTextbox.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Perfume has been successfully added.", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                RefreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding perfume: " + ex.Message, "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void editPerfumeButton_Click(object sender, EventArgs e)
        {
            if (perfumeDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a perfume to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = perfumeDataGrid.SelectedRows[0];
            int perfumeId = Convert.ToInt32(row.Cells["perfume_id"].Value);

            try
            {
                connection.Open();
                string query = @"UPDATE perfumes 
                                 SET perfume_name = @Name, brand_id = @BrandId, category_id = @CategoryId, price = @Price, quantity = @Quantity
                                 WHERE perfume_id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", perfumeNameTextbox.Text);
                cmd.Parameters.AddWithValue("@BrandId", ((KeyValuePair<int, string>)brand.SelectedItem).Key);
                cmd.Parameters.AddWithValue("@CategoryId", ((KeyValuePair<int, string>)categories.SelectedItem).Key);
                cmd.Parameters.AddWithValue("@Price", priceTextbox.Text);
                cmd.Parameters.AddWithValue("@Quantity", quantityTextbox.Text);
                cmd.Parameters.AddWithValue("@Id", perfumeId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Perfume has been successfully updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                RefreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing perfume: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void deletePerfumeButton_Click(object sender, EventArgs e)
        {
            if (perfumeDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a perfume to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = perfumeDataGrid.SelectedRows[0];
            int perfumeId = Convert.ToInt32(row.Cells["perfume_id"].Value);

            if (MessageBox.Show("Are you sure you want to delete this perfume?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM perfumes WHERE perfume_id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", perfumeId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Perfume has been successfully deleted.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    RefreshTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting perfume: " + ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void perfumeDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (perfumeDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = perfumeDataGrid.SelectedRows[0];
                perfumeNameTextbox.Text = row.Cells["PerfumeName"].Value?.ToString();
                priceTextbox.Text = row.Cells["Price"].Value?.ToString();
                quantityTextbox.Text = row.Cells["Quantity"].Value?.ToString();

                brand.SelectedIndex = brand.FindStringExact(row.Cells["Brand"].Value?.ToString());
                categories.SelectedIndex = categories.FindStringExact(row.Cells["Category"].Value?.ToString());
            }
        }

        private void ClearInputFields()
        {
            perfumeNameTextbox.Clear();
            priceTextbox.Clear();
            quantityTextbox.Clear();
            brand.SelectedIndex = -1;
            categories.SelectedIndex = -1;
        }

        private void exportToExcelButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Navigate to project root
                string currentDir = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = Directory.GetParent(currentDir).Parent.Parent.Parent.FullName;

                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = $"PerfumesExport_{timestamp}.csv";

                string filePath = Path.Combine(projectRoot, fileName);

                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    string[] headers = { "PerfumeName", "Brand", "Category", "Price", "Quantity" };
                    writer.WriteLine(string.Join(",", headers));

                    foreach (DataGridViewRow row in perfumeDataGrid.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var values = headers.Select(h => row.Cells[h].Value?.ToString()).ToArray();
                            writer.WriteLine(string.Join(",", values));
                        }
                    }
                }

                MessageBox.Show($"Exported to: {filePath}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting: " + ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}