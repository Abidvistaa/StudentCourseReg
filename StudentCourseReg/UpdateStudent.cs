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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        public int sid;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");

        private void UpdateStudent_Load(object sender, EventArgs e)
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
        }
        

        private void studentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sid = Convert.ToInt32(studentGrid.SelectedRows[0].Cells[0].Value);
            txtSname.Text = studentGrid.SelectedRows[0].Cells[1].Value.ToString();
            deptCombo.Text = studentGrid.SelectedRows[0].Cells[2].Value.ToString();
            txtCgpa.Text = studentGrid.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {


            if (sid > 0)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("update Student set s_name='" + txtSname.Text + "',dept='" + deptCombo.Text + "',cgpa='" + txtCgpa.Text + "' where id='" + this.sid + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Updated Successfully");
            }
            else 
            {
                MessageBox.Show("Please Select a Row");
            }
           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ShowStudent st = new ShowStudent();
            st.Show();
            this.Hide();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
