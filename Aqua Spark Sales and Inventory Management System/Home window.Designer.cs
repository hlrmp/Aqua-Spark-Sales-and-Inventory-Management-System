namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class Home_window
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
            label1 = new Label();
            button5 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button6 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(-19, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(995, 42);
            label1.TabIndex = 28;
            label1.Text = "aqua spark sales and inventory management system";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 192, 255);
            button5.Location = new Point(70, 124);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(114, 67);
            button5.TabIndex = 29;
            button5.Text = "items";
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(70, 229);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(114, 67);
            button1.TabIndex = 30;
            button1.Text = "list";
            button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(270, 131);
            listBox1.Margin = new Padding(6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(602, 308);
            listBox1.TabIndex = 31;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Location = new Point(935, 29);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(163, 72);
            button2.TabIndex = 32;
            button2.Text = "orders";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(255, 192, 128);
            button4.Location = new Point(935, 131);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(163, 72);
            button4.TabIndex = 33;
            button4.Text = "inventory";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Location = new Point(935, 249);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(163, 72);
            button3.TabIndex = 34;
            button3.Text = "sales info";
            button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(255, 192, 128);
            button6.Location = new Point(935, 367);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(163, 72);
            button6.TabIndex = 35;
            button6.Text = "Customers";
            button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Right;
            button8.BackColor = Color.FromArgb(0, 192, 192);
            button8.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(935, 487);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(163, 70);
            button8.TabIndex = 36;
            button8.Text = "log out";
            button8.UseVisualStyleBackColor = false;
            // 
            // Home_window
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._int;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 570);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(label1);
            Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Home_window";
            Text = "Home_window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button5;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button8;
    }
}