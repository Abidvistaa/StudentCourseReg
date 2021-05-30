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
    public partial class UpdateCourse : Form
    {
        public UpdateCourse()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");
        public int cid;
        public int sid;
        private void UpdateCourse_Load(object sender, EventArgs e)
        {
            getStudentInfo1();
            getStudentInfo2();
        }
        private void getStudentInfo1()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select distinct * from Course", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            upCourseGrid.DataSource = dt;
            con.Close();
        }
        private void getStudentInfo2()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select distinct * from Section", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            upSecGrid.DataSource = dt;
            con.Close();
        }

        private void upCourseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cid = Convert.ToInt32(upCourseGrid.SelectedRows[0].Cells[0].Value);
            courseidCombo.Text = upCourseGrid.SelectedRows[0].Cells[1].Value.ToString();
            coursenameCombo.Text = upCourseGrid.SelectedRows[0].Cells[2].Value.ToString();
            coursesectionidCombo.Text = upCourseGrid.SelectedRows[0].Cells[3].Value.ToString();

        }
        private void upSecGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            sid = Convert.ToInt32(upSecGrid.SelectedRows[0].Cells[0].Value);
            secidCombo.Text = upSecGrid.SelectedRows[0].Cells[1].Value.ToString();
            if (upSecGrid.SelectedRows[0].Cells[2].Value.ToString() == "A")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            if (cid > 0)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("update Course set c_id='" + courseidCombo.Text + "',c_name='" + coursenameCombo.Text + "',c_sec_id='" + coursesectionidCombo.Text + "' where id='" + this.cid + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Course Updated Successfully");
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }


        }

        private void updatesecButton_Click(object sender, EventArgs e)
        {
            

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ShowCourse sc = new ShowCourse();
            sc.Show();
            this.Hide();
        }

        private void updatesecButton_Click_1(object sender, EventArgs e)
        {
            string chooseRadio = "";

            if (radioButton1.Checked)
            {
                chooseRadio = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                chooseRadio = radioButton2.Text;
            }

            if (sid > 0)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("update Section set sec_id='" + secidCombo.Text + "',sec_name='" + chooseRadio + "' where secID='" + this.sid + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Section Updated Successfully");
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }
        }

        private void deletecourseButton_Click(object sender, EventArgs e)
        {
            if (cid > 0)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("delete from Course where id='" + this.cid + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Course deleted");
            }
            else
            {
                MessageBox.Show("Plesae select a row");
            }
        }

        private void deletesecButton_Click(object sender, EventArgs e)
        {
            if (sid > 0)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("delete from Section where secID='" + this.sid + "'", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Section deleted");
            }
            else
            {
                MessageBox.Show("Plesae select a row");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            UpdateCourse uc = new UpdateCourse();
            uc.Show();
            this.Hide();
        }
    }
}
