using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsformAppWithLogin.Model
{
    internal class Class1
    {
       
        static private List<Class1> class1 = new List<Class1>();
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Age_Above_30 { get; set; }
        public bool Male { get; set; }
        public bool Female { get; set; }
        public int phone { get; set; }

       



        public void save()
        {
            class1.Add(this);
            MessageBox.Show("Query executed");
        }


        public static List<Class1> getAllProducts()
        {
            return class1;
        }



    }
}

