using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Another.Controller;

namespace Another
{
    public partial class MainView : Form
    {
        TController cont = new TController();

        public MainView()
        {
            InitializeComponent();
            dtGrid1.Visible = false;
            btnDelete.Visible = false;
        }

        private void memberToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try { dtGrid1.DataSource = cont.SelectAll(memberToolStripMenuItem.Text); }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
            btnDelete.Visible = true;
        }

        private void workoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { dtGrid1.DataSource = cont.SelectAll(workoutToolStripMenuItem.Text); }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
        }

        private void instructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { dtGrid1.DataSource = cont.SelectAll(instructorsToolStripMenuItem.Text); }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                dtGrid1.Rows.RemoveAt(item.Index);
            string sql = "Delete from Membere where RowID = @RowID";
            {
              
             //   int rowID = int.Parse(this.DataGridView[0, selectedindex].Value.ToString());
               // string sql = "Delete from member where RowID = @RowId";




                //SqlCommand cmd = new SqlCommand ("Delete from members WHERE ([SocialSecurity] = @SocialSecurity", 



            }



        }




        public DataGridView DataGridView { get; set; }
    }

}