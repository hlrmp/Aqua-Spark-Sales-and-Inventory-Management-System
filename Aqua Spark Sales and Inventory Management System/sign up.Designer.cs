namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class sign_up
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
            button4inventory = new Button();
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(242, 222, 186);
            label1.Location = new Point(-262, -1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1518, 57);
            label1.TabIndex = 33;
            label1.Text = "                                     AQUA SPARK  EMPLOYEES                                       ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button4inventory
            // 
            button4inventory.Anchor = AnchorStyles.Left;
            button4inventory.BackColor = Color.Transparent;
            button4inventory.FlatStyle = FlatStyle.Popup;
            button4inventory.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4inventory.Location = new Point(13, 305);
            button4inventory.Margin = new Padding(4, 3, 4, 3);
            button4inventory.Name = "button4inventory";
            button4inventory.Size = new Size(153, 58);
            button4inventory.TabIndex = 43;
            button4inventory.Text = "add employees";
            button4inventory.UseVisualStyleBackColor = false;
            button4inventory.Click += button4inventory_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 74);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(153, 58);
            button1.TabIndex = 44;
            button1.Text = "home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 194);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(153, 58);
            button3.TabIndex = 53;
            button3.Text = "EMPLOYEES";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.CadetBlue;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 498);
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(194, 222, 220);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(228, 80);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(793, 380);
            dataGridView1.TabIndex = 55;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._int;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(162, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(903, 460);
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(13, 424);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(153, 58);
            button4.TabIndex = 58;
            button4.Text = "activity logs";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // sign_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1064, 494);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button4inventory);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "sign_up";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sign_up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button4inventory;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Button button4;
    }
}