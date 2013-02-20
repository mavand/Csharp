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
    public partial class NewMember : Form
    {
        MainController cont = new MainController();
        MemberController mcont = new MemberController();
        Dal dal = new Dal();
        MainView _mw;

        public NewMember(MainView mw)
        {
            InitializeComponent();
            _mw = mw;

        }


        private void ClearFields()
        {
            txtSS.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtZipcode.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSS.Text)||String.IsNullOrEmpty(txtName.Text)||String.IsNullOrEmpty(txtCity.Text)||String.IsNullOrEmpty(txtStreet.Text)||String.IsNullOrEmpty(txtZipcode.Text)||String.IsNullOrEmpty(txtEmail.Text)||String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please fill out all the fields");
            }
            else
            {
                try 
                { 
                    mcont.NewMember(txtSS.Text, txtName.Text, txtCity.Text, txtStreet.Text, txtZipcode.Text, txtEmail.Text, txtPhone.Text);
                    MessageBox.Show("Added");
                    //MainView mw = new MainView();
                    //mw.DtGrid1.DataSource = cont.SearchAll("Member", "");
                    ClearFields();
                    _mw.PerformRefresh();
                }
                catch (SqlException) 
                { 
                    MessageBox.Show("The social security number \"" + txtSS.Text + "\"is already registered"); 
                }               
            }
            
        }       
    }
}
