namespace Register
{ 
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnPerfume;
        private System.Windows.Forms.Button btnReview;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnPerfume = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSidebar.Controls.Add(this.logoutBtn);
            this.panelSidebar.Controls.Add(this.orderList);
            this.panelSidebar.Controls.Add(this.btnReview);
            this.panelSidebar.Controls.Add(this.btnPerfume);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 600);
            this.panelSidebar.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(0, 200);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(200, 50);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // orderList
            // 
            this.orderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderList.FlatAppearance.BorderSize = 0;
            this.orderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderList.ForeColor = System.Drawing.Color.White;
            this.orderList.Location = new System.Drawing.Point(0, 150);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(200, 50);
            this.orderList.TabIndex = 3;
            this.orderList.Text = "Order List";
            this.orderList.UseVisualStyleBackColor = true;
            this.orderList.Click += new System.EventHandler(this.orderList_Click);
            // 
            // btnReview
            // 
            this.btnReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReview.FlatAppearance.BorderSize = 0;
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.ForeColor = System.Drawing.Color.White;
            this.btnReview.Location = new System.Drawing.Point(0, 100);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(200, 50);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Review Section";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnPerfume
            // 
            this.btnPerfume.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfume.FlatAppearance.BorderSize = 0;
            this.btnPerfume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfume.ForeColor = System.Drawing.Color.White;
            this.btnPerfume.Location = new System.Drawing.Point(0, 50);
            this.btnPerfume.Name = "btnPerfume";
            this.btnPerfume.Size = new System.Drawing.Size(200, 50);
            this.btnPerfume.TabIndex = 1;
            this.btnPerfume.Text = "Perfume List";
            this.btnPerfume.UseVisualStyleBackColor = true;
            this.btnPerfume.Click += new System.EventHandler(this.btnPerfume_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Customers ";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(908, 600);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Best Perfume Shop";
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(1108, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Home";
            this.Text = "Home";
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button orderList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
