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
    public partial class UpdateTeacher : Form
    {
        public UpdateTeacher()
        {
            InitializeComponent();
        }
        public int tid;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");


        

        private void UpdateTeacher_Load(object sender, EventArgs e)
        {
            getStudentInfo();
        }
        private void getStudentInfo()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Teacher", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            teacherGrid.DataSource = dt;
            con.Close();
        }

        private void teacherGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tid = Convert.ToInt32(teacherGrid.SelectedRows[0].Cells[0].Value);
            txtTname.Text = teacherGrid.SelectedRows[0].Cells[1].Value.ToString();
            deptCombo.Text = teacherGrid.SelectedRows[0].Cells[2].Value.ToString();
            teachercidCombo.Text = teacherGrid.SelectedRows[0].Cells[3].Value.ToString();
            teacherSecCombo.Text= teacherGrid.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (tid > 0)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("update Teacher set t_name='" + txtTname.Text + "',dept='" + deptCombo.Text + "',c_id='" + teachercidCombo.Text + "',t_sec_id='"+teacherSecCombo.Text+"' where id='" + this.tid + "'", con);
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
            ShowTeacher st = new ShowTeacher();
            st.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateTeacher ut = new UpdateTeacher();
            ut.Show();
            this.Hide();
        }
    }
}
