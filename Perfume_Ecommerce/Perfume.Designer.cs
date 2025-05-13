namespace Register
{
    partial class Perfumes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.perfumeDataGrid = new System.Windows.Forms.DataGridView();
            this.deletePerfumeButton = new System.Windows.Forms.Button();
            this.editPerfumeButton = new System.Windows.Forms.Button();
            this.addPerfumeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.perfumeNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPerfumeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.exportToExcelButton = new System.Windows.Forms.Button();
            this.brand = new System.Windows.Forms.ComboBox();
            this.categories = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.perfumeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // perfumeDataGrid
            // 
            this.perfumeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perfumeDataGrid.Location = new System.Drawing.Point(26, 78);
            this.perfumeDataGrid.Name = "perfumeDataGrid";
            this.perfumeDataGrid.ReadOnly = true;
            this.perfumeDataGrid.Size = new System.Drawing.Size(492, 376);
            this.perfumeDataGrid.TabIndex = 0;
            // 
            // deletePerfumeButton
            // 
            this.deletePerfumeButton.Location = new System.Drawing.Point(730, 405);
            this.deletePerfumeButton.Name = "deletePerfumeButton";
            this.deletePerfumeButton.Size = new System.Drawing.Size(93, 23);
            this.deletePerfumeButton.TabIndex = 35;
            this.deletePerfumeButton.Text = "Delete Perfume";
            this.deletePerfumeButton.UseVisualStyleBackColor = true;
            this.deletePerfumeButton.Click += new System.EventHandler(this.deletePerfumeButton_Click);
            // 
            // editPerfumeButton
            // 
            this.editPerfumeButton.Location = new System.Drawing.Point(638, 405);
            this.editPerfumeButton.Name = "editPerfumeButton";
            this.editPerfumeButton.Size = new System.Drawing.Size(86, 23);
            this.editPerfumeButton.TabIndex = 34;
            this.editPerfumeButton.Text = "Edit Perfume";
            this.editPerfumeButton.UseVisualStyleBackColor = true;
            this.editPerfumeButton.Click += new System.EventHandler(this.editPerfumeButton_Click);
            // 
            // addPerfumeButton
            // 
            this.addPerfumeButton.Location = new System.Drawing.Point(543, 405);
            this.addPerfumeButton.Name = "addPerfumeButton";
            this.addPerfumeButton.Size = new System.Drawing.Size(89, 23);
            this.addPerfumeButton.TabIndex = 33;
            this.addPerfumeButton.Text = "Add Perfume";
            this.addPerfumeButton.UseVisualStyleBackColor = true;
            this.addPerfumeButton.Click += new System.EventHandler(this.addPerfumeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Perfume Name";
            // 
            // perfumeNameTextbox
            // 
            this.perfumeNameTextbox.Location = new System.Drawing.Point(543, 157);
            this.perfumeNameTextbox.Name = "perfumeNameTextbox";
            this.perfumeNameTextbox.Size = new System.Drawing.Size(278, 20);
            this.perfumeNameTextbox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search";
            // 
            // searchPerfumeTextBox
            // 
            this.searchPerfumeTextBox.Location = new System.Drawing.Point(360, 51);
            this.searchPerfumeTextBox.Name = "searchPerfumeTextBox";
            this.searchPerfumeTextBox.Size = new System.Drawing.Size(131, 20);
            this.searchPerfumeTextBox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Perfumes List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Price";
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(543, 313);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(278, 20);
            this.priceTextbox.TabIndex = 39;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(543, 342);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 42;
            this.label.Text = "Quantity";
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(543, 358);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(278, 20);
            this.quantityTextbox.TabIndex = 41;
            // 
            // exportToExcelButton
            // 
            this.exportToExcelButton.Location = new System.Drawing.Point(26, 484);
            this.exportToExcelButton.Name = "exportToExcelButton";
            this.exportToExcelButton.Size = new System.Drawing.Size(110, 23);
            this.exportToExcelButton.TabIndex = 43;
            this.exportToExcelButton.Text = "Save to Excel";
            this.exportToExcelButton.UseVisualStyleBackColor = true;
            this.exportToExcelButton.Click += new System.EventHandler(this.exportToExcelButton_Click);
            // 
            // brand
            // 
            this.brand.FormattingEnabled = true;
            this.brand.Items.AddRange(new object[] {
            "Armani",
            "Burberry",
            "Byredo",
            "Calvin Klein",
            "Chanel",
            "Creed",
            "Dior",
            "Dolce & Gabbana",
            "Gucci",
            "Jo Malone",
            "Maison Francis Kurkdjian",
            "Prada",
            "Tom Ford",
            "Versace",
            "Yves Saint Laurent"});
            this.brand.Location = new System.Drawing.Point(543, 210);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(280, 21);
            this.brand.TabIndex = 44;
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Items.AddRange(new object[] {
            "Aromatic",
            "Chypre",
            "Citrus",
            "Floral",
            "Fresh",
            "Fruity",
            "Gourmand",
            "Leather",
            "Oriental",
            "Woody"});
            this.categories.Location = new System.Drawing.Point(546, 263);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(277, 21);
            this.categories.TabIndex = 45;
            // 
            // Perfumes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categories);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.exportToExcelButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.quantityTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchPerfumeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletePerfumeButton);
            this.Controls.Add(this.editPerfumeButton);
            this.Controls.Add(this.addPerfumeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.perfumeNameTextbox);
            this.Controls.Add(this.perfumeDataGrid);
            this.Name = "Perfumes";
            this.Size = new System.Drawing.Size(862, 600);
            this.Load += new System.EventHandler(this.Perfumes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfumeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView perfumeDataGrid;
        private System.Windows.Forms.Button deletePerfumeButton;
        private System.Windows.Forms.Button editPerfumeButton;
        private System.Windows.Forms.Button addPerfumeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox perfumeNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchPerfumeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Button exportToExcelButton;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.ComboBox categories;
    }
}
