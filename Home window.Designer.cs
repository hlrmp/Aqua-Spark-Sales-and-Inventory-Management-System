﻿using System.Windows.Forms;

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
            button5 = new Button();
            listBox1 = new ListBox();
            button1orders = new Button();
            button4inventory = new Button();
            button2salesinfo = new Button();
            button8logout = new Button();
            button3customers = new Button();
            label1 = new Label();
            button6 = new Button();
            button7 = new Button();
            buttonpay = new Button();
            buttoncncel = new Button();
            button12 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(23, 38);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(229, 85);
            button5.TabIndex = 18;
            button5.Text = "items";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(319, 188);
            listBox1.Margin = new Padding(6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(931, 288);
            listBox1.TabIndex = 21;
            listBox1.Visible = false;
            // 
            // button1orders
            // 
            button1orders.Anchor = AnchorStyles.Left;
            button1orders.BackColor = Color.FromArgb(255, 192, 128);
            button1orders.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1orders.Location = new Point(25, 503);
            button1orders.Margin = new Padding(4);
            button1orders.Name = "button1orders";
            button1orders.Size = new Size(227, 55);
            button1orders.TabIndex = 22;
            button1orders.Text = "orders";
            button1orders.UseVisualStyleBackColor = false;
            button1orders.Visible = false;
            button1orders.Click += button1orders_Click;
            // 
            // button4inventory
            // 
            button4inventory.Anchor = AnchorStyles.Left;
            button4inventory.BackColor = Color.FromArgb(255, 192, 128);
            button4inventory.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4inventory.Location = new Point(25, 68);
            button4inventory.Margin = new Padding(4);
            button4inventory.Name = "button4inventory";
            button4inventory.Size = new Size(229, 55);
            button4inventory.TabIndex = 23;
            button4inventory.Text = "inventory";
            button4inventory.UseVisualStyleBackColor = false;
            button4inventory.Visible = false;
            button4inventory.Click += button4inventory_Click;
            // 
            // button2salesinfo
            // 
            button2salesinfo.Anchor = AnchorStyles.Left;
            button2salesinfo.BackColor = Color.FromArgb(255, 192, 128);
            button2salesinfo.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2salesinfo.Location = new Point(25, 334);
            button2salesinfo.Margin = new Padding(4);
            button2salesinfo.Name = "button2salesinfo";
            button2salesinfo.Size = new Size(227, 55);
            button2salesinfo.TabIndex = 24;
            button2salesinfo.Text = "sales info";
            button2salesinfo.UseVisualStyleBackColor = false;
            button2salesinfo.Visible = false;
            button2salesinfo.Click += button2salesinfo_Click;
            // 
            // button8logout
            // 
            button8logout.Anchor = AnchorStyles.Left;
            button8logout.BackColor = Color.Transparent;
            button8logout.FlatStyle = FlatStyle.Popup;
            button8logout.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8logout.ForeColor = Color.FromArgb(255, 128, 128);
            button8logout.Location = new Point(23, 478);
            button8logout.Margin = new Padding(4);
            button8logout.Name = "button8logout";
            button8logout.Size = new Size(229, 80);
            button8logout.TabIndex = 26;
            button8logout.Text = "log out";
            button8logout.UseVisualStyleBackColor = false;
            button8logout.Click += button8logout_Click;
            // 
            // button3customers
            // 
            button3customers.Anchor = AnchorStyles.Left;
            button3customers.BackColor = Color.FromArgb(255, 192, 128);
            button3customers.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3customers.Location = new Point(25, 199);
            button3customers.Margin = new Padding(4);
            button3customers.Name = "button3customers";
            button3customers.Size = new Size(227, 55);
            button3customers.TabIndex = 25;
            button3customers.Text = "Customers";
            button3customers.UseVisualStyleBackColor = false;
            button3customers.Visible = false;
            button3customers.Click += button3customers_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(273, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1053, 142);
            label1.TabIndex = 27;
            label1.Text = "aqua spark sales and inventory\r\n  management system";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left;
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(25, 174);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(229, 80);
            button6.TabIndex = 28;
            button6.Text = "sell";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Left;
            button7.BackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(25, 309);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(229, 80);
            button7.TabIndex = 29;
            button7.Text = "add order";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // buttonpay
            // 
            buttonpay.Anchor = AnchorStyles.Bottom;
            buttonpay.BackColor = Color.FromArgb(128, 255, 128);
            buttonpay.Location = new Point(805, 516);
            buttonpay.Name = "buttonpay";
            buttonpay.Size = new Size(131, 42);
            buttonpay.TabIndex = 31;
            buttonpay.Text = "pay";
            buttonpay.UseVisualStyleBackColor = false;
            buttonpay.Visible = false;
            // 
            // buttoncncel
            // 
            buttoncncel.Anchor = AnchorStyles.Bottom;
            buttoncncel.BackColor = Color.FromArgb(255, 128, 128);
            buttoncncel.Location = new Point(983, 516);
            buttoncncel.Name = "buttoncncel";
            buttoncncel.Size = new Size(131, 42);
            buttoncncel.TabIndex = 32;
            buttoncncel.Text = "cancel";
            buttoncncel.UseVisualStyleBackColor = false;
            buttoncncel.Visible = false;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button12.BackColor = Color.FromArgb(255, 128, 128);
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(1210, 188);
            button12.Name = "button12";
            button12.Size = new Size(40, 38);
            button12.TabIndex = 37;
            button12.Text = "X";
            button12.UseVisualStyleBackColor = false;
            button12.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 584);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = Properties.Resources.mb;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(215, -3);
            button1.Name = "button1";
            button1.Size = new Size(54, 37);
            button1.TabIndex = 39;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = Properties.Resources._113;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(215, -3);
            button2.Name = "button2";
            button2.Size = new Size(54, 37);
            button2.TabIndex = 40;
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2minmize_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.BackColor = Color.CadetBlue;
            pictureBox2.Location = new Point(-2, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 584);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = SystemColors.ActiveBorder;
            pictureBox3.BackgroundImage = Properties.Resources._int;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(261, -3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1087, 584);
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // Home_window
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._int;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1348, 581);
            Controls.Add(button1orders);
            Controls.Add(button2salesinfo);
            Controls.Add(button3customers);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button12);
            Controls.Add(buttoncncel);
            Controls.Add(buttonpay);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button8logout);
            Controls.Add(button4inventory);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            DoubleBuffered = true;
            Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Home_window";
            Text = "z";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private ListBox listBox1;
        private Button button1orders;
        private Button button4inventory;
        private Button button2salesinfo;
        private Button button8logout;
        private Button button3customers;
        private Label label1;
        private Button button6;
        private Button button7;
        private Button buttonpay;
        private Button buttoncncel;
        private Button button12;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}