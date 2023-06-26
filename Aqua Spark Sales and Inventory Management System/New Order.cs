using System.Collections;
using Microsoft.Data.SqlClient;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    public partial class New_Order : Form
    {
        public New_Order()
        {
            InitializeComponent();

            see();

            paymentterms();

        }
        connection_class cc = new connection_class();





        private int orderid;
        private int ordertransaactionid;
        private int discountid;
        private int customerid;
        private int pid;
        private string status;
        private double payment;
        private double price;
        private double total_price;
        private int quantity;
        private string customer_address;
        private string customer_number;
        private string customer_email;
        private string fname;
        private string lname;
        private int pay;

        public New_Order(string ln, string fn, string add, string cnum, string em, int pay)
        {
            this.lname = ln;
            this.fname = fn;
            this.customer_address = add;
            this.customer_number = cnum;
            this.customer_email = em;
            this.quantity = 0;
            this.total_price = 0.0;
            this.pay = pay;
        }
        public string firstname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string lastname
        {
            get { return lname; }
            set { lname = value; }
        }
        public string address
        {
            get { return customer_address; }
            set { customer_address = value; }
        }
        public string number
        {
            get { return customer_number; }
            set { customer_number = value; }
        }
        public string email
        {
            get { return customer_email; }
            set { customer_email = value; }
        }
        public int quanti
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int paym
        {
            get { return pay; }
            set { pay = value; }
        }
        public double totlalamount
        {
            get { return total_price; }
            set { total_price = value; }
        }

        private void button1_Click(object sender, EventArgs e)  // cancel button
        {
            textBox1.Clear();
            textBoxl.Clear();
            textBox3.Clear();

            this.Hide();
        }// cancel button

        private void button3_Click(object sender, EventArgs e) // clear button
        {
            textBox1.Clear();
            textBoxl.Clear();
            textBox3.Clear();
            numericUpDown1.ResetText();
            numericUpDown2.ResetText();


        } // clear button
        int promo;
        string n;
        private void button2_Click(object sender, EventArgs e) // add button
        {

            //add();
         //   inserttransaction();

            fname = textBoxf.Text;
            lname = textBoxl.Text;
            customer_address = textBox3.Text;
            customer_number = textBox1.Text;
            customer_email = textBoxe.Text;


            string day = DateTime.Now.ToString("M/d/yyyy");

            try
            {
                if (button2 != null)
                {
                    inserttransaction();

                }
                else
                {

                }

            }
            catch (Exception)
            {

                MessageBox.Show(" fill up the ff.");

            }


        } // add button



        public void see()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);
            //try
            //{
            string str = "select product_name from products";
            SqlCommand cmd = new SqlCommand(str, sqlc);
            cmd.CommandText = str;
            sqlc.Open();


            SqlDataReader drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                comboBox1.Items.Add(drd["product_name"].ToString());


            }


            sqlc.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Error ", " Error ", MessageBoxButtons.OK);
            //}

            //finally
            //{
            //    sqlc.Close();
            //}
        }


        public void inserttransaction()
        {





            using (SqlConnection cnn = new SqlConnection(cc.conn))
            {

                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    cnn.Open();

                    string day = DateTime.Now.ToString("M/d/yyyy");

                    string quer1 = "  INSERT INTO customer (first_name ,last_name,address,contact_number,email ) VALUES (@first_name ,@last_name,@address,@contact_number,@email)";
                    SqlCommand command = new SqlCommand(quer1, cnn);

                    command.Parameters.AddWithValue("@first_name", textBoxf.Text);
                    command.Parameters.AddWithValue("@last_name", textBoxl.Text);
                    command.Parameters.AddWithValue("@address", textBox3.Text);
                    command.Parameters.AddWithValue("@contact_number", textBox1.Text);
                    command.Parameters.AddWithValue("@email", textBoxe.Text);
                    command.ExecuteNonQuery();


                    SqlConnection sqlc = new SqlConnection(cc.conn);



                    n = comboBox1.Text;

                    quantity = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                    Thread.Sleep(quantity);


                    promo = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));
                    Thread.Sleep(promo);


                    string quer2 = "INSERT INTO orders(product_id, quantity,orderstatus)VALUES (( SELECT product_id FROM products WHERE product_name = '" + n + "' ), @quantity,@status)";
                    SqlCommand command2 = new SqlCommand(quer2, cnn);

                    //   command2.Parameters.AddWithValue("@product_id", drd1.Read());
                    command2.Parameters.AddWithValue("@quantity", quantity);
                    command2.Parameters.AddWithValue("@status", 1);
                    command2.ExecuteNonQuery();


                    //   int promo = Convert.ToInt32(numericUpDown3);

                    log_in_window l = new log_in_window();
                    user_class us = new user_class();


                    string quer3 = "insert into order_transaction (order_id,discount_id ,staff_id,customer_id,status,payment_method,transaction_date) values (( select order_id from orders where order_id = (select max(order_id) from orders)),(select discount_id from discounts where discount_id  = '" + promo + "') ,( SELECT staff_id  FROM users as u INNER JOIN activity_logs AS c ON u.user_id = c.user_id where activity_id = (select max(activity_id) from activity_logs)),(select customer_id from customer where customer_id = (select max(customer_id) from customer)),@status,@payment_method,@transaction_date)";
                    SqlCommand command3 = new SqlCommand(quer3, cnn);

                    //    command3.Parameters.AddWithValue("@order_id", drd1.Read());
                    // command3.Parameters.AddWithValue("@discount_id", promo);
                    //  command3.Parameters.AddWithValue("@staff_id", );
                    // command3.Parameters.AddWithValue("@customer_id", );
                    command3.Parameters.AddWithValue("@status", "2");         // #2 = pending 
                    command3.Parameters.AddWithValue("@payment_method", comboBox2.Text);
                    command3.Parameters.AddWithValue("@transaction_date", day);

                    command3.ExecuteNonQuery();

                    string clickeddate = monthCalendar1.SelectionRange.Start.ToString("M/d/yyyy");

                    string quer5 = "INSERT INTO delivery(order_transacton_id , costumer_id , delivery_status , delivery_date) values((select order_transaction_id from order_transaction where order_transaction_id = (select max(order_transaction_id) from order_transaction)\r\n) ,(select customer_id from order_transaction where order_transaction_id = (select max(order_transaction_id) from order_transaction)), 1, '" + clickeddate + "')";

                    sqlc.Open();

                    SqlCommand command5 = new SqlCommand(quer5, sqlc);

                    command5.ExecuteNonQuery();


                    sqlc.Close();


                    l.addnewsell();

                    sqlc.Close();

                    if (MessageBox.Show(" sucessfully added ", " ", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        textBox1.Clear();
                        textBoxl.Clear();
                        textBox3.Clear();
                        textBoxe.Clear();
                        textBoxf.Clear();
                        textBox2.Clear();
                        numericUpDown1.ResetText();
                        numericUpDown2.ResetText();
                        numericUpDown3.ResetText();


                    }

                }
                else
                {
                    MessageBox.Show(" fill up the ff.");
                }




                cnn.Close();


            }











        }

        public void paymentterms()
        {
            ArrayList clist = new ArrayList();

            clist.Add("pay");
            clist.Add("pending payment");

            foreach (string pos in clist)
            {
                comboBox2.Items.Add(pos);
            }

        }

        private void New_Order_Load(object sender, EventArgs e)
        {

        }
        int count;
        private void button4_Click(object sender, EventArgs e)
        {
            compute();


        }



        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(cc.conn);
            cn.Open();

            string quer3 = "UPDATE order_transaction SET status = 1 WHERE order_transaction_id = (select order_transaction_id from order_transaction where order_transaction_id = (select max(order_transaction_id) from order_transaction) )";

            SqlCommand command = new SqlCommand(quer3, cn);
            command.ExecuteNonQuery();


            cn.Close();



            pay = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            Thread.Sleep(pay);

            //if (comboBox2.Text.Equals("pay"))
            //{
            if (pay >= total_price)
                {
                    double change = pay - total_price;

                    MessageBox.Show(" " + "\n" +
                                    "payment: " + pay + "\n" +
                                    "quantity: " + count + "\n" +
                                    "price: " + price + "\n" +
                                    "total pice: " + total_price + "\n" +
                                    "change: " + change + " " + " \n "
                                    , " payment ", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show(" input the right amount to pay ", " payment ", MessageBoxButtons.OK);
                }

            //}
            //else
            //{
            //    MessageBox.Show(" select pay from payment method to pay ", " payment ", MessageBoxButtons.OK);
            //}



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            compute();

        }

        public void compute()
        {
            SqlConnection sqlc = new SqlConnection(cc.conn);

            string st = " SELECT price FROM products WHERE product_name = '" + comboBox1.Text + "' ";
            SqlCommand cmd1 = new SqlCommand(st, sqlc);
            cmd1.CommandText = st;
            sqlc.Open();
            SqlDataReader drd1 = cmd1.ExecuteReader();
            drd1.Read();

            price = Convert.ToDouble(drd1[0]);

            total_price = price * count;

            sqlc.Close();


            count = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            Thread.Sleep(count);

            textBox2.Text = Convert.ToString(total_price);

        }
    }
}
