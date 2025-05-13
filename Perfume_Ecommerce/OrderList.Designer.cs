namespace EDP
{
    partial class OrderList
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
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.excelSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(160, 45);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.Size = new System.Drawing.Size(487, 405);
            this.orderGridView.TabIndex = 1;
            // 
            // excelSave
            // 
            this.excelSave.Location = new System.Drawing.Point(358, 470);
            this.excelSave.Name = "excelSave";
            this.excelSave.Size = new System.Drawing.Size(106, 23);
            this.excelSave.TabIndex = 2;
            this.excelSave.Text = "Save to Excel";
            this.excelSave.UseVisualStyleBackColor = true;
            this.excelSave.Click += new System.EventHandler(this.excelSave_Click);
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.excelSave);
            this.Controls.Add(this.orderGridView);
            this.Name = "OrderList";
            this.Size = new System.Drawing.Size(840, 600);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Button excelSave;
    }
}
