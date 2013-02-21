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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNewWorkId = new System.Windows.Forms.TextBox();
            this.txtNewWorkNm = new System.Windows.Forms.TextBox();
            this.txtNewWorkTm = new System.Windows.Forms.TextBox();
            this.txtNewWorkLt = new System.Windows.Forms.TextBox();
            this.txtNewWorkLv = new System.Windows.Forms.TextBox();
            this.wID = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.txtNewWorkDt = new System.Windows.Forms.TextBox();
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
            // txtNewWorkId
            // 
            this.txtNewWorkId.Location = new System.Drawing.Point(13, 26);
            this.txtNewWorkId.Name = "txtNewWorkId";
            this.txtNewWorkId.Size = new System.Drawing.Size(100, 20);
            this.txtNewWorkId.TabIndex = 1;
            // 
            // txtNewWorkNm
            // 
            this.txtNewWorkNm.Location = new System.Drawing.Point(13, 66);
            this.txtNewWorkNm.Name = "txtNewWorkNm";
            this.txtNewWorkNm.Size = new System.Drawing.Size(100, 20);
            this.txtNewWorkNm.TabIndex = 2;
            // 
            // txtNewWorkTm
            // 
            this.txtNewWorkTm.Location = new System.Drawing.Point(157, 26);
            this.txtNewWorkTm.Name = "txtNewWorkTm";
            this.txtNewWorkTm.Size = new System.Drawing.Size(100, 20);
            this.txtNewWorkTm.TabIndex = 4;
            // 
            // txtNewWorkLt
            // 
            this.txtNewWorkLt.Location = new System.Drawing.Point(157, 66);
            this.txtNewWorkLt.Name = "txtNewWorkLt";
            this.txtNewWorkLt.Size = new System.Drawing.Size(100, 20);
            this.txtNewWorkLt.TabIndex = 5;
            // 
            // txtNewWorkLv
            // 
            this.txtNewWorkLv.Location = new System.Drawing.Point(157, 104);
            this.txtNewWorkLv.Name = "txtNewWorkLv";
            this.txtNewWorkLv.Size = new System.Drawing.Size(100, 20);
            this.txtNewWorkLv.TabIndex = 6;
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
            // txtNewWorkDt
            // 
            this.txtNewWorkDt.Location = new System.Drawing.Point(12, 105);
            this.txtNewWorkDt.Name = "txtNewWorkDt";
            this.txtNewWorkDt.Size = new System.Drawing.Size(100, 20);
            this.txtNewWorkDt.TabIndex = 13;
            // 
            // NewWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtNewWorkDt);
            this.Controls.Add(this.level);
            this.Controls.Add(this.length);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.name);
            this.Controls.Add(this.wID);
            this.Controls.Add(this.txtNewWorkLv);
            this.Controls.Add(this.txtNewWorkLt);
            this.Controls.Add(this.txtNewWorkTm);
            this.Controls.Add(this.txtNewWorkNm);
            this.Controls.Add(this.txtNewWorkId);
            this.Controls.Add(this.btnAdd);
            this.Name = "NewWorkout";
            this.Text = "NewWorkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewWorkId;
        private System.Windows.Forms.Label wID;
        private System.Windows.Forms.TextBox txtNewWorkNm;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox txtNewWorkTm;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox txtNewWorkLt;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.TextBox txtNewWorkLv;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.TextBox txtNewWorkDt;
      
    }
}