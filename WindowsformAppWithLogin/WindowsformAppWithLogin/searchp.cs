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
    public partial class searchp : Form
    {
        public searchp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = Class2.findOne(textBox1.Text);


            if (product == null)
            {
                MessageBox.Show("Product not found");
            }
            else
            {
                MessageBox.Show("Product found");
                Class2.findOne(product.pname);

            
            }
        }
    }
}
