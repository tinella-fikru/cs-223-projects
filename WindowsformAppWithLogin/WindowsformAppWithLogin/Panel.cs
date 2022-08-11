using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsformAppWithLogin.Model;

namespace WindowsformAppWithLogin
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Gray;
            panel3.Top =50;
            panel3.BackColor = Color.Black;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Orange;
            panel3.Top = 120;
            panel3.BackColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
            panel3.Top = 185;
            panel3.BackColor = Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {

            panel2.BackColor = Color.Red;
            panel3.Top = 260;
            panel3.BackColor = Color.Black;
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in Class2.getAllProducts())
            {
                ProductCard p = new ProductCard();
                p.productname = item.pname;
                p.productid = item.pid;
                p.amount = item.amount;
                p.price = item.price;
                
                flowLayoutPanel1.Controls.Add(p);
            }
        }
    }
}
