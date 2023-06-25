
namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class order3
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
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericUpDownquan = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            cbcn = new ComboBox();
            label8 = new Label();
            button8 = new Button();
            button9 = new Button();
            cbi = new ComboBox();
            button3 = new Button();
            comboBox1 = new ComboBox();
            numericUpDown3 = new NumericUpDown();
            label9 = new Label();
            button6 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownquan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(809, 427);
            button1.Name = "button1";
            button1.Size = new Size(108, 39);
            button1.TabIndex = 50;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(554, 427);
            button2.Name = "button2";
            button2.Size = new Size(108, 39);
            button2.TabIndex = 51;
            button2.Text = "PAY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calisto MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(235, 23);
            label6.Name = "label6";
            label6.Size = new Size(394, 22);
            label6.TabIndex = 53;
            label6.Text = "AQUA SPARK OLD CUSTOMERS ORDER\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 69);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 54;
            label1.Text = "ITEM  *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 239);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 55;
            label2.Text = "QUANTITY *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 370);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 56;
            label3.Text = "TOTAL AMOUNT :";
            // 
            // numericUpDownquan
            // 
            numericUpDownquan.Location = new Point(130, 237);
            numericUpDownquan.Name = "numericUpDownquan";
            numericUpDownquan.Size = new Size(80, 23);
            numericUpDownquan.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(171, 370);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 61;
            label4.Text = "PRICE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 219);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 62;
            label5.Text = "PAYMENT *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(448, 68);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 65;
            label7.Text = "ORDERS LIST";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 192, 192);
            button7.Location = new Point(768, 221);
            button7.Name = "button7";
            button7.Size = new Size(73, 37);
            button7.TabIndex = 67;
            button7.Text = "DELETE";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(432, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(330, 300);
            dataGridView1.TabIndex = 68;
            // 
            // cbcn
            // 
            cbcn.FormattingEnabled = true;
            cbcn.Location = new Point(75, 160);
            cbcn.Name = "cbcn";
            cbcn.Size = new Size(330, 23);
            cbcn.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 142);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 70;
            label8.Text = "CUSTOMER NAME *";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(128, 255, 128);
            button8.Location = new Point(66, 427);
            button8.Name = "button8";
            button8.Size = new Size(108, 39);
            button8.TabIndex = 71;
            button8.Text = "ADD";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 192, 192);
            button9.Location = new Point(297, 427);
            button9.Name = "button9";
            button9.Size = new Size(108, 39);
            button9.TabIndex = 72;
            button9.Text = "CLEAR";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // cbi
            // 
            cbi.FormattingEnabled = true;
            cbi.Location = new Point(75, 93);
            cbi.Name = "cbi";
            cbi.Size = new Size(330, 23);
            cbi.TabIndex = 73;
            // 
            // button3
            // 
            button3.Location = new Point(271, 359);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 74;
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(271, 237);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 23);
            comboBox1.TabIndex = 75;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(130, 303);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(80, 23);
            numericUpDown3.TabIndex = 76;
            numericUpDown3.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 307);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 77;
            label9.Text = "PROMO";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(128, 255, 128);
            button6.Location = new Point(844, 223);
            button6.Name = "button6";
            button6.Size = new Size(73, 37);
            button6.TabIndex = 66;
            button6.Text = "UNDO";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 276);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 46);
            textBox1.TabIndex = 78;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(768, 160);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 55);
            textBox2.TabIndex = 79;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 192);
            button4.Location = new Point(768, 291);
            button4.Name = "button4";
            button4.Size = new Size(149, 42);
            button4.TabIndex = 80;
            button4.Text = "existing order";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 192, 192);
            button5.Location = new Point(768, 349);
            button5.Name = "button5";
            button5.Size = new Size(149, 42);
            button5.TabIndex = 81;
            button5.Text = "removed order";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(768, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 23);
            dateTimePicker1.TabIndex = 82;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(768, 69);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 83;
            label10.Text = "delivery date";
            // 
            // order3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(929, 478);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(numericUpDown3);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(cbi);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label8);
            Controls.Add(cbcn);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDownquan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "order3";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)numericUpDownquan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownquan;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button button7;
        private DataGridView dataGridView1;
        private ComboBox cbcn;
        private Label label8;
        private Button button8;
        private Button button9;
        private ComboBox cbi;
        private Button button3;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown3;
        private Label label9;
        private Button button6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private DateTimePicker dateTimePicker1;
        private Label label10;
    }
}