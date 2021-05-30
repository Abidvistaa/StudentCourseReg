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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select status from UserTable where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (txtUsername.Text == string.Empty && txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Fill all the Requirements");
            }
            else 
            {
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][0].ToString() == "Register")
                    {

                        Register r = new Register();
                        r.Show();
                        this.Hide();
                    }
                    else if (dt.Rows[0][0].ToString() == "Student")
                    {

                        Student r = new Student();
                        r.Show();
                        this.Hide();
                    }
                    else if (dt.Rows[0][0].ToString() == "Teacher")
                    {

                        Teacher r = new Teacher();
                        r.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Not Valid User");
                    }

                }
                else
                {
                    MessageBox.Show("Username or Password Incorrect", "incorrext", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            UserCreation cr = new UserCreation();
            cr.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
