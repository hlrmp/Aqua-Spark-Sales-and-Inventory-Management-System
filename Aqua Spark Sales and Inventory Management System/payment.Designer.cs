namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class payment
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
            numericUpDown1 = new NumericUpDown();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ITEMNAME = new DataGridViewTextBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            label7 = new Label();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(265, 399);
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
            button2.Location = new Point(421, 399);
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
            label6.Location = new Point(271, 31);
            label6.Name = "label6";
            label6.Size = new Size(258, 22);
            label6.TabIndex = 53;
            label6.Text = "AQUA SPARK NEW SALES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 84);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 54;
            label1.Text = "ITEM  *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 218);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 55;
            label2.Text = "QUANTITY *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 308);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 56;
            label3.Text = "TOTAL AMOUNT :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(43, 236);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(134, 23);
            numericUpDown1.TabIndex = 57;
            // 
            // button3
            // 
            button3.Location = new Point(158, 112);
            button3.Name = "button3";
            button3.Size = new Size(98, 81);
            button3.TabIndex = 58;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(43, 112);
            button4.Name = "button4";
            button4.Size = new Size(98, 81);
            button4.TabIndex = 59;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(271, 110);
            button5.Name = "button5";
            button5.Size = new Size(98, 83);
            button5.TabIndex = 60;
            button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(158, 307);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 61;
            label4.Text = "PRICE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 218);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 62;
            label5.Text = "PAYMENT *";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 63;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ITEMNAME, QUANTITY });
            dataGridView1.Location = new Point(421, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(342, 247);
            dataGridView1.TabIndex = 64;
            // 
            // ITEMNAME
            // 
            ITEMNAME.HeaderText = "ITEM NAME";
            ITEMNAME.Name = "ITEMNAME";
            ITEMNAME.ReadOnly = true;
            // 
            // QUANTITY
            // 
            QUANTITY.HeaderText = "QUANTITY";
            QUANTITY.Name = "QUANTITY";
            QUANTITY.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(544, 84);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 65;
            label7.Text = "ITEM  LIST";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(128, 255, 128);
            button6.Location = new Point(583, 307);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 66;
            button6.Text = "EDIT";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 128, 128);
            button7.Location = new Point(678, 308);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 67;
            button7.Text = "DELETE";
            button7.UseVisualStyleBackColor = false;
            // 
            // payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "payment";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private NumericUpDown numericUpDown1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ITEMNAME;
        private DataGridViewTextBoxColumn QUANTITY;
        private Label label7;
        private Button button6;
        private Button button7;
    }
}