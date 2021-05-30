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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AssignCourse ac = new AssignCourse();
            ac.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowInformationTT ts = new ShowInformationTT();
            ts.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowStudentTS s = new ShowStudentTS();
            s.Show();
            this.Hide();
        }
    }
}
