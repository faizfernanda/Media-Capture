﻿namespace WinFormsApp1
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
            comboBoxWebcamlist = new ComboBox();
            buttonstart = new Button();
            buttoncapture = new Button();
            buttonsave = new Button();
            buttonexit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebcamlist
            // 
            comboBoxWebcamlist.FormattingEnabled = true;
            comboBoxWebcamlist.Location = new Point(10, 9);
            comboBoxWebcamlist.Margin = new Padding(3, 2, 3, 2);
            comboBoxWebcamlist.Name = "comboBoxWebcamlist";
            comboBoxWebcamlist.Size = new Size(150, 23);
            comboBoxWebcamlist.TabIndex = 0;
            // 
            // buttonstart
            // 
            buttonstart.Location = new Point(165, 9);
            buttonstart.Margin = new Padding(3, 2, 3, 2);
            buttonstart.Name = "buttonstart";
            buttonstart.Size = new Size(82, 22);
            buttonstart.TabIndex = 1;
            buttonstart.Text = "Start";
            buttonstart.UseVisualStyleBackColor = true;
            buttonstart.Click += buttonstart_Click;
            // 
            // buttoncapture
            // 
            buttoncapture.Location = new Point(253, 9);
            buttoncapture.Margin = new Padding(3, 2, 3, 2);
            buttoncapture.Name = "buttoncapture";
            buttoncapture.Size = new Size(82, 22);
            buttoncapture.TabIndex = 2;
            buttoncapture.Text = "Capture";
            buttoncapture.UseVisualStyleBackColor = true;
            buttoncapture.Click += buttoncapture_Click;
            // 
            // buttonsave
            // 
            buttonsave.Location = new Point(348, 9);
            buttonsave.Margin = new Padding(3, 2, 3, 2);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(82, 22);
            buttonsave.TabIndex = 3;
            buttonsave.Text = "Save Image";
            buttonsave.UseVisualStyleBackColor = true;
            buttonsave.Click += buttonsave_Click;
            // 
            // buttonexit
            // 
            buttonexit.Location = new Point(729, 9);
            buttonexit.Margin = new Padding(3, 2, 3, 2);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(82, 22);
            buttonexit.TabIndex = 4;
            buttonexit.Text = "Exit";
            buttonexit.UseVisualStyleBackColor = true;
            buttonexit.Click += buttonexit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(11, 35);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 341);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 337);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(403, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(394, 337);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 386);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonexit);
            Controls.Add(buttonsave);
            Controls.Add(buttoncapture);
            Controls.Add(buttonstart);
            Controls.Add(comboBoxWebcamlist);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxWebcamlist;
        private Button buttonstart;
        private Button buttoncapture;
        private Button buttonsave;
        private Button buttonexit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}