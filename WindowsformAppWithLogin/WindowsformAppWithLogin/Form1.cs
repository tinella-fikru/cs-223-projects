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
        public Form1(string name)
        {

            InitializeComponent();
            label1.Text = name;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string checkedItems = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedItems += item.ToString() + " ";

            }
            MessageBox.Show("You have a degree in:"+checkedItems);



            Class1 c = new Class1
                {
                    Id = (txt_id.Text),

                    Name = (txt_name.Text),
                    phone = (txt_ph.Text),
                    Age_Above_30 = chkBox1.Checked,
                    Male = rdb_male.Checked,
                    Female = rdb_female.Checked,
                    // Degree_in = checkedItems.AsParallel,



                };


            
            

            Regex r = new Regex(@"^([^0-9]*)$");
            if (txt_ph.Text.Length == 10)
            {
                if (r.IsMatch(txt_ph.Text))
                {


                    
                }
                
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
            else
            {
                errorProvider1.Clear();
                c.save();
            }
            dgvAdd.DataSource = null;
            dgvAdd.DataSource = Class1.getAllProducts();


        }
    
              private void dgvAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
              {

              }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



    


