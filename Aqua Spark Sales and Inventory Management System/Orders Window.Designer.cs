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
            label1 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(12, 133);
            button1.Name = "button1";
            button1.Size = new Size(240, 83);
            button1.TabIndex = 24;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView_order
            // 
            dataGridView_order.AllowUserToAddRows = false;
            dataGridView_order.AllowUserToDeleteRows = false;
            dataGridView_order.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_order.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridView_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_order.GridColor = Color.FromArgb(0, 0, 192);
            dataGridView_order.Location = new Point(296, 120);
            dataGridView_order.Name = "dataGridView_order";
            dataGridView_order.ReadOnly = true;
            dataGridView_order.RowHeadersWidth = 51;
            dataGridView_order.RowTemplate.Height = 25;
            dataGridView_order.Size = new Size(523, 253);
            dataGridView_order.TabIndex = 25;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(321, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(513, 57);
            label1.TabIndex = 30;
            label1.Text = "aqua spark orders";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(12, 266);
            button2.Name = "button2";
            button2.Size = new Size(240, 82);
            button2.TabIndex = 33;
            button2.Text = "Add orders";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.BackColor = Color.CadetBlue;
            pictureBox2.Location = new Point(-2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 459);
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // Orders_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._int;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(862, 457);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView_order);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders_Window";
            Text = "Orders_Window";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView_order).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView_order;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox2;
    }
}