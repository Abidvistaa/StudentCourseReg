using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCourseReg
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowInformationCourse sic = new ShowInformationCourse();
            sic.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ShowInformation si = new ShowInformation();
            si.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
