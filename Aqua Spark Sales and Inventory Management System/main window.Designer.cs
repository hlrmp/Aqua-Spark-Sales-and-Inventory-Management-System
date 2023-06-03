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
            button5 = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button8 = new Button();
            button3 = new Button();
            label1 = new Label();
            button6 = new Button();
            button7 = new Button();
            buttonpay = new Button();
            buttoncncel = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.BackColor = Color.FromArgb(192, 192, 255);
            button5.Location = new Point(36, 93);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(114, 67);
            button5.TabIndex = 18;
            button5.Text = "items";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(212, 151);
            listBox1.Margin = new Padding(6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(602, 326);
            listBox1.TabIndex = 21;
            listBox1.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Location = new Point(853, 88);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(163, 72);
            button1.TabIndex = 22;
            button1.Text = "orders";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(255, 192, 128);
            button4.Location = new Point(853, 197);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(163, 72);
            button4.TabIndex = 23;
            button4.Text = "inventory";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Location = new Point(853, 310);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(163, 72);
            button2.TabIndex = 24;
            button2.Text = "sales info";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Right;
            button8.BackColor = Color.FromArgb(0, 192, 192);
            button8.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(853, 543);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(163, 70);
            button8.TabIndex = 26;
            button8.Text = "log out";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Location = new Point(853, 424);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(163, 72);
            button3.TabIndex = 25;
            button3.Text = "Customers";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(-22, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1059, 114);
            label1.TabIndex = 27;
            label1.Text = "     aqua spark \r\nsales and inventory management system";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left;
            button6.BackColor = Color.FromArgb(192, 192, 255);
            button6.Location = new Point(36, 202);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(114, 67);
            button6.TabIndex = 28;
            button6.Text = "sell";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Left;
            button7.BackColor = Color.FromArgb(192, 192, 255);
            button7.Location = new Point(36, 315);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(114, 67);
            button7.TabIndex = 29;
            button7.Text = "add order";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // buttonpay
            // 
            buttonpay.Anchor = AnchorStyles.Bottom;
            buttonpay.BackColor = Color.FromArgb(128, 255, 128);
            buttonpay.Location = new Point(460, 486);
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
            buttoncncel.Location = new Point(622, 487);
            buttoncncel.Name = "buttoncncel";
            buttoncncel.Size = new Size(131, 42);
            buttoncncel.TabIndex = 32;
            buttoncncel.Text = "cancel";
            buttoncncel.UseVisualStyleBackColor = false;
            buttoncncel.Visible = false;
            // 
            // main_window
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._int;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 581);
            Controls.Add(buttoncncel);
            Controls.Add(buttonpay);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(button5);
            DoubleBuffered = true;
            Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "main_window";
            Text = "main_window";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private ListBox listBox1;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button8;
        private Button button3;
        private Label label1;
        private Button button6;
        private Button button7;
        private Button buttonpay;
        private Button buttoncncel;
    }
}