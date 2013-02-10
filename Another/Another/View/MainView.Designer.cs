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
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.newFileMenu.Size = new System.Drawing.Size(152, 22);
            this.newFileMenu.Text = "New";
            this.newFileMenu.Click += new System.EventHandler(this.newFileMenu_Click);
            // 
            // memberNewMenu
            // 
            this.memberNewMenu.Name = "memberNewMenu";
            this.memberNewMenu.Size = new System.Drawing.Size(152, 22);
            this.memberNewMenu.Text = "Member";
            this.memberNewMenu.Click += new System.EventHandler(this.memberNewMenu_Click);
            // 
            // workoutNewMenu
            // 
            this.workoutNewMenu.Name = "workoutNewMenu";
            this.workoutNewMenu.Size = new System.Drawing.Size(152, 22);
            this.workoutNewMenu.Text = "Workout";
            this.workoutNewMenu.Click += new System.EventHandler(this.workoutNewMenu_Click);
            // 
            // instructorNewMenu
            // 
            this.instructorNewMenu.Name = "instructorNewMenu";
            this.instructorNewMenu.Size = new System.Drawing.Size(152, 22);
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
            this.openFileMenu.Size = new System.Drawing.Size(152, 22);
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
            this.btnDelete.Location = new System.Drawing.Point(484, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 389);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtGrid1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

