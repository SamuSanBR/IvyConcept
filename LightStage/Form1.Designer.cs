namespace LightStage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(869, 575);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // camera1
            // 
            this.camera1.Location = new System.Drawing.Point(291, 8);
            this.camera1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.camera1.Name = "camera1";
            this.camera1.Size = new System.Drawing.Size(50, 27);
            this.camera1.TabIndex = 3;
            this.camera1.Text = "1";
            this.camera1.UseVisualStyleBackColor = true;
            this.camera1.Click += new System.EventHandler(this.camera1_Click);
            // 
            // camera2
            // 
            this.camera2.Location = new System.Drawing.Point(345, 8);
            this.camera2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.camera2.Name = "camera2";
            this.camera2.Size = new System.Drawing.Size(50, 27);
            this.camera2.TabIndex = 4;
            this.camera2.Text = "2";
            this.camera2.UseVisualStyleBackColor = true;
            this.camera2.Visible = false;
            this.camera2.Click += new System.EventHandler(this.camera2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Capture All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(16, 28);
            this.serialTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(145, 20);
            this.serialTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reference Number :";
            // 
            // camera3
            // 
            this.camera3.Location = new System.Drawing.Point(399, 8);
            this.camera3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.camera3.Name = "camera3";
            this.camera3.Size = new System.Drawing.Size(50, 27);
            this.camera3.TabIndex = 8;
            this.camera3.Text = "3";
            this.camera3.UseVisualStyleBackColor = true;
            this.camera3.Visible = false;
            this.camera3.Click += new System.EventHandler(this.camera3_Click);
            // 
            // camera5
            // 
            this.camera5.Location = new System.Drawing.Point(507, 8);
            this.camera5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.camera5.Name = "camera5";
            this.camera5.Size = new System.Drawing.Size(50, 27);
            this.camera5.TabIndex = 10;
            this.camera5.Text = "5";
            this.camera5.UseVisualStyleBackColor = true;
            this.camera5.Visible = false;
            this.camera5.Click += new System.EventHandler(this.camera5_Click);
            // 
            // camera4
            // 
            this.camera4.Location = new System.Drawing.Point(453, 8);
            this.camera4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.camera4.Name = "camera4";
            this.camera4.Size = new System.Drawing.Size(50, 27);
            this.camera4.TabIndex = 9;
            this.camera4.Text = "4";
            this.camera4.UseVisualStyleBackColor = true;
            this.camera4.Visible = false;
            this.camera4.Click += new System.EventHandler(this.camera4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.serialTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 54);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.camera1);
            this.panel2.Controls.Add(this.camera2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.camera5);
            this.panel2.Controls.Add(this.camera3);
            this.panel2.Controls.Add(this.camera4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 538);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 37);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(869, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightStage  1.2";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

