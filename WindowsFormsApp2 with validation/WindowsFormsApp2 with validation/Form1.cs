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
using WindowsFormsApp2_with_validation.model;

namespace WindowsFormsApp2_with_validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();

            Regex re = new Regex(@"^([^0-9]*)$");

            if (string.IsNullOrEmpty(txt_number.Text))
            {
                errorProvider1.SetError(txt_number, "id is required");
            }
            else if (string.IsNullOrEmpty(txt_in.Text))
            {
                errorProvider1.SetError(txt_in, "Inventory Number is required");
            }
            else if (string.IsNullOrEmpty(txt_cnt.Text))
            {
                errorProvider1.SetError(txt_cnt, "enter count");

            }
            else if (string.IsNullOrEmpty(txt_pr.Text))
            {
                errorProvider1.SetError(txt_pr, "Price is required");
            }
            else if (!re.IsMatch(txt_on.Text))
            {
                errorProvider1.SetError(txt_on, "don't use numbers  ");
            }



            else
            {
                try
                {
                    Class1 c = new Class1
                    {
                        Id = (txt_number.Text),
                        inventoryNumber = (txt_in.Text),
                        ObjectName = txt_on.Text,
                        count = (txt_cnt.Text),
                        price = double.Parse(txt_pr.Text),



                    };


                    c.save();

                    dgvAdd.DataSource = null;
                    dgvAdd.DataSource = Class1.getAllProducts();
                }
                catch (Exception)
                {
                    MessageBox.Show("Type mismatch");
                };
            }
        }

            private void dgvAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }




            private void button3_Click(object sender, EventArgs e)
            {

                System.Environment.Exit(0);
            }
        }
    } 
    




