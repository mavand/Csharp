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
        InstructorController icont = new InstructorController();
        WorkoutController wcont = new WorkoutController();
        MemberWorkoutController mwcont = new MemberWorkoutController();

        public MainView()
        {
            InitializeComponent();
            dtGrid1.Visible = false;
            btnDelete.Visible = false;
            labelGrid.Visible = false;
            btnEdtMem.Visible = false;
            btnUpdateMem.Visible = false;
            panelMem.Visible = false;
            panelWork.Visible = false;
            panelInst.Visible = false;
            btnSaveEdit.Visible = false;
            btnCancel.Visible = false;
            btnBookings.Visible = false;
        }        

        private void AdjustColumnOrderInstructor()
        {
            dtGrid1.Columns["InstID"].DisplayIndex = 0;
            dtGrid1.Columns["SocialSecurity"].DisplayIndex = 1;
            dtGrid1.Columns["Name"].DisplayIndex = 2;
            dtGrid1.Columns["City"].DisplayIndex = 3;
            dtGrid1.Columns["Street"].DisplayIndex = 4;
            dtGrid1.Columns["ZipCode"].DisplayIndex = 5;
            dtGrid1.Columns["Email"].DisplayIndex = 6;
            dtGrid1.Columns["Phone"].DisplayIndex = 7;
        }

        private void memberOpenMenu_Click(object sender, EventArgs e)
        {
            panelWork.Visible = false;
            panelInst.Visible = false;
            try 
            { 
                dtGrid1.DataSource = cont.SelectAll(openMemberM.Text);
                labelGrid.Text = openMemberM.Text;
                btnBookings.Visible = true;
            }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }

            dtGrid1.Visible = true;
            btnDelete.Visible = true;
            labelGrid.Visible = true;
            btnEdtMem.Visible = true;
            btnUpdateMem.Visible = true;
        }

        private void workoutOpenMenu_Click(object sender, EventArgs e)
        {
            panelMem.Visible = false;
            panelInst.Visible = false;
            try 
            {
                btnBookings.Visible = false;
                dtGrid1.DataSource = cont.SelectAll(openWorkoutM.Text);
                labelGrid.Text = openWorkoutM.Text; 
               
            }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
            btnDelete.Visible = true;
            labelGrid.Visible = true;
            btnEdtMem.Visible = true;
            btnUpdateMem.Visible = true;
            

        }

        private void instructorOpenMenu_Click(object sender, EventArgs e)
        {
            panelMem.Visible = false;
            panelWork.Visible = false;
            try 
            {
                btnBookings.Visible = false;
                dtGrid1.DataSource = cont.SelectAll(openInstructorM.Text);                
                labelGrid.Text = openInstructorM.Text;
                AdjustColumnOrderInstructor();
            }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
            btnDelete.Visible = true;
            labelGrid.Visible = true;
            btnEdtMem.Visible = true;
            btnUpdateMem.Visible = true;
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGrid1.SelectedCells[0].Value != null)
                {
                    if (labelGrid.Text == "Member")
                    {
                        DialogResult dialogResult = MessageBox.Show("You sure you want to delete this member?", "Delete Member", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                            foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                            {
                                mcont.DeleteMember(labelGrid.Text, dtGrid1.CurrentCell.Value.ToString());
                                dtGrid1.Rows.RemoveAt(item.Index);
                            }
                    }
                    else if (labelGrid.Text == "Workout")
                    {
                        DialogResult dialogResult = MessageBox.Show("You sure you want to delete this Workout?", "Delete Workout", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                            foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                            {
                                wcont.DeleteWorkout(labelGrid.Text, dtGrid1.CurrentCell.Value.ToString());
                                dtGrid1.Rows.RemoveAt(item.Index);
                            }
                    }
                    else if (labelGrid.Text == "Instructor")
                    {
                        DialogResult dialogResult = MessageBox.Show("You sure you want to delete this Instructor?", "Delete Instructor", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                            foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                            {
                                icont.DeleteInstructor(labelGrid.Text, dtGrid1.CurrentCell.Value.ToString());
                                dtGrid1.Rows.RemoveAt(item.Index);
                            }
                    }
                }
                else
                { MessageBox.Show("Please select a row to delete"); }
            }
            catch (SqlException) 
            {
                DialogResult dialogResult = MessageBox.Show(dtGrid1.SelectedCells[1].Value.ToString()+" still has bookings, are you sure you want to proceed?", "Delete Member", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cont.DeleteMW(dtGrid1.SelectedCells[0].Value.ToString());
                    foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                    {
                        mcont.DeleteMember(labelGrid.Text, dtGrid1.CurrentCell.Value.ToString());
                        dtGrid1.Rows.RemoveAt(item.Index);
                    }

                }
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
            panelInst.Visible = false;
            panelMem.Visible = false;
            panelWork.Visible = false;
         
            try
            {
                if (cBoxSearch.SelectedItem.ToString().Equals("Member"))
                {
                    dtGrid1.DataSource = cont.SearchAll(cBoxSearch.SelectedItem.ToString(), txtSSS.Text);
                    labelGrid.Text = cBoxSearch.SelectedItem.ToString();
                    dtGrid1.Visible = true;
                    btnDelete.Visible = true;
                    labelGrid.Visible = true;
                    btnBookings.Visible = true;
                    btnEdtMem.Visible = true;
                    btnUpdateMem.Visible = true;
                }
                else if (cBoxSearch.SelectedItem.ToString().Equals("Workout")) 
                {
                    dtGrid1.DataSource = cont.SearchAll(cBoxSearch.SelectedItem.ToString(), txtSSS.Text);
                    labelGrid.Text = cBoxSearch.SelectedItem.ToString();
                    dtGrid1.Visible = true;
                    btnDelete.Visible = true;
                    labelGrid.Visible = true;
                    btnBookings.Visible = false;
                    btnEdtMem.Visible = true;
                    btnUpdateMem.Visible = true;
                }
                else if (cBoxSearch.SelectedItem.ToString().Equals("Instructor"))
                {
                    dtGrid1.DataSource = cont.SearchAll(cBoxSearch.SelectedItem.ToString(), txtSSS.Text);
                    labelGrid.Text = cBoxSearch.SelectedItem.ToString();
                    dtGrid1.Visible = true;
                    btnDelete.Visible = true;
                    labelGrid.Visible = true;
                    btnBookings.Visible = false;
                    btnEdtMem.Visible = true;
                    btnUpdateMem.Visible = true;
                    AdjustColumnOrderInstructor();
                }
            }
            catch (Exception) { MessageBox.Show("Please choose a table"); }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cbTable.SelectedItem == null)
            {
                MessageBox.Show("Please choose what too book");
            }
            else if (labelGrid.Text == "Member" && cbTable.SelectedItem.ToString().Equals("Workout"))
            {
                string name;
                string ss;
                foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                {
                    ss = dtGrid1.CurrentCell.Value.ToString();
                    name = dtGrid1.SelectedCells[1].Value.ToString();
                    BookMemberWorkout bmw = new BookMemberWorkout(ss, name);
                    bmw.Label2.Text = ss;
                    bmw.Label1.Text = name;
                    bmw.ShowDialog();
                }
            }//else if för de andra tabellerna
        }

        private void btnEdtMem_Click(object sender, EventArgs e)
        {
            btnSaveEdit.Visible = true;
            btnCancel.Visible = true;
            if (labelGrid.Text == openMemberM.Text)
            {
                panelMem.Visible = true;

                foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                {
                    txtEditMemSS.Text = item.Cells[0].Value.ToString();
                    txtEditMemNm.Text = item.Cells[1].Value.ToString();
                    txtEditMemCt.Text = item.Cells[2].Value.ToString();
                    txtEditMemSt.Text = item.Cells[3].Value.ToString();
                    txtEditMemZip.Text = item.Cells[4].Value.ToString();
                    txtEditMemEm.Text = item.Cells[5].Value.ToString();
                    txtEditMemPh.Text = item.Cells[6].Value.ToString();

                    txtEditMemSS.ReadOnly = true;

                }

            }
            else if (labelGrid.Text == openWorkoutM.Text)
            {
                
              
                panelWork.Visible = true;
                foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                {
                    txtEditWorkID.Text = item.Cells[0].Value.ToString();
                    txtEditWorkNm.Text = item.Cells[1].Value.ToString();
                    txtEditWorkDt.Text = item.Cells[2].Value.ToString();
                    txtEditWorkTm.Text = item.Cells[3].Value.ToString();
                    txtEditWorkLt.Text = item.Cells[4].Value.ToString();
                    txtEditWorkLv.Text = item.Cells[5].Value.ToString();

                    txtEditWorkID.ReadOnly = true;
                

                }
            }
            else if (labelGrid.Text == openInstructorM.Text)
            {
                
                panelInst.Visible = true;
                foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                {
                    txtEditInstID.Text = item.Cells[0].Value.ToString();
                    txtEditInstSS.Text = item.Cells[1].Value.ToString();
                    txtEditInstNm.Text = item.Cells[2].Value.ToString();
                    txtEditInstCt.Text = item.Cells[3].Value.ToString();
                    txtEditInstSt.Text = item.Cells[4].Value.ToString();
                    txtEditInstZip.Text = item.Cells[5].Value.ToString();
                    txtEditInstEm.Text = item.Cells[6].Value.ToString();
                    txtEditInstPh.Text = item.Cells[7].Value.ToString();

                    txtEditInstID.ReadOnly = true;
                    txtEditInstSS.ReadOnly = true;

                }
            }
        }

        private void btnUpdateMem_Click(object sender, EventArgs e)
        {
            if (labelGrid.Text == openMemberM.Text)
            {
                try { dtGrid1.DataSource = cont.SelectAll(openMemberM.Text); }
                catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            }
            else if (labelGrid.Text == openWorkoutM.Text)
            {
                try { dtGrid1.DataSource = cont.SelectAll(openWorkoutM.Text); }
                catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            }
            else if (labelGrid.Text == openInstructorM.Text)
            {
                try { dtGrid1.DataSource = cont.SelectAll(openInstructorM.Text); }
                catch (SqlException e2) { MessageBox.Show(e2.ToString()); }



            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            
            if (labelGrid.Text == openMemberM.Text)
            {
                if (String.IsNullOrEmpty(txtEditMemSS.Text) || String.IsNullOrEmpty(txtEditMemNm.Text) || String.IsNullOrEmpty(txtEditMemCt.Text) || String.IsNullOrEmpty(txtEditMemSt.Text) || String.IsNullOrEmpty(txtEditMemZip.Text) || String.IsNullOrEmpty(txtEditMemEm.Text) || String.IsNullOrEmpty(txtEditMemPh.Text))
                {
                    MessageBox.Show("Please fill out all the fields");
                }
                else
                {
                    try
                    {
                        mcont.EditMember(txtEditMemSS.Text, txtEditMemNm.Text, txtEditMemCt.Text, txtEditMemSt.Text, txtEditMemZip.Text, txtEditMemEm.Text, txtEditMemPh.Text, dtGrid1.CurrentCell.Value.ToString());
                        MessageBox.Show("Changes saved succesfully");

                        panelMem.Visible = false;
                        btnSaveEdit.Visible = false;
                        btnCancel.Visible = false;
                        
                        try { dtGrid1.DataSource = cont.SelectAll(openMemberM.Text); }
                        catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
                    }
                    catch (SqlException)
                    {
                        txtEditMemSS.SelectAll();
                        MessageBox.Show("The social security number \"" + txtEditMemSS.Text + "\"is already registered");

                    }
                }
            }
            else if (labelGrid.Text == openWorkoutM.Text)
            {

                {
                    if (String.IsNullOrEmpty(txtEditWorkID.Text) || String.IsNullOrEmpty(txtEditWorkNm.Text) || String.IsNullOrEmpty(txtEditWorkDt.Text)
                       || String.IsNullOrEmpty(txtEditWorkTm.Text) || String.IsNullOrEmpty(txtEditWorkLt.Text) || String.IsNullOrEmpty(txtEditWorkLv.Text))
                    {

                        MessageBox.Show("Please fill out all the fields");
                    }
                    else
                    {
                        try
                        {
                            wcont.EditWorkout(txtEditWorkID.Text, txtEditWorkNm.Text, txtEditWorkDt.Text, txtEditWorkTm.Text, txtEditWorkLt.Text, txtEditWorkLv.Text, dtGrid1.CurrentCell.Value.ToString());
                            MessageBox.Show("Changes saved successfully");
                            
                            panelWork.Visible = false;
                            btnSaveEdit.Visible = false;
                            btnCancel.Visible = false;

                            
                            try { dtGrid1.DataSource = cont.SelectAll(openWorkoutM.Text); }
                            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }

                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("The WorkID \"" + txtEditWorkID.Text + "\"is already registered");
                        }
                    }


                }

            }else if (labelGrid.Text == openInstructorM.Text)
            {
                if (String.IsNullOrEmpty(txtEditInstID.Text) || String.IsNullOrEmpty(txtEditInstSS.Text) || String.IsNullOrEmpty(txtEditInstNm.Text) || String.IsNullOrEmpty(txtEditInstCt.Text) || String.IsNullOrEmpty(txtEditInstSt.Text) || String.IsNullOrEmpty(txtEditInstZip.Text) || String.IsNullOrEmpty(txtEditInstEm.Text) || String.IsNullOrEmpty(txtEditInstPh.Text))
                {
                    MessageBox.Show("Please fill out all the fields");

                    
                }
                else
                {
                    try
                    {
                        icont.EditInstructor(txtEditInstID.Text, txtEditInstSS.Text, txtEditInstNm.Text, txtEditInstCt.Text, txtEditInstSt.Text, txtEditInstZip.Text, txtEditInstEm.Text, txtEditInstPh.Text, dtGrid1.CurrentCell.Value.ToString());
                        MessageBox.Show("Changes saved successfully");
                        
                        panelInst.Visible = false;
                        btnSaveEdit.Visible = false;
                        btnCancel.Visible = false;

                        try { dtGrid1.DataSource = cont.SelectAll(openInstructorM.Text); }
                        catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
 
                    }
                    catch (SqlException e2)
                    {
                        MessageBox.Show(e2.ToString());
                    }
                }
            }

        }

        private void btnBookings_Click(object sender, EventArgs e)
        {

            string ss;
            //ss = dtGrid1.CurrentCell.Value.ToString();
            ss = dtGrid1.SelectedCells[0].Value.ToString();            
            try { MemberWorkout memberWorkout = new MemberWorkout(ss); 
                memberWorkout.ShowDialog(); }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (labelGrid.Text == openMemberM.Text)
            {
                 DialogResult dialogResult = MessageBox.Show("Discard all changes?","Discard changes", MessageBoxButtons.YesNo);
                 if (dialogResult == DialogResult.Yes)
                 {

                     panelMem.Visible = false;
                     btnCancel.Visible = false;
                     btnSaveEdit.Visible = false;
                 }
            }
            else if (labelGrid.Text == openWorkoutM.Text)
            {

                DialogResult dialogResult = MessageBox.Show("Discard all changes?","Discard changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    panelWork.Visible = false;
                    btnCancel.Visible = false;
                    btnSaveEdit.Visible = false;
                }
            }
            else if (labelGrid.Text == openInstructorM.Text)
            {
                DialogResult dialogResult = MessageBox.Show("Discard all changes?","Discard changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    panelInst.Visible = false;
                    btnCancel.Visible = false;
                    btnSaveEdit.Visible = false;
                }
            }
        }
    }


        //######### TA EJ BORT NEDASTÅEDE RAD!! /MEISAM ###########
        /*private void dtGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show((dtGrid1.CurrentCell.Value.ToString()));
        }*/

    }

