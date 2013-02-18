using Another.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        //Label label2;

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
            dtGrid2.DataSource = bmcont.selectWorkout(cbWorkout.SelectedItem.ToString());
        }

    }
}





/*private void btnBook_Click(object sender, EventArgs e)
{
    if (cbWorkout.Items.Count == 0)
    //PROBLEM! Uppdaterar inte efter att man lägger in en ny workout
    //eftersom items.count då inte är 0
    {
        foreach (DataRow dr in cont.GetWorkout().Rows)
        {
            cbWorkout.Items.Add(dr["name"].ToString());
        }
    } 
}*/