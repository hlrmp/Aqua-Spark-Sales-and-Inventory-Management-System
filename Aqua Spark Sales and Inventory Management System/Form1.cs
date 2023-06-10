namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        log_in_window lw = new log_in_window();

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1log != null)
            {
                lw.Show();


            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e) // Exit button
        {
             this.Close();
           // sign_up su = new sign_up();
           // su.Show();

        } // Exit button


    }
}