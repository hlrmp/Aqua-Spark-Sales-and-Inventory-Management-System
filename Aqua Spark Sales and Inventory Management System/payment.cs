using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e) // edit button
        {
            // dataGridView1
            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

        }// edit button

        private void button1_Click(object sender, EventArgs e) // cancel button
        {
            textBox1.Clear();
            this.Hide();

        }// cancel button

        private void button2_Click(object sender, EventArgs e)  // PAY BUTTON
        {
            if (button2 != null)
            {
                if (textBox1 != null)
                {

                }



            }

            /* try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    
                    cm = new SqlCommand("INSERT INTO tblProduct(Prodcode, Description, Brand, Category, Quantity, Price) VALUES(@prodcode, @description, @brand, @category, @quantity, @price)", cn);
                    cm.Parameters.AddWithValue("@prodcode", txtProdCode.Text);
                    cm.Parameters.AddWithValue("@description", txtDescription.Text);
                    cm.Parameters.AddWithValue("@brand", cbBrand.Text);
                    cm.Parameters.AddWithValue("@category", cbCategory.Text);
                    cm.Parameters.AddWithValue("@quantity", txtQty.Text);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully saved.");
                    Clear();
                    frmlist1.LoadRecords();
                    this.Dispose();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             */
        } // PAY BUTTON

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4 != null)
            {

            }
            else
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
