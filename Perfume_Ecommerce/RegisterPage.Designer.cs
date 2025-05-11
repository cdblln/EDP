namespace Register
{
    partial class RegisterPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.firstText = new System.Windows.Forms.TextBox();
            this.lastText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.confText = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.signButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.logbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstText
            // 
            this.firstText.Location = new System.Drawing.Point(140, 30);
            this.firstText.Name = "firstText";
            this.firstText.Size = new System.Drawing.Size(160, 20);
            this.firstText.TabIndex = 0;
            // 
            // lastText
            // 
            this.lastText.Location = new System.Drawing.Point(140, 70);
            this.lastText.Name = "lastText";
            this.lastText.Size = new System.Drawing.Size(160, 20);
            this.lastText.TabIndex = 1;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(140, 110);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(160, 20);
            this.emailText.TabIndex = 2;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(140, 150);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(160, 20);
            this.passText.TabIndex = 3;
            // 
            // confText
            // 
            this.confText.Location = new System.Drawing.Point(140, 190);
            this.confText.Name = "confText";
            this.confText.Size = new System.Drawing.Size(160, 20);
            this.confText.TabIndex = 4;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(140, 230);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 5;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(241, 230);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 6;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(100, 270);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(200, 30);
            this.signButton.TabIndex = 7;
            this.signButton.Text = "Register";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gender";
            // 
            // logbut
            // 
            this.logbut.Location = new System.Drawing.Point(100, 306);
            this.logbut.Name = "logbut";
            this.logbut.Size = new System.Drawing.Size(200, 30);
            this.logbut.TabIndex = 14;
            this.logbut.Text = "Log In";
            this.logbut.UseVisualStyleBackColor = false;
            this.logbut.Click += new System.EventHandler(this.logbut_Click);
            // 
            // RegisterPage
            // 
            this.ClientSize = new System.Drawing.Size(400, 361);
            this.Controls.Add(this.logbut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.confText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.lastText);
            this.Controls.Add(this.firstText);
            this.Name = "RegisterPage";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstText;
        private System.Windows.Forms.TextBox lastText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox confText;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button logbut;
    }
}
