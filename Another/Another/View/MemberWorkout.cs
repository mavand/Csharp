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
            dtGrid.Columns[3].Visible = false;
            dtGrid.Columns[4].Visible = false;  
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this member(s)?", "Delete Member", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                foreach (DataGridViewRow item in this.dtGrid.SelectedRows)
                {
                    mwcont.DeleteMemberWorkout(dtGrid.SelectedCells[4].Value.ToString(), dtGrid.SelectedCells[3].Value.ToString());
                    dtGrid.Rows.RemoveAt(item.Index);
                }
        }
        
    }
}
