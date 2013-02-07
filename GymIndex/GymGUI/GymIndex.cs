using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            NewEmp em = new NewEmp();
            em.Show();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            NewMem me = new NewMem();
            me.Show();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            NewWork wo = new NewWork();
            wo.Show();
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            EditEmp ee = new EditEmp();
            ee.Show();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            EditMem em = new EditMem();
            em.Show();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            EditWork ew = new EditWork();
            ew.Show();
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            DeleteEmp de = new DeleteEmp();
            de.Show();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            DeleteMem dm = new DeleteMem();
            dm.Show();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            DeleteWork dw = new DeleteWork();
            dw.Show();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            OpenEmp oe = new OpenEmp();
            oe.Show();
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            OpenMem om = new OpenMem();
            om.Show();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            OpenWork ow = new OpenWork();
            ow.Show();
        }
    }
}
