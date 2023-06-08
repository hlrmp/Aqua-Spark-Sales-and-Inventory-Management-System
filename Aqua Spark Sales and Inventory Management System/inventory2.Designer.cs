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
            dataGridView_sales = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_sales
            // 
            dataGridView_sales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_sales.BackgroundColor = SystemColors.ControlLight;
            dataGridView_sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_sales.Location = new Point(219, 130);
            dataGridView_sales.Name = "dataGridView_sales";
            dataGridView_sales.RowHeadersWidth = 51;
            dataGridView_sales.RowTemplate.Height = 25;
            dataGridView_sales.Size = new Size(911, 387);
            dataGridView_sales.TabIndex = 31;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 0);
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-34, -2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1221, 71);
            label1.TabIndex = 32;
            label1.Text = "         AQUA SPARK INVENTORY REPORT       \r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 126);
            button1.Name = "button1";
            button1.Size = new Size(175, 41);
            button1.TabIndex = 37;
            button1.Text = "home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.BackColor = Color.CadetBlue;
            pictureBox2.Location = new Point(-10, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 550);
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(12, 282);
            button3.Name = "button3";
            button3.Size = new Size(175, 41);
            button3.TabIndex = 47;
            button3.UseMnemonic = false;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(12, 362);
            button4.Name = "button4";
            button4.Size = new Size(175, 41);
            button4.TabIndex = 48;
            button4.Text = "TOTAL";
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.BackColor = Color.FromArgb(192, 192, 0);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(891, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 36);
            comboBox1.TabIndex = 49;
            comboBox1.Text = "           SORT BY";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(12, 204);
            button2.Name = "button2";
            button2.Size = new Size(175, 41);
            button2.TabIndex = 46;
            button2.Text = "BOTTLES";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            // 
            // inventory2
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1165, 544);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView_sales);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "inventory2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sales2";
            ((System.ComponentModel.ISupportInitialize)dataGridView_sales).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button button2;
    }
}