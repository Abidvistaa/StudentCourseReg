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
    public partial class RegistrationTeacher : Form
    {
        public RegistrationTeacher()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");

        private void addButton_Click(object sender, EventArgs e)
        {
            if (txtTname.Text != string.Empty && deptCombo.Text != string.Empty && teachercidCombo.Text != string.Empty && teacherSecCombo.Text!=string.Empty)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("insert into Teacher(t_name,dept,c_id,t_sec_id) values ('" + txtTname.Text + "','" + deptCombo.Text + "','" + teachercidCombo.Text + "','"+teacherSecCombo.Text+"')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Succesfully saved");
            }
            else
            {
                MessageBox.Show("Please Fill all the Requirements", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowTeacher st = new ShowTeacher();
            st.Show();
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
