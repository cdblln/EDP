using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDP;

namespace Register
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Customers uc = new Customers();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void btnPerfume_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            Perfumes uc = new Perfumes();  // Use Perfumes instead of Perfume
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            reviewSection uc = new reviewSection();  // Use Perfumes instead of Perfume
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void LoadUserControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void orderList_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            OrderList uc = new OrderList();  // Use Perfumes instead of Perfume
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Display a confirmation message
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear any user session data here, e.g.,
                // Session.Clear(); // If you are using session variables.  Use this if you are using Sessions.
                // Or clear authentication tokens, etc.

                // Redirect to the login page. You'll need to have a reference to your main form.
                // Assuming your login form class is named "LoginPage"
                LoginPage loginForm = new LoginPage();
                loginForm.Show();

                // Close the current Home form.  This assumes the logout button is on the Home form.
                this.Hide(); // Or this.Close(); depending on your desired behavior
            }
            // If the user clicks "No", the code will simply return and the logout action will be cancelled.
        }
    }
}
