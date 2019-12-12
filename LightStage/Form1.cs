// LightStage
//
// Capture multple angle pictures automatically
// and save them to a shared folder
// Requires computer with multiple USB controllers due to bandwidth requirements
//
// Mark Bowling
// May 2019

using System;
using System.Windows.Forms;
using System.Configuration;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.IO;

namespace LightStage
{
    public partial class Form1 : Form
    {
        int activeCamera = 1;
        VideoCapture capture0 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera1"]), VideoCapture.API.DShow);
        VideoCapture capture1 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera2"]), VideoCapture.API.DShow);
        VideoCapture capture2 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera3"]), VideoCapture.API.DShow);
        VideoCapture capture3 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera4"]), VideoCapture.API.DShow);
        VideoCapture capture4 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera5"]), VideoCapture.API.DShow);

        public Form1()
        {
            InitializeComponent();

            if (ConfigurationManager.AppSettings["CaptureOnScan"].ToUpper() == "TRUE") { this.AcceptButton = button1; }

            resetBackColor();
            camera1.BackColor = Color.LawnGreen;

            //camera settings
            capture0.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera1X"]));
            capture0.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera1Y"]));
            capture1.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera2X"])); 
            capture1.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera2Y"]));
            capture2.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera3X"]));
            capture2.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera3Y"]));
            capture3.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera4X"]));
            capture3.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera4Y"]));
            capture4.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera5X"]));
            capture4.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera5Y"]));

            Application.Idle += new EventHandler(delegate (object sender, EventArgs e)
            {
                Mat img = null;
                if (activeCamera == 1) { img = capture0.QueryFrame(); }
                if (activeCamera == 2) { img = capture1.QueryFrame(); }
                if (activeCamera == 3) { img = capture2.QueryFrame(); }
                if (activeCamera == 4) { img = capture3.QueryFrame(); }
                if (activeCamera == 5) { img = capture4.QueryFrame(); }
            
                if (imageBox1.Image != null) { imageBox1.Image.Dispose(); }

                imageBox1.Image = img;
            });
            
        }

        private void camera1_Click(object sender, EventArgs e)
        {
            activeCamera = 1;
            resetBackColor();
            camera1.BackColor = Color.LawnGreen;
        }

        private void camera2_Click(object sender, EventArgs e)
        {
            activeCamera = 2;
            resetBackColor();
            camera2.BackColor = Color.LawnGreen;
        }

        private void camera3_Click(object sender, EventArgs e)
        {
            activeCamera = 3;
            resetBackColor();
            camera3.BackColor = Color.LawnGreen;
        }

        private void camera4_Click(object sender, EventArgs e)
        {
            activeCamera = 4;
            resetBackColor();
            camera4.BackColor = Color.LawnGreen;
        }

        private void camera5_Click(object sender, EventArgs e)
        {
            activeCamera = 5;
            resetBackColor();
            camera5.BackColor = Color.LawnGreen;
        }

        private void resetBackColor()        
        {
            foreach (Control button in Controls)
            {
                if (button is Button) { ((Button)button).BackColor = Color.LightGray; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo pictureDirectory = new DirectoryInfo(ConfigurationManager.AppSettings["SavePath"]);

            if (serialTextBox.Text.Length >= 1)
            {
                try
                {
                    if (Directory.Exists(pictureDirectory + serialTextBox.Text))
                    {
                        Directory.Delete(pictureDirectory + serialTextBox.Text, true);
                    }

                    Directory.CreateDirectory(pictureDirectory + serialTextBox.Text);
                }
                catch (Exception exception) { MessageBox.Show("Error Creating Directory\n" + exception.ToString(), "I/O Error"); }

                
                Mat img = null;
                try
                {
                    img = capture0.QueryFrame();
                    img.Save(pictureDirectory + serialTextBox.Text + "\\" + serialTextBox.Text + ConfigurationManager.AppSettings["AppendCam1"] + ".jpg");
                    try { img.Dispose(); } catch { }
                }
                catch { }

                try
                {
                    img = capture1.QueryFrame();
                    img.Save(pictureDirectory + serialTextBox.Text + "\\" + serialTextBox.Text + ConfigurationManager.AppSettings["AppendCam2"] + ".jpg");
                    try { img.Dispose(); } catch { }
                }
                catch { }

                try
                {
                    img = capture2.QueryFrame();
                    img.Save(pictureDirectory + serialTextBox.Text + "\\" + serialTextBox.Text + ConfigurationManager.AppSettings["AppendCam3"] + ".jpg");
                    try { img.Dispose(); } catch { }
                }
                catch { }

                try
                {
                    img = capture3.QueryFrame();
                    img.Save(pictureDirectory + serialTextBox.Text + "\\" + serialTextBox.Text + ConfigurationManager.AppSettings["AppendCam4"] + ".jpg");
                    try { img.Dispose(); } catch { }
                }
                catch { }

                try
                {
                    img = capture4.QueryFrame();
                    img.Save(pictureDirectory + serialTextBox.Text + "\\" + serialTextBox.Text + ConfigurationManager.AppSettings["AppendCam5"] + ".jpg");
                    try { img.Dispose(); } catch { }
                }
                catch { }

                if (ConfigurationManager.AppSettings["ClearTextAfterCapture"].ToUpper() == "TRUE") { serialTextBox.Text = ""; }

            }
            else { MessageBox.Show("Serial Number Cannot Be Blank", "Warning"); }

        }
    }
}

