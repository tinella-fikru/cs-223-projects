﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "user" || textBox2.Text == "user") )
            {

            }
            else
            {
                MessageBox.Show(" Incorrect!!Try Again");
            }
            MainPage screen = new MainPage();
            screen.Show();
            this.Hide();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();


            }


            Form1 form1 = new Form1();
          //  form1.MdiParent = this;
            form1.Show();
        }
    }
}
