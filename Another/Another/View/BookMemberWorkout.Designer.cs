namespace Another.View
{
    partial class BookMemberWorkout
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
            this.cbWorkout = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.dtGrid2 = new System.Windows.Forms.DataGridView();
            this.btnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cbWorkout
            // 
            this.cbWorkout.FormattingEnabled = true;
            this.cbWorkout.Location = new System.Drawing.Point(16, 69);
            this.cbWorkout.Name = "cbWorkout";
            this.cbWorkout.Size = new System.Drawing.Size(121, 21);
            this.cbWorkout.TabIndex = 1;
            this.cbWorkout.SelectedIndexChanged += new System.EventHandler(this.cbWorkout_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(101, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 2;
            this.label.Text = "label2";
            // 
            // dtGrid2
            // 
            this.dtGrid2.AllowUserToAddRows = false;
            this.dtGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid2.Location = new System.Drawing.Point(16, 110);
            this.dtGrid2.Name = "dtGrid2";
            this.dtGrid2.Size = new System.Drawing.Size(336, 150);
            this.dtGrid2.TabIndex = 3;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(358, 237);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // BookMemberWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 275);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.dtGrid2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cbWorkout);
            this.Controls.Add(this.label1);
            this.Name = "BookMemberWorkout";
            this.Text = "BookMemberWorkout";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbWorkout;
        private System.Windows.Forms.DataGridView dtGrid2;
        private System.Windows.Forms.Button btnBook;        
    }
}