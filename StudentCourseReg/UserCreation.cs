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
    public partial class UserCreation : Form
    {
        public UserCreation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty && statusCombo.Text != string.Empty)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("insert into UserTable (username,password,status)values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + statusCombo.Text + "')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User Successfully Created");

                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Fill all the Requirements");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
