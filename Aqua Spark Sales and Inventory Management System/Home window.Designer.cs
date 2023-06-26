using System.Windows.Forms;

namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class Home_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            button1orders = new Button();
            button4inventory = new Button();
            button2salesinfo = new Button();
            button8logout = new Button();
            button3customers = new Button();
            label1 = new Label();
            button6 = new Button();
            button7 = new Button();
            buttonpay = new Button();
            buttoncncel = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(-2, 449);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(271, 111);
            button5.TabIndex = 18;
            button5.Text = "items";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1orders
            // 
            button1orders.Anchor = AnchorStyles.Left;
            button1orders.BackColor = Color.FromArgb(128, 255, 128);
            button1orders.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1orders.Location = new Point(-2, 621);
            button1orders.Margin = new Padding(4);
            button1orders.Name = "button1orders";
            button1orders.Size = new Size(271, 88);
            button1orders.TabIndex = 22;
            button1orders.Text = "orders";
            button1orders.UseVisualStyleBackColor = false;
            button1orders.Visible = false;
            button1orders.Click += button1orders_Click;
            // 
            // button4inventory
            // 
            button4inventory.Anchor = AnchorStyles.Left;
            button4inventory.BackColor = Color.FromArgb(128, 255, 128);
            button4inventory.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4inventory.Location = new Point(-2, 449);
            button4inventory.Margin = new Padding(4);
            button4inventory.Name = "button4inventory";
            button4inventory.Size = new Size(271, 93);
            button4inventory.TabIndex = 23;
            button4inventory.Text = "inventory";
            button4inventory.UseVisualStyleBackColor = false;
            button4inventory.Visible = false;
            button4inventory.Click += button4inventory_Click;
            // 
            // button2salesinfo
            // 
            button2salesinfo.Anchor = AnchorStyles.Left;
            button2salesinfo.BackColor = Color.FromArgb(128, 255, 128);
            button2salesinfo.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2salesinfo.Location = new Point(-2, 264);
            button2salesinfo.Margin = new Padding(4);
            button2salesinfo.Name = "button2salesinfo";
            button2salesinfo.Size = new Size(271, 96);
            button2salesinfo.TabIndex = 24;
            button2salesinfo.Text = "sales info";
            button2salesinfo.UseVisualStyleBackColor = false;
            button2salesinfo.Visible = false;
            button2salesinfo.Click += button2salesinfo_Click;
            // 
            // button8logout
            // 
            button8logout.Anchor = AnchorStyles.Left;
            button8logout.BackColor = Color.Transparent;
            button8logout.FlatStyle = FlatStyle.Popup;
            button8logout.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8logout.ForeColor = Color.FromArgb(255, 128, 128);
            button8logout.Location = new Point(-11, 621);
            button8logout.Margin = new Padding(4);
            button8logout.Name = "button8logout";
            button8logout.Size = new Size(280, 110);
            button8logout.TabIndex = 26;
            button8logout.Text = "log out";
            button8logout.UseVisualStyleBackColor = false;
            button8logout.Click += button8logout_Click;
            // 
            // button3customers
            // 
            button3customers.Anchor = AnchorStyles.Left;
            button3customers.BackColor = Color.FromArgb(128, 255, 128);
            button3customers.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3customers.Location = new Point(-2, 87);
            button3customers.Margin = new Padding(4);
            button3customers.Name = "button3customers";
            button3customers.Size = new Size(271, 94);
            button3customers.TabIndex = 25;
            button3customers.Text = "Customers";
            button3customers.UseVisualStyleBackColor = false;
            button3customers.Visible = false;
            button3customers.Click += button3customers_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(344, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(876, 114);
            label1.TabIndex = 27;
            label1.Text = "aqua spark sales and inventory\r\n  management system";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left;
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(-2, 264);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(271, 111);
            button6.TabIndex = 28;
            button6.Text = "deliveries";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Left;
            button7.BackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(-2, 87);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(271, 111);
            button7.TabIndex = 29;
            button7.Text = "add order";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // buttonpay
            // 
            buttonpay.Anchor = AnchorStyles.Bottom;
            buttonpay.BackColor = Color.FromArgb(128, 255, 128);
            buttonpay.Location = new Point(804, 736);
            buttonpay.Name = "buttonpay";
            buttonpay.Size = new Size(131, 42);
            buttonpay.TabIndex = 31;
            buttonpay.Text = "pay";
            buttonpay.UseVisualStyleBackColor = false;
            buttonpay.Visible = false;
            // 
            // buttoncncel
            // 
            buttoncncel.Anchor = AnchorStyles.Bottom;
            buttoncncel.BackColor = Color.FromArgb(255, 128, 128);
            buttoncncel.Location = new Point(981, 736);
            buttoncncel.Name = "buttoncncel";
            buttoncncel.Size = new Size(131, 42);
            buttoncncel.TabIndex = 32;
            buttoncncel.Text = "cancel";
            buttoncncel.UseVisualStyleBackColor = false;
            buttoncncel.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = Properties.Resources.mb;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(215, -3);
            button1.Name = "button1";
            button1.Size = new Size(54, 37);
            button1.TabIndex = 39;
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources._113;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(215, -3);
            button2.Name = "button2";
            button2.Size = new Size(54, 37);
            button2.TabIndex = 40;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2minmize_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.BackColor = Color.FromArgb(192, 192, 255);
            pictureBox2.Location = new Point(-2, -99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 831);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(315, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 509);
            panel1.TabIndex = 43;
            panel1.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(192, 192, 255);
            dataGridView1.Location = new Point(318, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(954, 448);
            dataGridView1.TabIndex = 44;
            dataGridView1.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(789, 149);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 47;
            label4.Text = "USER :";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(782, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 41);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(986, 150);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 49;
            label5.Text = "POSITION :";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Location = new Point(853, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 25);
            textBox1.TabIndex = 50;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Right;
            textBox2.Location = new Point(1098, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 25);
            textBox2.TabIndex = 51;
            // 
            // Home_window
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._int;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1341, 733);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(button4inventory);
            Controls.Add(button2salesinfo);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button1orders);
            Controls.Add(button3customers);
            Controls.Add(button8logout);
            Controls.Add(panel1);
            Controls.Add(buttoncncel);
            Controls.Add(buttonpay);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Home_window";
            Text = "z";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button1orders;
        private Button button4inventory;
        private Button button2salesinfo;
        private Button button8logout;
        private Button button3customers;
        private Label label1;
        private Button button6;
        private Button button7;
        private Button buttonpay;
        private Button buttoncncel;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private DataGridView dataGridView1;
        public Label label2;
        public Label label3;
        public Label label4;
        private PictureBox pictureBox1;
        public Label label5;
        public TextBox textBox1;
        public TextBox textBox2;
    }
}