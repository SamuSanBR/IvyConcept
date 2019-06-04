﻿namespace LightStage
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.camera1 = new System.Windows.Forms.Button();
            this.camera2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.camera3 = new System.Windows.Forms.Button();
            this.camera5 = new System.Windows.Forms.Button();
            this.camera4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageBox1.Location = new System.Drawing.Point(11, 92);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1280, 720);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // camera1
            // 
            this.camera1.Location = new System.Drawing.Point(454, 831);
            this.camera1.Name = "camera1";
            this.camera1.Size = new System.Drawing.Size(75, 42);
            this.camera1.TabIndex = 3;
            this.camera1.Text = "1";
            this.camera1.UseVisualStyleBackColor = true;
            this.camera1.Click += new System.EventHandler(this.camera1_Click);
            // 
            // camera2
            // 
            this.camera2.Location = new System.Drawing.Point(535, 831);
            this.camera2.Name = "camera2";
            this.camera2.Size = new System.Drawing.Size(75, 42);
            this.camera2.TabIndex = 4;
            this.camera2.Text = "2";
            this.camera2.UseVisualStyleBackColor = true;
            this.camera2.Click += new System.EventHandler(this.camera2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1156, 831);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Capture All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(25, 52);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(215, 26);
            this.serialTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Serial Number :";
            // 
            // camera3
            // 
            this.camera3.Location = new System.Drawing.Point(616, 831);
            this.camera3.Name = "camera3";
            this.camera3.Size = new System.Drawing.Size(75, 42);
            this.camera3.TabIndex = 8;
            this.camera3.Text = "3";
            this.camera3.UseVisualStyleBackColor = true;
            this.camera3.Click += new System.EventHandler(this.camera3_Click);
            // 
            // camera5
            // 
            this.camera5.Location = new System.Drawing.Point(778, 831);
            this.camera5.Name = "camera5";
            this.camera5.Size = new System.Drawing.Size(75, 42);
            this.camera5.TabIndex = 10;
            this.camera5.Text = "5";
            this.camera5.UseVisualStyleBackColor = true;
            this.camera5.Click += new System.EventHandler(this.camera5_Click);
            // 
            // camera4
            // 
            this.camera4.Location = new System.Drawing.Point(697, 831);
            this.camera4.Name = "camera4";
            this.camera4.Size = new System.Drawing.Size(75, 42);
            this.camera4.TabIndex = 9;
            this.camera4.Text = "4";
            this.camera4.UseVisualStyleBackColor = true;
            this.camera4.Click += new System.EventHandler(this.camera4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1303, 885);
            this.Controls.Add(this.camera5);
            this.Controls.Add(this.camera4);
            this.Controls.Add(this.camera3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.camera2);
            this.Controls.Add(this.camera1);
            this.Controls.Add(this.imageBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightStage  0.7b";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button camera1;
        private System.Windows.Forms.Button camera2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button camera3;
        private System.Windows.Forms.Button camera5;
        private System.Windows.Forms.Button camera4;
    }
}
