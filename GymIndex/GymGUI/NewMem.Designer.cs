namespace GymGUI
{
    partial class NewMem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textSocialSecurity = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textZipCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Social Security";
            // 
            // textSocialSecurity
            // 
            this.textSocialSecurity.Location = new System.Drawing.Point(16, 30);
            this.textSocialSecurity.Name = "textSocialSecurity";
            this.textSocialSecurity.Size = new System.Drawing.Size(100, 20);
            this.textSocialSecurity.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(16, 70);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(16, 110);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // textStreet
            // 
            this.textStreet.Location = new System.Drawing.Point(126, 30);
            this.textStreet.Name = "textStreet";
            this.textStreet.Size = new System.Drawing.Size(100, 20);
            this.textStreet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Street";
            // 
            // textZipCode
            // 
            this.textZipCode.AcceptsReturn = true;
            this.textZipCode.Location = new System.Drawing.Point(126, 70);
            this.textZipCode.Name = "textZipCode";
            this.textZipCode.Size = new System.Drawing.Size(100, 20);
            this.textZipCode.TabIndex = 9;
            this.textZipCode.TextChanged += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zipcode";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(126, 110);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 20);
            this.textCity.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "City";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(16, 149);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 214);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textZipCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textStreet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSocialSecurity);
            this.Controls.Add(this.label1);
            this.Name = "NewMem";
            this.Text = "NewMem";
            this.Load += new System.EventHandler(this.NewMem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSocialSecurity;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textZipCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
    }
}