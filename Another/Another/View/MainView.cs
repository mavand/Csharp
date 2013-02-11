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
using Another.View;

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

        private void memberOpenMenu_Click(object sender, EventArgs e)
        {
            try { dtGrid1.DataSource = cont.SelectAll(memberOpenMenu.Text); }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
            btnDelete.Visible = true;
        }

        private void workoutOpenMenu_Click(object sender, EventArgs e)
        {
            try { dtGrid1.DataSource = cont.SelectAll(workoutOpenMenu.Text); }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
        }

        private void instructorOpenMenu_Click(object sender, EventArgs e)
        {
            try { dtGrid1.DataSource = cont.SelectAll(instructorOpenMenu.Text); }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
        }

        /*private void dtGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(" Value at 0,0" + dtGrid1.Rows[0].Cells[0].Value);
            }
        }*/
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
            {
                cont.DeleteMembers(dtGrid1.CurrentCell.Value.ToString());
                dtGrid1.Rows.RemoveAt(item.Index);
            }


        }
        
        private void memberNewMenu_Click(object sender, EventArgs e)
        {
            NewMember newMember = new NewMember();
            newMember.ShowDialog();
        }

        private void instructorNewMenu_Click(object sender, EventArgs e)
        {
            NewInstructor newInstructor = new NewInstructor();
            newInstructor.ShowDialog();
        }



        private void workoutNewMenu_Click(object sender, EventArgs e)
        {
            NewWorkout newWorkout = new NewWorkout();
            newWorkout.ShowDialog();
        }


        /*private void dtGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show((dtGrid1.CurrentCell.Value.ToString()));
        }*/

    }

}