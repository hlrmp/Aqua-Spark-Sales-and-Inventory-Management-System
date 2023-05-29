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
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(128, 128, 255);
            button5.Location = new Point(59, 95);
            button5.Name = "button5";
            button5.Size = new Size(89, 56);
            button5.TabIndex = 18;
            button5.Text = "items";
            button5.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(213, 67);
            listBox1.MaximumSize = new Size(10000, 10000);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(381, 334);
            listBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Location = new Point(661, 66);
            button1.Name = "button1";
            button1.Size = new Size(127, 34);
            button1.TabIndex = 22;
            button1.Text = "orders";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(255, 192, 128);
            button4.Location = new Point(661, 141);
            button4.Name = "button4";
            button4.Size = new Size(127, 34);
            button4.TabIndex = 23;
            button4.Text = "inventory";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Location = new Point(661, 221);
            button2.Name = "button2";
            button2.Size = new Size(127, 34);
            button2.TabIndex = 24;
            button2.Text = "sales info";
            button2.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button8.BackColor = Color.Red;
            button8.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(661, 367);
            button8.Name = "button8";
            button8.Size = new Size(127, 34);
            button8.TabIndex = 26;
            button8.Text = "log out";
            button8.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Location = new Point(661, 298);
            button3.Name = "button3";
            button3.Size = new Size(127, 34);
            button3.TabIndex = 25;
            button3.Text = "Customers";
            button3.UseVisualStyleBackColor = false;
            // 
            // main_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._int;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(button5);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "main_window";
            Text = "main_window";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private ListBox listBox1;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button8;
        private Button button3;
    }
}