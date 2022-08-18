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
    public partial class Form2 : Form
    {
        public Form2(string pid,string pName,string amount,string price)
        {
            InitializeComponent();
            label1.Text= pid;
            label2.Text= pName;
            label3.Text= amount;
            label4.Text= price;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
