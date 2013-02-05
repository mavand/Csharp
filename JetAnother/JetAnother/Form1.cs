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

namespace YetAnother
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=(local);" +
                                       "Integrated Security=true;" +
                                       "database=db2; " +
                                       "connection timeout=30");
        public Form1()
        {
            InitializeComponent();
            Bind();

        }

        private void Clear()
        {
            txtName.Text = string.Empty;
            txtLocation.Text = string.Empty;
        }
        private void Bind()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Student", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into student(SocialSecurity,Name) values(@Name,@Location)", con);
            cmd.Parameters.AddWithValue("Name", txtName.Text);
            cmd.Parameters.AddWithValue("Location", txtLocation.Text);
            try { cmd.ExecuteNonQuery(); }
            catch (Exception e1) { MessageBox.Show(e1.ToString()); }
            con.Close();
            MessageBox.Show("Inserted sucessfully");
            Bind();
            Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand delcmd = new SqlCommand();
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                delcmd.CommandText = "DELETE FROM student WHERE ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                con.Open();
                delcmd.Connection = con;
                delcmd.ExecuteNonQuery();
                con.Close();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Row Deleted");
            }
            Bind();
        }

    }
}
