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
    public partial class MemberWorkout : Form
    {
        MemberWorkoutController mwcont = new MemberWorkoutController();

        public MemberWorkout(string ss)
        {
            InitializeComponent();
            dtGrid.DataSource = mwcont.MemberWorkout(ss);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You sure you want to delete this member(s)?", "Delete Member", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                foreach (DataGridViewRow item in this.dtGrid.SelectedRows)
                {
                    mwcont.DeleteMemberWorkout(dtGrid.CurrentCell.Value.ToString(), dtGrid.SelectedCells[1].Value.ToString());
                    dtGrid.Rows.RemoveAt(item.Index);
                }
        }
        
    }
}
