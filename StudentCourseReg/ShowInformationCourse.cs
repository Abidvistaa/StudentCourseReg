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
    public partial class ShowInformationCourse : Form
    {
        public ShowInformationCourse()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");

        private void ShowInformationCourse_Load(object sender, EventArgs e)
        {
            getTeacherInfo();
        }
        private void getTeacherInfo()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select distinct t_name,dept,Course.c_id,c_name,sec_name from Teacher,Course,Section where Teacher.t_sec_id=Section.sec_id and Teacher.c_id=Course.c_id", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            int numRows = dataGridView1.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Course where c_name like '" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            int numRows = dataGridView1.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();
        }
    }
}
