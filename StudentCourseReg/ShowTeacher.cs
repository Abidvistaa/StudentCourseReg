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
    public partial class ShowTeacher : Form
    {
        public ShowTeacher()
        {
            InitializeComponent();
        }
        public int tid;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");

       

        private void ShowTeacher_Load(object sender, EventArgs e)
        {
            getTeacherInfo();
        }

        private void getTeacherInfo()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Teacher", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            teacherGrid.DataSource = dt;
            con.Close();
            int numRows = teacherGrid.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();
        }

        

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tid > 0)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("delete from Teacher where id='" + this.tid + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Information deleted");
            }
            else
            {
                MessageBox.Show("Plesae select a row");
            }

        }

        private void teacherGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tid = Convert.ToInt32(teacherGrid.SelectedRows[0].Cells[0].Value);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateTeacher ut = new UpdateTeacher();
            ut.Show();
            this.Hide();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            RegistrationTeacher rt = new RegistrationTeacher();
            rt.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Student where s_name like '" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            teacherGrid.DataSource = dt;
            con.Close();
            int numRows = teacherGrid.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();
        }
    }
}
