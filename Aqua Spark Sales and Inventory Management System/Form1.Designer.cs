namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1log = new Button();
            button2exit = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1log
            // 
            button1log.Anchor = AnchorStyles.Bottom;
            button1log.BackColor = Color.FromArgb(128, 255, 128);
            button1log.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            button1log.FlatAppearance.BorderSize = 5;
            button1log.FlatStyle = FlatStyle.Flat;
            button1log.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1log.Location = new Point(251, 21);
            button1log.Name = "button1log";
            button1log.Size = new Size(172, 70);
            button1log.TabIndex = 0;
            button1log.Text = "LOG IN";
            button1log.UseVisualStyleBackColor = true;
            button1log.Click += button1_Click;
            // 
            // button2exit
            // 
            button2exit.Anchor = AnchorStyles.Bottom;
            button2exit.BackColor = Color.FromArgb(255, 128, 128);
            button2exit.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            button2exit.FlatAppearance.BorderSize = 5;
            button2exit.FlatStyle = FlatStyle.Flat;
            button2exit.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2exit.Location = new Point(605, 21);
            button2exit.Name = "button2exit";
            button2exit.Size = new Size(172, 70);
            button2exit.TabIndex = 3;
            button2exit.Text = "exit";
            button2exit.TextImageRelation = TextImageRelation.TextAboveImage;
            button2exit.UseVisualStyleBackColor = true;
            button2exit.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(11, 79, 108);
            panel1.Controls.Add(button1log);
            panel1.Controls.Add(button2exit);
            panel1.Location = new Point(1, 399);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 122);
            panel1.TabIndex = 4;
          
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(11, 79, 108);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1044, 131);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(11, 79, 108);
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(251, 251, 255);
            label1.Location = new Point(53, 0);
            label1.Name = "label1";
            label1.Size = new Size(1068, 142);
            label1.TabIndex = 2;
            label1.Text = "aqua spark sales and inventory \r\nmanagement system";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1044, 520);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1log;
        private Button button2exit;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}