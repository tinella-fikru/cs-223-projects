using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.model
{
    internal class Class1
    {
        static private List<Class1> class1 = new List<Class1>();

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string confirmPassword { get; set; }

        public int phone { get; set; }




        public void save()
        {
            class1.Add(this);
            MessageBox.Show("Successfully Signed In!!!");
        }
        public static Class1 findOne(string name)
        {
            return class1.Find(c => c.Name == name);
        }

        public static List<Class1> getAllProducts()
        {
            return class1;
        }
    }
}

