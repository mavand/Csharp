namespace Another.View
{
    partial class NewWorkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewWorkout));
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtwID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.wID = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtwID
            // 
            this.txtwID.Location = new System.Drawing.Point(13, 26);
            this.txtwID.Name = "txtwID";
            this.txtwID.Size = new System.Drawing.Size(100, 20);
            this.txtwID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(157, 26);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 4;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(157, 66);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 5;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(157, 104);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 6;
            // 
            // wID
            // 
            this.wID.AutoSize = true;
            this.wID.Location = new System.Drawing.Point(12, 10);
            this.wID.Name = "wID";
            this.wID.Size = new System.Drawing.Size(44, 13);
            this.wID.TabIndex = 7;
            this.wID.Text = "WorkID";
            this.wID.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 8;
            this.name.Text = "Name";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(12, 89);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(30, 13);
            this.date.TabIndex = 9;
            this.date.Text = "Date";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(154, 10);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(30, 13);
            this.time.TabIndex = 10;
            this.time.Text = "Time";
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(154, 50);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(40, 13);
            this.length.TabIndex = 11;
            this.length.Text = "Length";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(154, 88);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(33, 13);
            this.level.TabIndex = 12;
            this.level.Text = "Level";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(12, 105);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // NewWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.level);
            this.Controls.Add(this.length);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.name);
            this.Controls.Add(this.wID);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtwID);
            this.Controls.Add(this.btnAdd);
            this.Name = "NewWorkout";
            this.Text = "NewWorkout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtwID;
        private System.Windows.Forms.Label wID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.PictureBox pictureBox1;
      
    }
}