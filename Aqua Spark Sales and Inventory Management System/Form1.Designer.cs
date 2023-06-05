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
            label1 = new Label();
            button2exit = new Button();
            SuspendLayout();
            // 
            // button1log
            // 
            button1log.Anchor = AnchorStyles.Bottom;
            button1log.BackColor = Color.FromArgb(128, 255, 128);
            button1log.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1log.Location = new Point(169, 251);
            button1log.Name = "button1log";
            button1log.Size = new Size(172, 70);
            button1log.TabIndex = 0;
            button1log.Text = "LOG IN";
            button1log.UseVisualStyleBackColor = false;
            button1log.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(858, 114);
            label1.TabIndex = 2;
            label1.Text = "aqua spark sales and inventory \r\nmanagement system";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2exit
            // 
            button2exit.Anchor = AnchorStyles.Bottom;
            button2exit.BackColor = Color.FromArgb(255, 128, 128);
            button2exit.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2exit.Location = new Point(501, 251);
            button2exit.Name = "button2exit";
            button2exit.Size = new Size(172, 70);
            button2exit.TabIndex = 3;
            button2exit.Text = "exit";
            button2exit.UseVisualStyleBackColor = false;
            button2exit.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(873, 422);
            Controls.Add(button2exit);
            Controls.Add(label1);
            Controls.Add(button1log);
            DoubleBuffered = true;
            Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1log;
        private Button button2exit;
    }
}