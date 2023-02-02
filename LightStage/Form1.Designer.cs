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
            this.button1 = new System.Windows.Forms.Button();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ligar = new System.Windows.Forms.Button();
            this.Parar = new System.Windows.Forms.Button();
            this.Filmar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageBox1.Enabled = false;
            this.imageBox1.Location = new System.Drawing.Point(6, 151);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1912, 1279);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3262, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(522, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tirar foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(42, 66);
            this.serialTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(380, 38);
            this.serialTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Serial number :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimer);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.userTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.serialTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.MaximumSize = new System.Drawing.Size(3798, 163);
            this.panel1.MinimumSize = new System.Drawing.Size(3798, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3798, 163);
            this.panel1.TabIndex = 11;
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(867, 66);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(187, 38);
            this.txtTimer.TabIndex = 11;
            this.txtTimer.Text = "00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(3652, 52);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 64);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Fechar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(3376, 52);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(264, 64);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Trocar Usuário";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username :";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(442, 66);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ReadOnly = true;
            this.userTextBox.Size = new System.Drawing.Size(380, 38);
            this.userTextBox.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Ligar);
            this.panel2.Controls.Add(this.Parar);
            this.panel2.Controls.Add(this.Filmar);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1436);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel2.MaximumSize = new System.Drawing.Size(3798, 112);
            this.panel2.MinimumSize = new System.Drawing.Size(3798, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3798, 112);
            this.panel2.TabIndex = 12;
            // 
            // Ligar
            // 
            this.Ligar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ligar.Location = new System.Drawing.Point(2120, 6);
            this.Ligar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Ligar.Name = "Ligar";
            this.Ligar.Size = new System.Drawing.Size(368, 64);
            this.Ligar.TabIndex = 10;
            this.Ligar.Text = "Ligar";
            this.Ligar.UseVisualStyleBackColor = true;
            this.Ligar.Click += new System.EventHandler(this.Ligar_Click);
            // 
            // Parar
            // 
            this.Parar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Parar.Enabled = false;
            this.Parar.Location = new System.Drawing.Point(2500, 8);
            this.Parar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(368, 64);
            this.Parar.TabIndex = 9;
            this.Parar.Text = "Desligar";
            this.Parar.UseVisualStyleBackColor = true;
            this.Parar.Click += new System.EventHandler(this.Parar_Click);
            // 
            // Filmar
            // 
            this.Filmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Filmar.Enabled = false;
            this.Filmar.Location = new System.Drawing.Point(2880, 8);
            this.Filmar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Filmar.Name = "Filmar";
            this.Filmar.Size = new System.Drawing.Size(368, 64);
            this.Filmar.TabIndex = 8;
            this.Filmar.Text = "Filmar";
            this.Filmar.UseVisualStyleBackColor = true;
            this.Filmar.Click += new System.EventHandler(this.Filmar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(522, 64);
            this.button2.TabIndex = 6;
            this.button2.Text = "Gerar relatório";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imageBox2.Location = new System.Drawing.Point(1930, 151);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(1866, 1281);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 13;
            this.imageBox2.TabStop = false;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Enabled = false;
            this.videoSourcePlayer.Location = new System.Drawing.Point(6, 161);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(1911, 1268);
            this.videoSourcePlayer.TabIndex = 15;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3798, 1548);
            this.Controls.Add(this.videoSourcePlayer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.imageBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximumSize = new System.Drawing.Size(3834, 1640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(3834, 1640);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Câmera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSair;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button Filmar;
        private System.Windows.Forms.Button Parar;
        private System.Windows.Forms.Button Ligar;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Timer timer;
    }
}

