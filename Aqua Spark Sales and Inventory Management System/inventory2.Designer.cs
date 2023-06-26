namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class inventory2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            dataGridView_sales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(242, 222, 186);
            label1.Location = new Point(-10, -2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1269, 57);
            label1.TabIndex = 32;
            label1.Text = "                   AQUA SPARK INVENTORY REPORT                     \r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1006, 99);
            button1.Name = "button1";
            button1.Size = new Size(206, 80);
            button1.TabIndex = 37;
            button1.Text = "home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.BackColor = Color.CadetBlue;
            pictureBox2.Location = new Point(1006, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 657);
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(1006, 260);
            button3.Name = "button3";
            button3.Size = new Size(206, 80);
            button3.TabIndex = 47;
            button3.Text = "products ";
            button3.UseMnemonic = false;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Right;
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(1006, 417);
            button4.Name = "button4";
            button4.Size = new Size(206, 80);
            button4.TabIndex = 48;
            button4.Text = "TOTAL";
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.BackColor = Color.CadetBlue;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(732, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 29);
            comboBox1.TabIndex = 49;
            comboBox1.Text = "           SORT BY";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView_sales
            // 
            dataGridView_sales.AllowUserToAddRows = false;
            dataGridView_sales.AllowUserToDeleteRows = false;
            dataGridView_sales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_sales.BackgroundColor = Color.FromArgb(194, 222, 220);
            dataGridView_sales.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_sales.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_sales.GridColor = Color.FromArgb(192, 192, 255);
            dataGridView_sales.Location = new Point(36, 153);
            dataGridView_sales.Name = "dataGridView_sales";
            dataGridView_sales.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_sales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_sales.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridView_sales.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_sales.RowTemplate.Height = 25;
            dataGridView_sales.Size = new Size(938, 454);
            dataGridView_sales.TabIndex = 50;
            // 
            // inventory2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1212, 646);
            Controls.Add(dataGridView_sales);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "inventory2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sales2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_sales;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
    }
}