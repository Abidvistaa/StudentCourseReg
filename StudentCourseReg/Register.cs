﻿using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RegistrationStudent ss = new RegistrationStudent();
            ss.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationTeacher rt = new RegistrationTeacher();
            rt.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
            
        }
    }
}
