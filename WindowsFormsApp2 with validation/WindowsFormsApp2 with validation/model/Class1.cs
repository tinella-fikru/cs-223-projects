using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_with_validation.model
{
    internal class Class1
    {
        static private List<Class1> class1 = new List<Class1>();
        public string Id { get; set; }
        public string ObjectName { get; set; }



        public string inventoryNumber { get; set; }

        public double price { get; set; }

        public string count { get; set; }

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
    

