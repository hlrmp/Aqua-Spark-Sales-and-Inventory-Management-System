namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class main_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_window));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            button12 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2minmize = new Button();
            pictureBox2 = new PictureBox();
            buttonemp = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(21, 110);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(229, 85);
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
            button1orders.Location = new Point(19, 436);
            button1orders.Margin = new Padding(4);
            button1orders.Name = "button1orders";
            button1orders.Size = new Size(229, 84);
            button1orders.TabIndex = 22;
            button1orders.Text = "orders";
            button1orders.UseVisualStyleBackColor = false;
            button1orders.Visible = false;
            button1orders.Click += button1_Click;
            // 
            // button4inventory
            // 
            button4inventory.Anchor = AnchorStyles.Left;
            button4inventory.BackColor = Color.FromArgb(128, 255, 128);
            button4inventory.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4inventory.Location = new Point(21, 0);
            button4inventory.Margin = new Padding(4);
            button4inventory.Name = "button4inventory";
            button4inventory.Size = new Size(229, 77);
            button4inventory.TabIndex = 23;
            button4inventory.Text = "inventory";
            button4inventory.UseVisualStyleBackColor = false;
            button4inventory.Visible = false;
            button4inventory.Click += button4_Click;
            // 
            // button2salesinfo
            // 
            button2salesinfo.Anchor = AnchorStyles.Left;
            button2salesinfo.BackColor = Color.FromArgb(128, 255, 128);
            button2salesinfo.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2salesinfo.Location = new Point(21, 288);
            button2salesinfo.Margin = new Padding(4);
            button2salesinfo.Name = "button2salesinfo";
            button2salesinfo.Size = new Size(231, 77);
            button2salesinfo.TabIndex = 24;
            button2salesinfo.Text = "sales info";
            button2salesinfo.UseVisualStyleBackColor = false;
            button2salesinfo.Visible = false;
            button2salesinfo.Click += button2_Click;
            // 
            // button8logout
            // 
            button8logout.Anchor = AnchorStyles.Left;
            button8logout.BackColor = Color.Transparent;
            button8logout.FlatStyle = FlatStyle.Popup;
            button8logout.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8logout.ForeColor = Color.FromArgb(255, 128, 128);
            button8logout.Location = new Point(21, 623);
            button8logout.Margin = new Padding(4);
            button8logout.Name = "button8logout";
            button8logout.Size = new Size(229, 80);
            button8logout.TabIndex = 26;
            button8logout.Text = "log out";
            button8logout.UseVisualStyleBackColor = false;
            button8logout.Click += button8_Click;
            // 
            // button3customers
            // 
            button3customers.Anchor = AnchorStyles.Left;
            button3customers.BackColor = Color.FromArgb(128, 255, 128);
            button3customers.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3customers.Location = new Point(21, 134);
            button3customers.Margin = new Padding(4);
            button3customers.Name = "button3customers";
            button3customers.Size = new Size(231, 77);
            button3customers.TabIndex = 25;
            button3customers.Text = "Customers";
            button3customers.UseVisualStyleBackColor = false;
            button3customers.Visible = false;
            button3customers.Click += button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(321, -3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(846, 114);
            label1.TabIndex = 27;
            label1.Text = "aqua spark sales and inventory\r\n  management system";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left;
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(21, 285);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(229, 80);
            button6.TabIndex = 28;
            button6.Text = "sell";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Left;
            button7.BackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(19, 463);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(229, 80);
            button7.TabIndex = 29;
            button7.Text = "add order";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // buttonpay
            // 
            buttonpay.Anchor = AnchorStyles.Bottom;
            buttonpay.BackColor = Color.FromArgb(128, 255, 128);
            buttonpay.Location = new Point(810, 737);
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
            buttoncncel.Location = new Point(988, 737);
            buttoncncel.Name = "buttoncncel";
            buttoncncel.Size = new Size(131, 42);
            buttoncncel.TabIndex = 32;
            buttoncncel.Text = "cancel";
            buttoncncel.UseVisualStyleBackColor = false;
            buttoncncel.Visible = false;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button12.BackColor = Color.FromArgb(255, 128, 128);
            button12.Location = new Point(1105, 153);
            button12.Name = "button12";
            button12.Size = new Size(56, 42);
            button12.TabIndex = 37;
            button12.Text = "X";
            button12.UseVisualStyleBackColor = false;
            button12.Visible = false;
            button12.Click += button12_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 805);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(215, -3);
            button1.Name = "button1";
            button1.Size = new Size(54, 37);
            button1.TabIndex = 39;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2minmize
            // 
            button2minmize.BackColor = Color.White;
            button2minmize.BackgroundImage = (Image)resources.GetObject("button2minmize.BackgroundImage");
            button2minmize.BackgroundImageLayout = ImageLayout.Stretch;
            button2minmize.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2minmize.Location = new Point(215, -3);
            button2minmize.Name = "button2minmize";
            button2minmize.Size = new Size(54, 37);
            button2minmize.TabIndex = 40;
            button2minmize.UseVisualStyleBackColor = false;
            button2minmize.Visible = false;
            button2minmize.Click += button2minmize_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 192, 255);
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 733);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // buttonemp
            // 
            buttonemp.Anchor = AnchorStyles.Left;
            buttonemp.BackColor = Color.FromArgb(255, 192, 128);
            buttonemp.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonemp.Location = new Point(25, 753);
            buttonemp.Margin = new Padding(4);
            buttonemp.Name = "buttonemp";
            buttonemp.Size = new Size(227, 70);
            buttonemp.TabIndex = 42;
            buttonemp.Text = "employees";
            buttonemp.UseVisualStyleBackColor = false;
            buttonemp.Visible = false;
            buttonemp.Click += button2_Click_1;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 0, 64);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Navy;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(376, 153);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(785, 494);
            dataGridView1.TabIndex = 44;
            dataGridView1.Visible = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(21, 607);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(227, 84);
            button2.TabIndex = 45;
            button2.Text = "employees";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click_2;
            // 
            // main_window
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._int;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1354, 733);
            Controls.Add(button2);
            Controls.Add(button12);
            Controls.Add(buttonemp);
            Controls.Add(button1);
            Controls.Add(button1orders);
            Controls.Add(button2salesinfo);
            Controls.Add(button3customers);
            Controls.Add(button2minmize);
            Controls.Add(buttoncncel);
            Controls.Add(buttonpay);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button8logout);
            Controls.Add(button4inventory);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "main_window";
            Text = "z";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button12;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2minmize;
        private PictureBox pictureBox2;
        private Button buttonemp;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}