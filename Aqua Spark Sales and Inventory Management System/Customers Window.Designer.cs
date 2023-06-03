namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class Customers_Window
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
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView_customers = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_customers).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(65, 71);
            button1.Name = "button1";
            button1.Size = new Size(127, 60);
            button1.TabIndex = 25;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(233, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(439, 42);
            label1.TabIndex = 28;
            label1.Text = "aqua spark customers\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(499, 71);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(742, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // dataGridView_customers
            // 
            dataGridView_customers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_customers.BackgroundColor = SystemColors.ControlLight;
            dataGridView_customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_customers.Location = new Point(244, 144);
            dataGridView_customers.Name = "dataGridView_customers";
            dataGridView_customers.RowTemplate.Height = 25;
            dataGridView_customers.Size = new Size(409, 232);
            dataGridView_customers.TabIndex = 26;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(65, 189);
            button2.Name = "button2";
            button2.Size = new Size(127, 60);
            button2.TabIndex = 34;
            button2.Text = "add customer";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(65, 316);
            button3.Name = "button3";
            button3.Size = new Size(127, 60);
            button3.TabIndex = 35;
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(499, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 23);
            comboBox1.TabIndex = 36;
            comboBox1.Text = "sort by ";
            // 
            // Customers_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._int;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView_customers);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers_Window";
            Text = "Customers_Window";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_customers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView_customers;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
    }
}