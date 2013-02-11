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
        TController cont = new TController();
        Dal dal = new Dal();

        public NewWorkout()
        {
            InitializeComponent();
        }

         private void ClearFields()
        {
            txtwID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDate.Text = string.Empty;
            txtTime.Text = string.Empty;
            txtLength.Text = string.Empty;
            txtLevel.Text = string.Empty;
            
        }

         private void btnAdd_Click(object sender, EventArgs e)
         {

             if (String.IsNullOrEmpty(txtwID.Text) || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtDate.Text)
                || String.IsNullOrEmpty(txtTime.Text) || String.IsNullOrEmpty(txtLength.Text) || String.IsNullOrEmpty(txtLevel.Text))
             {

                 MessageBox.Show("Please fill out all the fields");
             }
             else
             {
                 try
                 {
                     cont.NewWorkout(wID.Text, txtName.Text, txtDate.Text, txtTime.Text, txtLength.Text, txtLevel.Text);
                     MessageBox.Show("Added");
                     ClearFields();

                 }
                 catch (SqlException)
                 {
                     MessageBox.Show("The social security number \"" + txtwID.Text + "\"is already registered");
                 }
             }
         }

         private void label1_Click(object sender, EventArgs e)
         {

         }


            }
        }
        

        

    

