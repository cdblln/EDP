using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //LoadUserControl(new ProfileControl());
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
    }
}
