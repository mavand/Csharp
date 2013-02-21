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
        { //Method to clear the fields to allow user to fill these. 
           
            txtNewMemSS.Text = string.Empty;
            txtNewMemNm.Text = string.Empty;
            txtNewMemCt.Text = string.Empty;
            txtNewMemSt.Text = string.Empty;
            txtNewMemZip.Text = string.Empty;
            txtNewMemEm.Text = string.Empty;
            txtNewMemPh.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNewMemSS.Text)||String.IsNullOrEmpty(txtNewMemNm.Text)||String.IsNullOrEmpty(txtNewMemCt.Text)||String.IsNullOrEmpty(txtNewMemSt.Text)||String.IsNullOrEmpty(txtNewMemZip.Text)||String.IsNullOrEmpty(txtNewMemEm.Text)||String.IsNullOrEmpty(txtNewMemPh.Text))
            {
                MessageBox.Show("Please fill out all the fields");
            }
            else
            {
                try 
                { 
                    mcont.NewMember(txtNewMemSS.Text, txtNewMemNm.Text, txtNewMemCt.Text, txtNewMemSt.Text, txtNewMemZip.Text, txtNewMemEm.Text, txtNewMemPh.Text);
                    MessageBox.Show("Added");
                    ClearFields();
                    _mw.PerformRefresh();
                }
                catch (SqlException) 
                { 
                    MessageBox.Show("The Socialsecurity number \"" + txtNewMemSS.Text + "\"is already registered"); 
                }               
            }
            
        }       
    }
}
