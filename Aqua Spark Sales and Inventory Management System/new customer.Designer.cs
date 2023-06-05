namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class new_customer
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
            textBoxfname = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxlname = new TextBox();
            LABELAD = new Label();
            textBoxaddress = new TextBox();
            label3 = new Label();
            textBoxcontactno = new TextBox();
            label4 = new Label();
            textBoxemail = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBoxfname
            // 
            textBoxfname.Location = new Point(134, 127);
            textBoxfname.Name = "textBoxfname";
            textBoxfname.Size = new Size(266, 23);
            textBoxfname.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calisto MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(252, 32);
            label6.Name = "label6";
            label6.Size = new Size(320, 22);
            label6.TabIndex = 54;
            label6.Text = "AQUA SPARK NEW CUSTOMERS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 130);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 56;
            label2.Text = "FIRST NAME *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 195);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 57;
            label1.Text = "LAST NAME *";
            // 
            // textBoxlname
            // 
            textBoxlname.Location = new Point(134, 192);
            textBoxlname.Name = "textBoxlname";
            textBoxlname.Size = new Size(266, 23);
            textBoxlname.TabIndex = 58;
            // 
            // LABELAD
            // 
            LABELAD.AutoSize = true;
            LABELAD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LABELAD.Location = new Point(59, 258);
            LABELAD.Name = "LABELAD";
            LABELAD.Size = new Size(69, 15);
            LABELAD.TabIndex = 59;
            LABELAD.Text = "ADDRESS *";
            // 
            // textBoxaddress
            // 
            textBoxaddress.Location = new Point(134, 255);
            textBoxaddress.Name = "textBoxaddress";
            textBoxaddress.Size = new Size(266, 23);
            textBoxaddress.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 320);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 61;
            label3.Text = "CONTACT NUMBER *";
            // 
            // textBoxcontactno
            // 
            textBoxcontactno.Location = new Point(134, 317);
            textBoxcontactno.Name = "textBoxcontactno";
            textBoxcontactno.Size = new Size(264, 23);
            textBoxcontactno.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(84, 384);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 63;
            label4.Text = "EMAIL";
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(132, 381);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(266, 23);
            textBoxemail.TabIndex = 64;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(545, 113);
            button1.Name = "button1";
            button1.Size = new Size(153, 47);
            button1.TabIndex = 65;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(545, 303);
            button2.Name = "button2";
            button2.Size = new Size(153, 47);
            button2.TabIndex = 66;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(545, 209);
            button3.Name = "button3";
            button3.Size = new Size(153, 47);
            button3.TabIndex = 67;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // new_customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 478);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxemail);
            Controls.Add(label4);
            Controls.Add(textBoxcontactno);
            Controls.Add(label3);
            Controls.Add(textBoxaddress);
            Controls.Add(LABELAD);
            Controls.Add(textBoxlname);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(textBoxfname);
            FormBorderStyle = FormBorderStyle.None;
            Name = "new_customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "new_customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxfname;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox textBoxlname;
        private Label LABELAD;
        private TextBox textBoxaddress;
        private Label label3;
        private TextBox textBoxcontactno;
        private Label label4;
        private TextBox textBoxemail;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}