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
    public partial class RegistrationStudent : Form
    {
        public RegistrationStudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");

        private void addButton_Click(object sender, EventArgs e)
        {
            if (txtSname.Text != string.Empty && deptCombo.Text != string.Empty && txtCgpa.Text != string.Empty)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("insert into Student(s_name,dept,cgpa) values ('" + txtSname.Text + "','" + deptCombo.Text + "','" + txtCgpa.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Succesfully saved");
            }
            else
            {
                MessageBox.Show("Please Fill all the Requirements", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ShowStudent ss = new ShowStudent();
            ss.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }
    }
}
