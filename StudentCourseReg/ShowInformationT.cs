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

namespace StudentCourseReg
{
    public partial class ShowInformationT : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");

        public ShowInformationT()
        {
            InitializeComponent();
        }
        private void ShowInformationT_Load(object sender, EventArgs e)
        {
            getTeacherInfo();
        }
        private void getTeacherInfo()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select t_name,dept,c_id from Teacher", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            int numRows = dataGridView1.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }
    }
}
