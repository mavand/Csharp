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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNewM = new System.Windows.Forms.ToolStripMenuItem();
            this.memberNewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutNewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorNewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenM = new System.Windows.Forms.ToolStripMenuItem();
            this.openMemberM = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorkoutM = new System.Windows.Forms.ToolStripMenuItem();
            this.openInstructorM = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSSS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelGrid = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.btnSaveEdt = new System.Windows.Forms.Button();
            this.labelcityedt = new System.Windows.Forms.Label();
            this.labelzipedt = new System.Windows.Forms.Label();
            this.labelstreetedt = new System.Windows.Forms.Label();
            this.labelphoneedt = new System.Windows.Forms.Label();
            this.labelemailedt = new System.Windows.Forms.Label();
            this.labelnameedt = new System.Windows.Forms.Label();
            this.labelssedt = new System.Windows.Forms.Label();
            this.cityoxedt = new System.Windows.Forms.TextBox();
            this.zipboxedt = new System.Windows.Forms.TextBox();
            this.streetboxedt = new System.Windows.Forms.TextBox();
            this.phoneboxedt = new System.Windows.Forms.TextBox();
            this.emailboxedt = new System.Windows.Forms.TextBox();
            this.nameboxedt = new System.Windows.Forms.TextBox();
            this.ssboxedt = new System.Windows.Forms.TextBox();
            this.btnUpdateMem = new System.Windows.Forms.Button();
            this.btnEdtMem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid1)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid1
            // 
            this.dtGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid1.Location = new System.Drawing.Point(29, 198);
            this.dtGrid1.Name = "dtGrid1";
            this.dtGrid1.Size = new System.Drawing.Size(424, 181);
            this.dtGrid1.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.testToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(570, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNewM,
            this.fileOpenM});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // fileNewM
            // 
            this.fileNewM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberNewMenu,
            this.workoutNewMenu,
            this.instructorNewMenu});
            this.fileNewM.Name = "fileNewM";
            this.fileNewM.Size = new System.Drawing.Size(103, 22);
            this.fileNewM.Text = "New";
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
            // fileOpenM
            // 
            this.fileOpenM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMemberM,
            this.openWorkoutM,
            this.openInstructorM});
            this.fileOpenM.Name = "fileOpenM";
            this.fileOpenM.Size = new System.Drawing.Size(103, 22);
            this.fileOpenM.Text = "Open";
            // 
            // openMemberM
            // 
            this.openMemberM.Name = "openMemberM";
            this.openMemberM.Size = new System.Drawing.Size(125, 22);
            this.openMemberM.Text = "Member";
            this.openMemberM.Click += new System.EventHandler(this.memberOpenMenu_Click);
            // 
            // openWorkoutM
            // 
            this.openWorkoutM.Name = "openWorkoutM";
            this.openWorkoutM.Size = new System.Drawing.Size(125, 22);
            this.openWorkoutM.Text = "Workout";
            this.openWorkoutM.Click += new System.EventHandler(this.workoutOpenMenu_Click);
            // 
            // openInstructorM
            // 
            this.openInstructorM.Name = "openInstructorM";
            this.openInstructorM.Size = new System.Drawing.Size(125, 22);
            this.openInstructorM.Text = "Instructor";
            this.openInstructorM.Click += new System.EventHandler(this.instructorOpenMenu_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(459, 356);
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
            this.pictureBox1.Location = new System.Drawing.Point(29, 34);
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
            this.label1.Location = new System.Drawing.Point(165, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 68);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gym Fitness AB\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 125);
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
            this.cBoxSearch.Location = new System.Drawing.Point(162, 145);
            this.cBoxSearch.Name = "cBoxSearch";
            this.cBoxSearch.Size = new System.Drawing.Size(63, 21);
            this.cBoxSearch.TabIndex = 54;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(231, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSSS
            // 
            this.txtSSS.Location = new System.Drawing.Point(231, 145);
            this.txtSSS.Name = "txtSSS";
            this.txtSSS.Size = new System.Drawing.Size(75, 20);
            this.txtSSS.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Name";
            // 
            // labelGrid
            // 
            this.labelGrid.AutoSize = true;
            this.labelGrid.Location = new System.Drawing.Point(29, 179);
            this.labelGrid.Name = "labelGrid";
            this.labelGrid.Size = new System.Drawing.Size(35, 13);
            this.labelGrid.TabIndex = 56;
            this.labelGrid.Text = "label3";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(459, 269);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 57;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Items.AddRange(new object[] {
            "Workout",
            "Instructor"});
            this.cbTable.Location = new System.Drawing.Point(459, 242);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(100, 21);
            this.cbTable.TabIndex = 58;
            // 
            // btnSaveEdt
            // 
            this.btnSaveEdt.Location = new System.Drawing.Point(459, 167);
            this.btnSaveEdt.Name = "btnSaveEdt";
            this.btnSaveEdt.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdt.TabIndex = 73;
            this.btnSaveEdt.Text = "Save";
            this.btnSaveEdt.UseVisualStyleBackColor = true;
            this.btnSaveEdt.Click += new System.EventHandler(this.btnSaveEdt_Click);
            // 
            // labelcityedt
            // 
            this.labelcityedt.AutoSize = true;
            this.labelcityedt.Location = new System.Drawing.Point(456, 115);
            this.labelcityedt.Name = "labelcityedt";
            this.labelcityedt.Size = new System.Drawing.Size(24, 13);
            this.labelcityedt.TabIndex = 72;
            this.labelcityedt.Text = "City";
            // 
            // labelzipedt
            // 
            this.labelzipedt.AutoSize = true;
            this.labelzipedt.Location = new System.Drawing.Point(456, 76);
            this.labelzipedt.Name = "labelzipedt";
            this.labelzipedt.Size = new System.Drawing.Size(46, 13);
            this.labelzipedt.TabIndex = 71;
            this.labelzipedt.Text = "Zipcode";
            // 
            // labelstreetedt
            // 
            this.labelstreetedt.AutoSize = true;
            this.labelstreetedt.Location = new System.Drawing.Point(456, 34);
            this.labelstreetedt.Name = "labelstreetedt";
            this.labelstreetedt.Size = new System.Drawing.Size(35, 13);
            this.labelstreetedt.TabIndex = 70;
            this.labelstreetedt.Text = "Street";
            // 
            // labelphoneedt
            // 
            this.labelphoneedt.AutoSize = true;
            this.labelphoneedt.Location = new System.Drawing.Point(350, 154);
            this.labelphoneedt.Name = "labelphoneedt";
            this.labelphoneedt.Size = new System.Drawing.Size(38, 13);
            this.labelphoneedt.TabIndex = 69;
            this.labelphoneedt.Text = "Phone";
            // 
            // labelemailedt
            // 
            this.labelemailedt.AutoSize = true;
            this.labelemailedt.Location = new System.Drawing.Point(353, 115);
            this.labelemailedt.Name = "labelemailedt";
            this.labelemailedt.Size = new System.Drawing.Size(32, 13);
            this.labelemailedt.TabIndex = 68;
            this.labelemailedt.Text = "Email";
            // 
            // labelnameedt
            // 
            this.labelnameedt.AutoSize = true;
            this.labelnameedt.Location = new System.Drawing.Point(350, 76);
            this.labelnameedt.Name = "labelnameedt";
            this.labelnameedt.Size = new System.Drawing.Size(35, 13);
            this.labelnameedt.TabIndex = 67;
            this.labelnameedt.Text = "Name";
            // 
            // labelssedt
            // 
            this.labelssedt.AutoSize = true;
            this.labelssedt.Location = new System.Drawing.Point(350, 34);
            this.labelssedt.Name = "labelssedt";
            this.labelssedt.Size = new System.Drawing.Size(77, 13);
            this.labelssedt.TabIndex = 66;
            this.labelssedt.Text = "Social Security";
            // 
            // cityoxedt
            // 
            this.cityoxedt.Location = new System.Drawing.Point(459, 131);
            this.cityoxedt.Name = "cityoxedt";
            this.cityoxedt.Size = new System.Drawing.Size(100, 20);
            this.cityoxedt.TabIndex = 65;
            // 
            // zipboxedt
            // 
            this.zipboxedt.Location = new System.Drawing.Point(459, 92);
            this.zipboxedt.Name = "zipboxedt";
            this.zipboxedt.Size = new System.Drawing.Size(100, 20);
            this.zipboxedt.TabIndex = 64;
            // 
            // streetboxedt
            // 
            this.streetboxedt.Location = new System.Drawing.Point(459, 53);
            this.streetboxedt.Name = "streetboxedt";
            this.streetboxedt.Size = new System.Drawing.Size(100, 20);
            this.streetboxedt.TabIndex = 63;
            // 
            // phoneboxedt
            // 
            this.phoneboxedt.Location = new System.Drawing.Point(353, 170);
            this.phoneboxedt.Name = "phoneboxedt";
            this.phoneboxedt.Size = new System.Drawing.Size(100, 20);
            this.phoneboxedt.TabIndex = 62;
            // 
            // emailboxedt
            // 
            this.emailboxedt.Location = new System.Drawing.Point(353, 131);
            this.emailboxedt.Name = "emailboxedt";
            this.emailboxedt.Size = new System.Drawing.Size(100, 20);
            this.emailboxedt.TabIndex = 61;
            // 
            // nameboxedt
            // 
            this.nameboxedt.Location = new System.Drawing.Point(353, 92);
            this.nameboxedt.Name = "nameboxedt";
            this.nameboxedt.Size = new System.Drawing.Size(100, 20);
            this.nameboxedt.TabIndex = 60;
            // 
            // ssboxedt
            // 
            this.ssboxedt.Location = new System.Drawing.Point(353, 53);
            this.ssboxedt.Name = "ssboxedt";
            this.ssboxedt.Size = new System.Drawing.Size(100, 20);
            this.ssboxedt.TabIndex = 59;
            // 
            // btnUpdateMem
            // 
            this.btnUpdateMem.Location = new System.Drawing.Point(459, 298);
            this.btnUpdateMem.Name = "btnUpdateMem";
            this.btnUpdateMem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMem.TabIndex = 75;
            this.btnUpdateMem.Text = "Update";
            this.btnUpdateMem.UseVisualStyleBackColor = true;
            this.btnUpdateMem.Click += new System.EventHandler(this.btnUpdateMem_Click);
            // 
            // btnEdtMem
            // 
            this.btnEdtMem.Location = new System.Drawing.Point(459, 327);
            this.btnEdtMem.Name = "btnEdtMem";
            this.btnEdtMem.Size = new System.Drawing.Size(75, 23);
            this.btnEdtMem.TabIndex = 74;
            this.btnEdtMem.Text = "Edit";
            this.btnEdtMem.UseVisualStyleBackColor = true;
            this.btnEdtMem.Click += new System.EventHandler(this.btnEdtMem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 389);
            this.Controls.Add(this.btnUpdateMem);
            this.Controls.Add(this.btnEdtMem);
            this.Controls.Add(this.btnSaveEdt);
            this.Controls.Add(this.labelcityedt);
            this.Controls.Add(this.labelzipedt);
            this.Controls.Add(this.labelstreetedt);
            this.Controls.Add(this.labelphoneedt);
            this.Controls.Add(this.labelemailedt);
            this.Controls.Add(this.labelnameedt);
            this.Controls.Add(this.labelssedt);
            this.Controls.Add(this.cityoxedt);
            this.Controls.Add(this.zipboxedt);
            this.Controls.Add(this.streetboxedt);
            this.Controls.Add(this.phoneboxedt);
            this.Controls.Add(this.emailboxedt);
            this.Controls.Add(this.nameboxedt);
            this.Controls.Add(this.ssboxedt);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.labelGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSSS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtGrid1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainView";
            this.Text = "Gym Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid1)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrid1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileNewM;
        private System.Windows.Forms.ToolStripMenuItem fileOpenM;
        private System.Windows.Forms.ToolStripMenuItem openMemberM;
        private System.Windows.Forms.ToolStripMenuItem openWorkoutM;
        private System.Windows.Forms.ToolStripMenuItem openInstructorM;
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
        private System.Windows.Forms.Label labelGrid;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Button btnSaveEdt;
        private System.Windows.Forms.Label labelcityedt;
        private System.Windows.Forms.Label labelzipedt;
        private System.Windows.Forms.Label labelstreetedt;
        private System.Windows.Forms.Label labelphoneedt;
        private System.Windows.Forms.Label labelemailedt;
        private System.Windows.Forms.Label labelnameedt;
        private System.Windows.Forms.Label labelssedt;
        private System.Windows.Forms.TextBox cityoxedt;
        private System.Windows.Forms.TextBox zipboxedt;
        private System.Windows.Forms.TextBox streetboxedt;
        private System.Windows.Forms.TextBox phoneboxedt;
        private System.Windows.Forms.TextBox emailboxedt;
        private System.Windows.Forms.TextBox nameboxedt;
        private System.Windows.Forms.TextBox ssboxedt;
        private System.Windows.Forms.Button btnUpdateMem;
        private System.Windows.Forms.Button btnEdtMem;
    }
}

