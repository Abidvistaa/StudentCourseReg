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
    public partial class ShowCourse : Form
    {
        public ShowCourse()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");
        public int cid;
        

        private void ShowCourse_Load(object sender, EventArgs e)
        {
            getStudentInfo();
        }
        private void getStudentInfo()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select distinct Course.id,c_id,c_name,sec_name from Course,Section where Course.c_sec_id=Section.sec_id ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            showcourseGrid.DataSource = dt;
            con.Close();
            int numRows = showcourseGrid.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateCourse uc = new UpdateCourse();
            uc.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            UpdateCourse uc = new UpdateCourse();
            uc.Show();
            this.Hide();
            
        }

        private void showcourseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cid = Convert.ToInt32(showcourseGrid.SelectedRows[0].Cells[0].Value);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void addmoreButton_Click(object sender, EventArgs e)
        {
            AssignCourse ac = new AssignCourse();
            ac.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from course where c_name like '" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            showcourseGrid.DataSource = dt;
            con.Close();
            int numRows = showcourseGrid.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();
        }
    }
}
