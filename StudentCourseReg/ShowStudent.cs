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
    public partial class ShowStudent : Form
    {
        public ShowStudent()
        {
            InitializeComponent();
        }
        public int sid;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");
        private void ShowStudent_Load(object sender, EventArgs e)
        {
            getStudentInfo();
        }

        private void getStudentInfo()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Student", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            studentGrid.DataSource = dt;
            con.Close();
            int numRows = studentGrid.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();
        }

        

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (sid > 0)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("delete from Student where id='" + this.sid + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Information deleted");
            }
            else
            {
                MessageBox.Show("Plesae select a row");
            }
        }

        private void studentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sid = Convert.ToInt32(studentGrid.SelectedRows[0].Cells[0].Value);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateStudent us = new UpdateStudent();
            us.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RegistrationStudent rs = new RegistrationStudent();
            rs.Show();
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
            studentGrid.DataSource = dt;
            con.Close();
            int numRows = studentGrid.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
