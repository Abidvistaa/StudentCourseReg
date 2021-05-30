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
    public partial class AssignCourse : Form
    {
        public AssignCourse()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            if (courseidCombo.Text != string.Empty && coursenameCombo.Text != string.Empty && coursesectionidCombo.Text != string.Empty)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("insert into Course(c_id,c_name,c_sec_id) values ('" + courseidCombo.Text + "','" + coursenameCombo.Text + "','" + coursesectionidCombo.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Succesfully saved");
            }
            else
            {
                MessageBox.Show("Please Fill all the Requirements", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addsecButton_Click(object sender, EventArgs e)
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
            

            if (secidCombo.Text != string.Empty && chooseRadio != string.Empty)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("insert into Section(sec_id,sec_name) values ('" + secidCombo.Text + "','" + chooseRadio + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Succesfully saved");
            }
            else
            {
                MessageBox.Show("Please Fill all the Requirements", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showcourseButton_Click(object sender, EventArgs e)
        {
            ShowCourse sc = new ShowCourse();
            sc.Show();
            this.Hide();
        }

        private void AssignCourse_Load(object sender, EventArgs e)
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
