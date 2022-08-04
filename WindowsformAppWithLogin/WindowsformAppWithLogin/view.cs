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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string product;
            
                product = txt_search.Text;
                if (product== null)
                {
                    MessageBox.Show("Employee not found");
                }
            
        }
    }
}
