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
    public partial class SearchMember : Form
    {
        MemberController mcont = new MemberController();
        MainController cont = new MainController();

        public SearchMember()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtSS.Text = string.Empty;
            txtSSS.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtZipcode.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        MainView mw = new MainView();

        /*private void btnSearch_Click(object sender, EventArgs e)
        {
            //mcont.SearchMember(txtSSS.Text);
            
            mw.dtGrid1.DataSource = mcont.SearchMember(string str);
        }*/
    }
}
