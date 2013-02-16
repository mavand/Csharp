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
        MainController cont = new MainController();
        MemberController mcont = new MemberController();
       // InstructorController icont = new InstructorController();
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
            btnDelete.Visible = true;
        }

        private void instructorOpenMenu_Click(object sender, EventArgs e)
        {
            try { dtGrid1.DataSource = cont.SelectAll(instructorOpenMenu.Text); }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
            btnDelete.Visible = true;
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("You sure you want to delete this member(s)?", "Delete Member", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)

                    foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                    {
                        mcont.DeleteMembers(dtGrid1.CurrentCell.Value.ToString());
                        dtGrid1.Rows.RemoveAt(item.Index);
                        // icont.DeleteInstructors(dtGrid1.CurrentCell.Value.ToString());
                        //     dtGrid1.Rows.RemoveAt(item.Index);                                  
                    }
            }
            catch (SqlException e2) {MessageBox.Show("du måste välja en rad med ifyllda värden" +e2.ToString());
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dtGrid1.DataSource = cont.SearchAll(cBoxSearch.SelectedItem.ToString(), txtSSS.Text);
                dtGrid1.Visible = true;
            }
            catch (Exception) { MessageBox.Show("Please choose a table"); }
        }

        //######### TA EJ BORT NEDASTÅEDE RAD!! /MEISAM ###########
        /*private void dtGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show((dtGrid1.CurrentCell.Value.ToString()));
        }*/

    }

}