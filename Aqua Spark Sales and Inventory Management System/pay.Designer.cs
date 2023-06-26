
namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class pay
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            cbcn = new ComboBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(504, 427);
            button1.Name = "button1";
            button1.Size = new Size(108, 39);
            button1.TabIndex = 50;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(285, 427);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(102, 191);
            label2.Name = "label2";
            label2.Size = new Size(244, 25);
            label2.TabIndex = 55;
            label2.Text = "QUANTITY      *         PRICE\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 305);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 56;
            label3.Text = "TOTAL AMOUNT :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(222, 293);
            label4.Name = "label4";
            label4.Size = new Size(71, 30);
            label4.TabIndex = 61;
            label4.Text = "PRICE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 361);
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
            label7.Location = new Point(478, 66);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 65;
            label7.Text = "ORDERS LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(478, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(330, 269);
            dataGridView1.TabIndex = 68;
            // 
            // cbcn
            // 
            cbcn.FormattingEnabled = true;
            cbcn.Location = new Point(76, 143);
            cbcn.Name = "cbcn";
            cbcn.Size = new Size(330, 23);
            cbcn.TabIndex = 69;
            cbcn.SelectedIndexChanged += cbcn_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 113);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 70;
            label8.Text = "CUSTOMER NAME *";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 342);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 34);
            textBox1.TabIndex = 78;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(139, 227);
            label9.Name = "label9";
            label9.Size = new Size(71, 30);
            label9.TabIndex = 79;
            label9.Text = "PRICE";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.BackColor = Color.CadetBlue;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(569, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(239, 29);
            comboBox2.TabIndex = 80;
            comboBox2.Text = "           SORT BY";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(285, 227);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 81;
            label1.Text = "PRICE";
            // 
            // pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(842, 478);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(cbcn);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "pay";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private DataGridView dataGridView1;
        private ComboBox cbcn;
        private Label label8;
        private Button button3;
        private TextBox textBox1;
        private Label label9;
        private ComboBox comboBox2;
        private Label label1;
    }
}