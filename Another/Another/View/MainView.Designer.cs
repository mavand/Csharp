namespace Another
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.dtGrid1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.memberNewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutNewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorNewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.memberOpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutOpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorOpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSSS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid1
            // 
            this.dtGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid1.Location = new System.Drawing.Point(29, 174);
            this.dtGrid1.Name = "dtGrid1";
            this.dtGrid1.Size = new System.Drawing.Size(424, 181);
            this.dtGrid1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenu,
            this.openFileMenu});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newToolStripMenuItem.Text = "File";
            // 
            // newFileMenu
            // 
            this.newFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberNewMenu,
            this.workoutNewMenu,
            this.instructorNewMenu});
            this.newFileMenu.Name = "newFileMenu";
            this.newFileMenu.Size = new System.Drawing.Size(103, 22);
            this.newFileMenu.Text = "New";
            // 
            // memberNewMenu
            // 
            this.memberNewMenu.Name = "memberNewMenu";
            this.memberNewMenu.Size = new System.Drawing.Size(125, 22);
            this.memberNewMenu.Text = "Member";
            this.memberNewMenu.Click += new System.EventHandler(this.memberNewMenu_Click);
            // 
            // workoutNewMenu
            // 
            this.workoutNewMenu.Name = "workoutNewMenu";
            this.workoutNewMenu.Size = new System.Drawing.Size(125, 22);
            this.workoutNewMenu.Text = "Workout";
            this.workoutNewMenu.Click += new System.EventHandler(this.workoutNewMenu_Click);
            // 
            // instructorNewMenu
            // 
            this.instructorNewMenu.Name = "instructorNewMenu";
            this.instructorNewMenu.Size = new System.Drawing.Size(125, 22);
            this.instructorNewMenu.Text = "Instructor";
            this.instructorNewMenu.Click += new System.EventHandler(this.instructorNewMenu_Click);
            // 
            // openFileMenu
            // 
            this.openFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberOpenMenu,
            this.workoutOpenMenu,
            this.instructorOpenMenu});
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.Size = new System.Drawing.Size(103, 22);
            this.openFileMenu.Text = "Open";
            // 
            // memberOpenMenu
            // 
            this.memberOpenMenu.Name = "memberOpenMenu";
            this.memberOpenMenu.Size = new System.Drawing.Size(125, 22);
            this.memberOpenMenu.Text = "Member";
            this.memberOpenMenu.Click += new System.EventHandler(this.memberOpenMenu_Click);
            // 
            // workoutOpenMenu
            // 
            this.workoutOpenMenu.Name = "workoutOpenMenu";
            this.workoutOpenMenu.Size = new System.Drawing.Size(125, 22);
            this.workoutOpenMenu.Text = "Workout";
            this.workoutOpenMenu.Click += new System.EventHandler(this.workoutOpenMenu_Click);
            // 
            // instructorOpenMenu
            // 
            this.instructorOpenMenu.Name = "instructorOpenMenu";
            this.instructorOpenMenu.Size = new System.Drawing.Size(125, 22);
            this.instructorOpenMenu.Text = "Instructor";
            this.instructorOpenMenu.Click += new System.EventHandler(this.instructorOpenMenu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(472, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(472, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(164, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 68);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gym Fitness AB\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Select table";
            // 
            // cBoxSearch
            // 
            this.cBoxSearch.FormattingEnabled = true;
            this.cBoxSearch.Items.AddRange(new object[] {
            "Member",
            "Workout",
            "Instructor"});
            this.cBoxSearch.Location = new System.Drawing.Point(29, 112);
            this.cBoxSearch.Name = "cBoxSearch";
            this.cBoxSearch.Size = new System.Drawing.Size(63, 21);
            this.cBoxSearch.TabIndex = 54;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(98, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSSS
            // 
            this.txtSSS.Location = new System.Drawing.Point(98, 112);
            this.txtSSS.Name = "txtSSS";
            this.txtSSS.Size = new System.Drawing.Size(75, 20);
            this.txtSSS.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Name";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSSS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtGrid1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Gym Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrid1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem memberOpenMenu;
        private System.Windows.Forms.ToolStripMenuItem workoutOpenMenu;
        private System.Windows.Forms.ToolStripMenuItem instructorOpenMenu;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem memberNewMenu;
        private System.Windows.Forms.ToolStripMenuItem workoutNewMenu;
        private System.Windows.Forms.ToolStripMenuItem instructorNewMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSSS;
        private System.Windows.Forms.Label label9;
    }
}

