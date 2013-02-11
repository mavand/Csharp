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

namespace Another
{
    public partial class Form1 : Form
    {
        TController cont = new TController();

        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void btnQuery_Click(object sender, EventArgs e)
        {
           
            }
=======
        
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dtGrid1.DataSource = cont.Query();
                       
        }
>>>>>>> Zadam
    }
}
