﻿using Another.Controller;
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
    public partial class BookMemberWorkout : Form
    {
        MainController cont = new MainController();
        MemberController mcont = new MemberController();
        BookMemberController bmcont = new BookMemberController();
        Label label1;
        

        public Label Label2
        {
            get { return label; }
            set { label = value; }
        }

        public Label Label1
        {
            get { return label1; }
            set { label1 = value; }
        }

        public BookMemberWorkout(string ss, string name)
        {
            InitializeComponent();
            cbWorkout.Items.Add("Yoga");
            cbWorkout.Items.Add("Aerobics");
            cbWorkout.Items.Add("Boxning");
            label1.Text = ss;
            label.Text = name;
        }

        private void cbWorkout_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtGrid2.DataSource = bmcont.SelectWorkout(cbWorkout.SelectedItem.ToString());
            }
            catch (SqlException e2)
            {
                MessageBox.Show("Connection problem!" + e2.ToString());
            }
        }
        private void btnBook_Click(object sender, EventArgs e)
        {            
            try 
            { 
                bmcont.BookMemberWorkout(label.Text, dtGrid2.CurrentCell.Value.ToString(), dtGrid2.SelectedCells[2].Value.ToString()); 
            }
            catch (SqlException) 
            {
                MessageBox.Show("Already booked"); 
            }
        }
    }
}