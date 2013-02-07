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

namespace GymGUI
{
    public partial class NewMem : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MOMMO-;Initial Catalog=gym;Integrated Security=True");
        SqlCommand cmd;
        public NewMem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewMem_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into member(SocialSecurity, Name, City, Street, Zipcode, Email, Phone) values ('" + textSocialSecurity.Text + "','" + textName.Text + "','" + textCity.Text + "','" + textStreet.Text + "','" + textZipCode.Text + "','" + textEmail.Text + "','" + textPhone.Text + "')" + conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You have successfully inserted values in Member");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }

}


