using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.model;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1
            {
                Name = (txt_name.Text),

                Email = (txt_email.Text),
                
            };
            c.save();
        }
    }
}
