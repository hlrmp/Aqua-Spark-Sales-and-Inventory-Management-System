namespace Aqua_Spark_Sales_and_Inventory_Management_System
{
    partial class selection
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
            buttonX = new Button();
            buttonNEW = new Button();
            buttonOLD = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonX
            // 
            buttonX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonX.BackColor = Color.FromArgb(255, 192, 128);
            buttonX.FlatStyle = FlatStyle.Popup;
            buttonX.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonX.ForeColor = SystemColors.ActiveCaptionText;
            buttonX.Location = new Point(235, 0);
            buttonX.Name = "buttonX";
            buttonX.Size = new Size(30, 25);
            buttonX.TabIndex = 54;
            buttonX.Text = "X";
            buttonX.UseMnemonic = false;
            buttonX.UseVisualStyleBackColor = false;
            buttonX.Click += buttonX_Click;
            // 
            // buttonNEW
            // 
            buttonNEW.BackColor = Color.FromArgb(192, 255, 192);
            buttonNEW.FlatStyle = FlatStyle.Popup;
            buttonNEW.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNEW.ForeColor = SystemColors.ActiveCaptionText;
            buttonNEW.Location = new Point(45, 86);
            buttonNEW.Name = "buttonNEW";
            buttonNEW.Size = new Size(175, 38);
            buttonNEW.TabIndex = 55;
            buttonNEW.Text = "NEW CUSTOMER ";
            buttonNEW.UseMnemonic = false;
            buttonNEW.UseVisualStyleBackColor = false;
            buttonNEW.Click += buttonNEW_Click_1;
            // 
            // buttonOLD
            // 
            buttonOLD.BackColor = Color.FromArgb(192, 255, 192);
            buttonOLD.FlatStyle = FlatStyle.Popup;
            buttonOLD.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOLD.ForeColor = SystemColors.ActiveCaptionText;
            buttonOLD.Location = new Point(45, 130);
            buttonOLD.Name = "buttonOLD";
            buttonOLD.Size = new Size(175, 38);
            buttonOLD.TabIndex = 56;
            buttonOLD.Text = "OLD CUSTOMER ";
            buttonOLD.UseMnemonic = false;
            buttonOLD.UseVisualStyleBackColor = false;
            buttonOLD.Click += buttonOLD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 41);
            label1.Name = "label1";
            label1.Size = new Size(232, 25);
            label1.TabIndex = 57;
            label1.Text = "SELECT CUSTOMER TYPE";
            // 
            // selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(264, 194);
            Controls.Add(label1);
            Controls.Add(buttonOLD);
            Controls.Add(buttonNEW);
            Controls.Add(buttonX);
            FormBorderStyle = FormBorderStyle.None;
            Name = "selection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "selection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonX;
        private Button buttonNEW;
        private Button buttonOLD;
        private Label label1;
    }
}