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
    public partial class calcu : Form
    {
        public calcu()
        {
            InitializeComponent();
        }

        int input = 0;
        int input1 = 1;
        int input2 = 2;
        int input3 = 3;
        int input4 = 4;
        int input5 = 5;
        int input6 = 6;
        int input7 = 7;
        int input8 = 8;
        int input9 = 9;

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1 != null)
            {

                textBox1.Text += input1;

            }
            else
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2 != null)
            {

                textBox1.Text += input2;

            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3 != null)
            {

                textBox1.Text += input3;

            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4 != null)
            {

                textBox1.Text += input4;

            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5 != null)
            {

                textBox1.Text += input5;

            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6 != null)
            {

                textBox1.Text += input6;

            }
            else
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7 != null)
            {

                textBox1.Text += input7;

            }
            else
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8 != null)
            {

                textBox1.Text += input8;

            }
            else
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9 != null)
            {

                textBox1.Text += input9;

            }
            else
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10 != null)
            {

                textBox1.Text += input;

            }
            else
            {

            }
        }

        private void button11_Click(object sender, EventArgs e) // clear button
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }// clear button

        private void button12_Click(object sender, EventArgs e)// add button
        {
           
        }// add button
    }
}
