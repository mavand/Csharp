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

        public MainView()
        {
            InitializeComponent();
            dtGrid1.Visible = false;
            btnDelete.Visible = false;
            labelGrid.Visible = false;
            btnEdtMem.Visible = false;
            labelcityedt.Visible = false;
            labelemailedt.Visible = false;
            labelnameedt.Visible = false;
            labelphoneedt.Visible = false;
            labelssedt.Visible = false;
            labelzipedt.Visible = false;
            labelstreetedt.Visible = false;
            nameboxedt.Visible = false;
            cityoxedt.Visible = false;
            streetboxedt.Visible = false;
            zipboxedt.Visible = false;
            emailboxedt.Visible = false;
            ssboxedt.Visible = false;
            phoneboxedt.Visible = false;
            btnSaveEdt.Visible = false;
            btnUpdateMem.Visible = false;
        }

        private void memberOpenMenu_Click(object sender, EventArgs e)
        {
            try 
            { 
                dtGrid1.DataSource = cont.SelectAll(openMemberM.Text);
                labelGrid.Text = openMemberM.Text;
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
            try 
            { 
                dtGrid1.DataSource = cont.SelectAll(openWorkoutM.Text);
                labelGrid.Text = openWorkoutM.Text;
            }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
            btnDelete.Visible = true;
            labelGrid.Visible = true;
        }

        private void instructorOpenMenu_Click(object sender, EventArgs e)
        {
            try 
            { 
                dtGrid1.DataSource = cont.SelectAll(openInstructorM.Text);
                labelGrid.Text = openInstructorM.Text;
            }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }
            dtGrid1.Visible = true;
            btnDelete.Visible = true;
            labelGrid.Visible = true;
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (labelGrid.Text == "Member")
                    {
                        DialogResult dialogResult = MessageBox.Show("You sure you want to delete this member(s)?", "Delete Member", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                        {
                            mcont.DeleteMember(labelGrid.Text, dtGrid1.CurrentCell.Value.ToString());
                            dtGrid1.Rows.RemoveAt(item.Index);                                                            
                        }
                    }
                    else if (labelGrid.Text == "Workout")
                    {
                        DialogResult dialogResult = MessageBox.Show("You sure you want to delete this Workout(s)?", "Delete Workout", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                        {
                            wcont.DeleteWorkout(labelGrid.Text, dtGrid1.CurrentCell.Value.ToString());
                            dtGrid1.Rows.RemoveAt(item.Index);                                       
                        }
                    }
                    else if (labelGrid.Text == "Instructor")
                    {
                        DialogResult dialogResult = MessageBox.Show("You sure you want to delete this Instructor(s)?", "Delete Instructor", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                        {
                            icont.DeleteInstructor(labelGrid.Text, dtGrid1.CurrentCell.Value.ToString());
                            dtGrid1.Rows.RemoveAt(item.Index);                                                          
                        }
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
                labelGrid.Text = cBoxSearch.SelectedItem.ToString();
                dtGrid1.Visible = true;
                btnDelete.Visible = true;
                labelGrid.Visible = true;
            }
            catch (Exception) { MessageBox.Show("Please choose a table"); }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cbTable.SelectedItem.ToString().Equals("Workout"))
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
            } 
        }

        private void btnEdtMem_Click(object sender, EventArgs e)
        {
            if (labelGrid.Text == openMemberM.Text)
            {


                labelcityedt.Visible = true;
                labelemailedt.Visible = true;
                labelnameedt.Visible = true;
                labelphoneedt.Visible = true;
                labelssedt.Visible = true;
                labelzipedt.Visible = true;
                labelstreetedt.Visible = true;
                nameboxedt.Visible = true;
                cityoxedt.Visible = true;
                streetboxedt.Visible = true;
                zipboxedt.Visible = true;
                emailboxedt.Visible = true;
                ssboxedt.Visible = true;
                phoneboxedt.Visible = true;
                btnSaveEdt.Visible = true;
             
                foreach (DataGridViewRow item in this.dtGrid1.SelectedRows)
                {
                    ssboxedt.Text = item.Cells[0].Value.ToString();
                    nameboxedt.Text = item.Cells[1].Value.ToString();
                    cityoxedt.Text = item.Cells[2].Value.ToString();
                    streetboxedt.Text = item.Cells[3].Value.ToString();
                    zipboxedt.Text = item.Cells[4].Value.ToString();
                    emailboxedt.Text = item.Cells[5].Value.ToString();
                    phoneboxedt.Text = item.Cells[6].Value.ToString();

                }

            }
            else
            {
                MessageBox.Show("Fel, fixar det sen.");

            }

        }

        private void btnSaveEdt_Click(object sender, EventArgs e)
        {
            if (labelGrid.Text == openMemberM.Text)
            {

                if (String.IsNullOrEmpty(ssboxedt.Text) || String.IsNullOrEmpty(nameboxedt.Text) || String.IsNullOrEmpty(cityoxedt.Text) || String.IsNullOrEmpty(streetboxedt.Text) || String.IsNullOrEmpty(zipboxedt.Text) || String.IsNullOrEmpty(emailboxedt.Text) || String.IsNullOrEmpty(phoneboxedt.Text))
                {
                    MessageBox.Show("Please fill out all the fields");
                }
                else
                {
                    try
                    {
                        mcont.EditMember(ssboxedt.Text, nameboxedt.Text, cityoxedt.Text, streetboxedt.Text, zipboxedt.Text, emailboxedt.Text, phoneboxedt.Text, dtGrid1.CurrentCell.Value.ToString());
                        MessageBox.Show("Changes saved succesfully");

                        labelcityedt.Visible = false;
                        labelemailedt.Visible = false;
                        labelnameedt.Visible = false;
                        labelphoneedt.Visible = false;
                        labelssedt.Visible = false;
                        labelzipedt.Visible = false;
                        labelstreetedt.Visible = false;
                        nameboxedt.Visible = false;
                        cityoxedt.Visible = false;
                        streetboxedt.Visible = false;
                        zipboxedt.Visible = false;
                        emailboxedt.Visible = false;
                        ssboxedt.Visible = false;
                        phoneboxedt.Visible = false;
                        btnSaveEdt.Visible = false;
                    }
                    catch (SqlException)
                    {
                        ssboxedt.SelectAll();
                        MessageBox.Show("The social security number \"" + ssboxedt.Text + "\"is already registered");

                    }
                }
            }
            else
            {
                MessageBox.Show("Fel här också");

            }

        }

        private void btnUpdateMem_Click(object sender, EventArgs e)
        {
            try { dtGrid1.DataSource = cont.SelectAll(openMemberM.Text); }
            catch (SqlException e2) { MessageBox.Show(e2.ToString()); }

        }

        //######### TA EJ BORT NEDASTÅEDE RAD!! /MEISAM ###########
        /*private void dtGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show((dtGrid1.CurrentCell.Value.ToString()));
        }*/

    }

}