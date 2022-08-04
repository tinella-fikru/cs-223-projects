using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsformAppWithLogin.Model;

namespace WindowsformAppWithLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            //label1.Text = name;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string checkedItems = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedItems += item.ToString() + " ";

            }
            MessageBox.Show("You have a degree in:"+checkedItems);



           


            
            

            Regex r = new Regex(@"^([^0-9]*)$");
            if (txt_ph.Text.Length == 10)
            {
                
            }

            else
            {
                errorProvider1.SetError(txt_ph, "Please enter 10 digits ");

                
            }
                
            
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                errorProvider1.SetError(txt_id, "Id is required");
            }
            
            if (string.IsNullOrEmpty(txt_name.Text))
            {

                errorProvider1.SetError(txt_name, "Name is required");

            }
           else if (!r.IsMatch(txt_name.Text))
            {
                errorProvider1.SetError(txt_name, "Name shouldn't contain numbers");

            }

            else
            {
                try
                {
                    Class1 c = new Class1
                    {
                        Id = (txt_id.Text),

                        Name = (txt_name.Text),
                        phone = int.Parse(txt_ph.Text),
                        Age_Above_30 = chkBox1.Checked,
                        Male = rdb_male.Checked,
                        Female = rdb_female.Checked,
                        // Degree_in = checkedItems.AsParallel,



                    };
                    c.save();
                    dgvAdd.DataSource = null;
                    dgvAdd.DataSource = Class1.getAllProducts();

                }
                catch(Exception)
                {
                    MessageBox.Show("Type mismatch");
                };
            }

           


        }
    
              private void dgvAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
              {

              }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}



    


