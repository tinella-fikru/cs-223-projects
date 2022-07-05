using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.model
{
    internal class Class1
    {
        public string  Name{ get; set; }
        public string Email { get; set; }

        public void save()
        {
            MessageBox.Show("Registered successfully");
        }
    }
}
