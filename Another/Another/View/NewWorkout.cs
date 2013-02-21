using Another.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Another.View
{
    public partial class NewWorkout : Form
    {
        WorkoutController wcont = new WorkoutController();
        Dal dal = new Dal();

        public NewWorkout()
        {
            InitializeComponent();
        }

         private void ClearFields()
        {
            txtNewWorkId.Text = string.Empty;
            txtNewWorkNm.Text = string.Empty;
            txtNewWorkDt.Text = string.Empty;
            txtNewWorkTm.Text = string.Empty;
            txtNewWorkLt.Text = string.Empty;
            txtNewWorkLv.Text = string.Empty;
            
        }

         private void btnAdd_Click(object sender, EventArgs e)
         {

             if (String.IsNullOrEmpty(txtNewWorkId.Text) || String.IsNullOrEmpty(txtNewWorkNm.Text) || String.IsNullOrEmpty(txtNewWorkDt.Text)
                || String.IsNullOrEmpty(txtNewWorkTm.Text) || String.IsNullOrEmpty(txtNewWorkLt.Text) || String.IsNullOrEmpty(txtNewWorkLv.Text))
             {

                 MessageBox.Show("Please fill out all the fields");
             }
             else
             {
                 try
                 {
                     wcont.NewWorkout(txtNewWorkId.Text, txtNewWorkNm.Text, txtNewWorkDt.Text, txtNewWorkTm.Text, txtNewWorkLt.Text, txtNewWorkLv.Text);
                     MessageBox.Show("Added");
                     ClearFields();

                 }
                 catch (SqlException)
                 {
                     MessageBox.Show("The WorkID \"" + txtNewWorkId.Text + "\"is already registered");
                 }
             }
         }

         private void label1_Click(object sender, EventArgs e)
         {

         }


            }
        }
        

        

    

