namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class reciept
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
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 39);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "ITEM TYPE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 357);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 57;
            label3.Text = "TOTAL AMOUNT :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 322);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 58;
            label2.Text = "QUANTITY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 125);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 59;
            label4.Text = "DISCOUNT ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 287);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 60;
            label5.Text = "PRICE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 157);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 61;
            label6.Text = "CASHIER";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 188);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 62;
            label7.Text = "DELIVERY INFO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(76, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(118, 218);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 64;
            label8.Text = "DATE AND TIME";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(314, 436);
            button1.Name = "button1";
            button1.Size = new Size(33, 23);
            button1.TabIndex = 65;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // reciept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(345, 457);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "reciept";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "reciept";
        
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Button button1;
    }
}