using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsformAppWithLogin.Model
{
    internal class Class2
    {
        static private List<Class2> class2 = new List<Class2>();
        public string pid { get; set; }
        public string pname { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public bool WR { get; set; }
        public bool SR { get; set; }

        public void save()
        {
            class2.Add(this);
            MessageBox.Show("Query executed");
        }


        public static List<Class2> getAllProducts()
        {
            return class2;
        }
    }
}
