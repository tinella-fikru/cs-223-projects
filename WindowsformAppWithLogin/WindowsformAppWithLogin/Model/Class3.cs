using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsformAppWithLogin.Model
{
    internal class Class3
    {
        static private List<Class3> class3 = new List<Class3>();
        public static addProduct findProduct(string name)
        {
            return getAllProducts().Find(class3 => c.Name == name);
        }
       
        public void save()
        {
            class3.Add(this);
            MessageBox.Show("Query executed");
        }


        public static List<Class3> getAllProducts()
        {
            return class3;
        }

    }
}
