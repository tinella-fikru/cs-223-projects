using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsformAppWithLogin.Model
{
    internal class Class1
    {
        static private List<Class1> temp = new List<Class1>();
        static private List<Class1> class1 = new List<Class1>();
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Age_Above_30 { get; set; }
        public bool Male { get; set; }
        public bool Female { get; set; }
        public int phone { get; set; }




        public void save()
        {
            try
            {
                class1.Add(this);
                string connectionString = @"Data Source=TINELLA\SQLEXPRESS; Initial catalog=db;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("connection successful!!!");

                string Query = "insert into employee values(" + this.Id + ", '" + this.Name + "',  '" + "', '" + this.phone + "')";

                SqlCommand cmd = new SqlCommand(Query, connection);

                var result = cmd.ExecuteNonQuery();
                connection.Close();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {

                    MessageBox.Show("Saved Successfully!!!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
        //MessageBox.Show("Query executed");

        public static Class1 findOne(string name)
        {
            try
            {
                string connectionString = @"Data Source=TINELLA\SQLEXPRESS; Initial catalog=db;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("connection successful!!!");

                string Query = "select * from employee;";
                SqlCommand cmd = new SqlCommand(Query, connection);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())

                {
                    Class1 c = new Class1();

                    c.Id = (string)sdr[0];
                    c.Name = (string)sdr[1];
                    c.phone = (int)sdr[2];

                    temp.Add(c);
                }
                connection.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return class1.Find(c => c.Name == name);
        }

        public static List<Class1> getAllProducts()
        {
            try
            {
                string connectionString = @"Data Source=TINELLA\SQLEXPRESS; Initial catalog=db;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("connection successful!!!");

                string Query = "select * from employee;";
                SqlCommand cmd = new SqlCommand(Query, connection);

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())

                {
                    Class1 c = new Class1();

                    c.Id = (string)sdr[0];
                    c.Name = (string)sdr[1];
                    c.phone = (int)sdr[2];

                    /* int rowsAffected = cmd.ExecuteNonQuery();
                     string r = rowsAffected.ToString();
                     MessageBox.Show("rows affected=" + r);*/

                    temp.Add(c);
                }
                connection.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return temp;
        }
    }
}
     
        



    

