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
    public partial class NewInstructor : Form
    {
        InstructorController icont = new InstructorController();
        Dal dal = new Dal();


        public NewInstructor()
        {
            InitializeComponent();

        }

        private void ClearFields()
        {
            txtNewInstId.Text = string.Empty;
            txtNewInstSS.Text = string.Empty;
            txtNewInstNm.Text = string.Empty;
            txtNewInstCt.Text = string.Empty;
            txtNewInstSt.Text = string.Empty;
            txtNewInstZip.Text = string.Empty;
            txtNewInstEm.Text = string.Empty;
            txtNewInstPh.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtNewInstId.Text) || String.IsNullOrEmpty(txtNewInstSS.Text) || String.IsNullOrEmpty(txtNewInstNm.Text) || String.IsNullOrEmpty(txtNewInstCt.Text) || String.IsNullOrEmpty(txtNewInstSt.Text) || String.IsNullOrEmpty(txtNewInstZip.Text) || String.IsNullOrEmpty(txtNewInstEm.Text) || String.IsNullOrEmpty(txtNewInstPh.Text))
            {
                MessageBox.Show("Please fill out all the fields");
            }
            else
            {
                try
                {
                    try
                    {
                        icont.NewInstructor(txtNewInstId.Text, txtNewInstSS.Text, txtNewInstNm.Text, txtNewInstCt.Text, txtNewInstSt.Text, txtNewInstZip.Text, txtNewInstEm.Text, txtNewInstPh.Text);
                        MessageBox.Show("Added");
                        ClearFields();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("The Instructor ID \"" + txtNewInstId.Text + "\"is already registered");
                    }
                }
                catch (SqlException e2)
                {
                    MessageBox.Show("Connection problem!" + e2.ToString());
                }

            }
        }
    }

}
   

