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
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 114);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 2;
            label1.Text = "user name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 173);
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
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(76, 293);
            button1.Name = "button1";
            button1.Size = new Size(148, 39);
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
            button2.Location = new Point(694, -1);
            button2.Name = "button2";
            button2.Size = new Size(47, 35);
            button2.TabIndex = 9;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.Cpture;
            pictureBox1.Location = new Point(460, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 218);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(159, 32);
            label3.Name = "label3";
            label3.Size = new Size(409, 34);
            label3.TabIndex = 11;
            label3.Text = "wellcome have a good day";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(276, 293);
            button3.Name = "button3";
            button3.Size = new Size(148, 39);
            button3.TabIndex = 12;
            button3.Text = "clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // log_in_window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(738, 405);
            Controls.Add(button3);
            Controls.Add(label3);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label3;
        private Button button3;
    }
}