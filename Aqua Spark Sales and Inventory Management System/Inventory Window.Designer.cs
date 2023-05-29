namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class Inventory_Wiindow
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
            dataGridView_inventory = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_inventory).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_inventory
            // 
            dataGridView_inventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_inventory.BackgroundColor = SystemColors.ControlLight;
            dataGridView_inventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_inventory.Location = new Point(227, 80);
            dataGridView_inventory.Name = "dataGridView_inventory";
            dataGridView_inventory.RowTemplate.Height = 25;
            dataGridView_inventory.Size = new Size(547, 337);
            dataGridView_inventory.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(47, 92);
            button1.Name = "button1";
            button1.Size = new Size(127, 60);
            button1.TabIndex = 23;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(47, 196);
            button2.Name = "button2";
            button2.Size = new Size(127, 60);
            button2.TabIndex = 24;
            button2.Text = "edit ";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(227, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(430, 42);
            label1.TabIndex = 28;
            label1.Text = "aqua spark inventory";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(47, 290);
            button3.Name = "button3";
            button3.Size = new Size(127, 60);
            button3.TabIndex = 29;
            button3.Text = "save";
            button3.UseVisualStyleBackColor = false;
            // 
            // Inventory_Wiindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._int;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView_inventory);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory_Wiindow";
            Text = "Inventory_Wiindow";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView_inventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_inventory;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}