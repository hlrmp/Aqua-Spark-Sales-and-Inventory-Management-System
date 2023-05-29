namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class Orders_Window
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
            dataGridView_order = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(46, 74);
            button1.Name = "button1";
            button1.Size = new Size(127, 60);
            button1.TabIndex = 24;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView_order
            // 
            dataGridView_order.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_order.BackgroundColor = SystemColors.ControlLight;
            dataGridView_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_order.Location = new Point(244, 113);
            dataGridView_order.Name = "dataGridView_order";
            dataGridView_order.RowTemplate.Height = 25;
            dataGridView_order.Size = new Size(518, 285);
            dataGridView_order.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(49, 23);
            comboBox1.TabIndex = 26;
            comboBox1.Text = "DAY";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(67, 174);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(65, 23);
            comboBox2.TabIndex = 27;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Left;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(138, 174);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(73, 23);
            comboBox3.TabIndex = 28;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(374, 42);
            label1.TabIndex = 30;
            label1.Text = "aqua spark orders";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(557, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 33);
            textBox1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(728, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // Orders_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._int;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView_order);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Orders_Window";
            Text = "Orders_Window";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView_order).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView_order;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}