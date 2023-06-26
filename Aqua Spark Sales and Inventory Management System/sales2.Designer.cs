namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class sales2
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
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            label1.ForeColor = Color.BlanchedAlmond;
            label1.Location = new Point(-10, -2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1279, 57);
            label1.TabIndex = 32;
            label1.Text = "                   aqua spark sales information                     ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1009, 126);
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
            pictureBox2.Location = new Point(1009, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 664);
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Right;
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(1009, 269);
            button4.Name = "button4";
            button4.Size = new Size(206, 79);
            button4.TabIndex = 48;
            button4.Text = "total sales";
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(1009, 414);
            button2.Name = "button2";
            button2.Size = new Size(206, 74);
            button2.TabIndex = 49;
            button2.Text = "paid";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(1009, 553);
            button3.Name = "button3";
            button3.Size = new Size(206, 74);
            button3.TabIndex = 50;
            button3.Text = "pending payment";
            button3.UseMnemonic = false;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView_sales
            // 
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
            dataGridView_sales.Location = new Point(42, 126);
            dataGridView_sales.Name = "dataGridView_sales";
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
            dataGridView_sales.Size = new Size(932, 501);
            dataGridView_sales.TabIndex = 51;
            // 
            // sales2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1216, 658);
            Controls.Add(dataGridView_sales);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "sales2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sales2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button4;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView_sales;
    }
}