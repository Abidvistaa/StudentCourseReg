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
    public partial class ShowInformation : Form
    {
        public ShowInformation()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M2BLJA4;Initial Catalog=AuthenticateDemo;Integrated Security=True");
        DataTable dt;

        private void ShowInformation_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Student", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            int numRows = dataGridView1.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();

        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Student where s_name like '"+textBox1.Text+"%'", con);
            dt = new DataTable();
            dt.Clear();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            int numRows = dataGridView1.Rows.Count;
            int actualNum = numRows - 1;
            label3.Text = actualNum.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
