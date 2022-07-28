using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsformAppWithLogin
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txt_email.Text == "admin" || txt_email.Text == "user") && txt_pass.Text == "admin")
            {

            }
            else
            {
                MessageBox.Show(" Incorrect!!Try Again");
            }
            Form1 screen = new Form1(txt_email.Text);
            screen.Show();
            this.Hide();
        }
    }
}
