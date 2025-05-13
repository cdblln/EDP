namespace EDP
{
    partial class reviewSection
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
            this.reviewGridView = new System.Windows.Forms.DataGridView();
            this.excelSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reviewGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewGridView
            // 
            this.reviewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewGridView.Location = new System.Drawing.Point(29, 68);
            this.reviewGridView.Name = "reviewGridView";
            this.reviewGridView.Size = new System.Drawing.Size(740, 405);
            this.reviewGridView.TabIndex = 0;
            // 
            // excelSave
            // 
            this.excelSave.Location = new System.Drawing.Point(29, 490);
            this.excelSave.Name = "excelSave";
            this.excelSave.Size = new System.Drawing.Size(106, 23);
            this.excelSave.TabIndex = 1;
            this.excelSave.Text = "Save to Excel";
            this.excelSave.UseVisualStyleBackColor = true;
            this.excelSave.Click += new System.EventHandler(this.excelSave_Click);
            // 
            // reviewSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.excelSave);
            this.Controls.Add(this.reviewGridView);
            this.Name = "reviewSection";
            this.Size = new System.Drawing.Size(840, 600);
            ((System.ComponentModel.ISupportInitialize)(this.reviewGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reviewGridView;
        private System.Windows.Forms.Button excelSave;
    }
}
