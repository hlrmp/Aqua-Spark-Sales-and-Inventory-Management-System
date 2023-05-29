namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class log_in_window
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
            label2 = new Label();
            textBox1_username = new TextBox();
            textBox2_password = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 118);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 2;
            label1.Text = "user name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 173);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 3;
            label2.Text = "password";
            // 
            // textBox1_username
            // 
            textBox1_username.Location = new Point(187, 114);
            textBox1_username.Name = "textBox1_username";
            textBox1_username.Size = new Size(206, 23);
            textBox1_username.TabIndex = 4;
            // 
            // textBox2_password
            // 
            textBox2_password.Location = new Point(187, 173);
            textBox2_password.Name = "textBox2_password";
            textBox2_password.Size = new Size(206, 23);
            textBox2_password.TabIndex = 5;
            textBox2_password.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(187, 202);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(54, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "show";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(235, 295);
            button1.Name = "button1";
            button1.Size = new Size(116, 37);
            button1.TabIndex = 8;
            button1.Text = "log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(702, -1);
            button2.Name = "button2";
            button2.Size = new Size(39, 30);
            button2.TabIndex = 9;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.Cpture;
            pictureBox1.Location = new Point(466, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 218);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // log_in_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(738, 405);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2_password);
            Controls.Add(textBox1_username);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(100, 100);
            Name = "log_in_window";
            Text = "log_in_window";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1_username;
        private TextBox textBox2_password;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}