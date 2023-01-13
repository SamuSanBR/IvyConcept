// LightStage
//
// Capture multple angle pictures automatically
// and save them to a shared folder
// Requires computer with multiple USB controllers due to bandwidth requirements
// Added watermark support
//
// Mark Bowling
// Sept 2021

using System;
using System.Windows.Forms;
using System.Configuration;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.IO;
using Emgu.CV.Structure;
using System.Data;
using System.Collections.Generic;
using static LightStage.UsernameInsert;
using Emgu.CV.UI;

namespace LightStage
{

    public partial class Form1 : Form
    {

        VideoCapture capture0 = null;
        VideoCapture capture1 = null;
        //VideoCapture capture2 = null;
        //VideoCapture capture3 = null;
        //VideoCapture capture4 = null;
        public Form1()
        {
            InitializeComponent();

            User user = new User();
            userTextBox.Text = User.username;

            if (ConfigurationManager.AppSettings["CaptureOnScan"].ToUpper() == "TRUE") { this.AcceptButton = button1; }

            resetBackColor();
            camera1.BackColor = Color.LawnGreen;

            //camera settings
            capture0 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera1"]), VideoCapture.API.DShow);
            capture0.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera1X"]));
            capture0.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera1Y"]));

            if (ConfigurationManager.AppSettings["Camera2"] != "" && ConfigurationManager.AppSettings["Camera2"] != null)
            {
                capture1 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera2"]), VideoCapture.API.DShow);
                capture1.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera2X"]));
                capture1.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera2Y"]));
                camera2.Visible = true;
            }
            //if (ConfigurationManager.AppSettings["Camera3"] != "" && ConfigurationManager.AppSettings["Camera3"] != null)
            //{
            //    capture2 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera3"]), VideoCapture.API.DShow);
            //    capture2.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera3X"]));
            //    capture2.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera3Y"]));
            //    camera3.Visible = true;
            //}
            //if (ConfigurationManager.AppSettings["Camera4"] != "" && ConfigurationManager.AppSettings["Camera4"] != null)
            //{
            //    capture3 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera4"]), VideoCapture.API.DShow);
            //    capture3.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera4X"]));
            //    capture3.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera4Y"]));
            //    camera4.Visible = true;
            //}
            //if (ConfigurationManager.AppSettings["Camera5"] != "" && ConfigurationManager.AppSettings["Camera5"] != null)
            //{
            //    capture4 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera5"]), VideoCapture.API.DShow);
            //    capture4.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera5X"]));
            //    capture4.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera5Y"]));
            //    camera5.Visible = true;
            //}


            Mat img = new Mat();

            Application.Idle += new EventHandler(delegate (object sender, EventArgs e)
            {

                //if (activeCamera == 1) { img = capture0.QueryFrame(); }
                //if (activeCamera == 2) { img = capture1.QueryFrame(); }
                //if (activeCamera == 3) { img = capture2.QueryFrame(); }
                //if (activeCamera == 4) { img = capture3.QueryFrame(); }
                //if (activeCamera == 5) { img = capture4.QueryFrame(); }

                //if (imageBox1.Image != null) { imageBox1.Image.Dispose(); }

                //if(ConfigurationManager.AppSettings["AddWaterMark"].ToUpper() == "TRUE")
                //{
                //    img = waterMarkImage(img);
                //}
                imageBox1.Image = capture0.QueryFrame();
                imageBox2.Image = capture1.QueryFrame();
            });

        }


        private void camera1_Click(object sender, EventArgs e)
        {
            //activeCamera = 1;
            resetBackColor();
            camera1.BackColor = Color.LawnGreen;
        }

        private void camera2_Click(object sender, EventArgs e)
        {
            //activeCamera = 2;
            resetBackColor();
            camera2.BackColor = Color.LawnGreen;
        }

        //private void camera3_Click(object sender, EventArgs e)
        //{
        //    activeCamera = 3;
        //    resetBackColor();
        //    camera3.BackColor = Color.LawnGreen;
        //}

        //private void camera4_Click(object sender, EventArgs e)
        //{
        //    activeCamera = 4;
        //    resetBackColor();
        //    camera4.BackColor = Color.LawnGreen;
        //}

        //private void camera5_Click(object sender, EventArgs e)
        //{
        //    activeCamera = 5;
        //    resetBackColor();
        //    camera5.BackColor = Color.LawnGreen;
        //} 

        private void resetBackColor()
        {
            foreach (Control button in panel2.Controls)
            {
                if (button is Button) { ((Button)button).BackColor = Color.LightGray; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo pictureDirectory = new DirectoryInfo(ConfigurationManager.AppSettings["SavePath"]);


            if (serialTextBox.Text.Length >= 1 && userTextBox.Text.Length >= 1)
            {
                //try
                //{
                //    if (Directory.Exists(serialTextBox.Text + "_" + userTextBox.Text))
                //    {
                //        Directory.Delete(serialTextBox.Text + "_" + userTextBox.Text, true);
                //    }

                //    Directory.CreateDirectory(serialTextBox.Text + "_" + userTextBox.Text);
                //}
                //catch (Exception exception) { MessageBox.Show("Error Creating Directory\n" + exception.ToString(), "I/O Error"); }


                Mat img = null;
                try
                {
                    img = capture0.QueryFrame();
                    //if (ConfigurationManager.AppSettings["AddWaterMark"].ToUpper() == "TRUE")
                    //{
                    //    img = waterMarkImage(img);
                    //}
                    img.Save(pictureDirectory + "\\" + serialTextBox.Text.ToUpper() + "_" + userTextBox.Text.ToUpper() + ConfigurationManager.AppSettings["AppendCam1"] + ".jpg");
                    try { img.Dispose(); } catch { }

                    MessageBox.Show("Imagem 1 salva");
                }
                catch { }

                try
                {
                    img = capture1.QueryFrame();
                    //if (ConfigurationManager.AppSettings["AddWaterMark"].ToUpper() == "TRUE")
                    //{
                    //    img = waterMarkImage(img);
                    //}
                    img.Save(pictureDirectory + "\\" + serialTextBox.Text.ToUpper() + "_" + userTextBox.Text.ToUpper() + ConfigurationManager.AppSettings["AppendCam2"] + ".jpg");
                    try { img.Dispose(); } catch { }
                    MessageBox.Show("Imagem 2 salva");
                }
                catch { }

                //try
                //{
                //    img = capture2.QueryFrame();
                //    if (ConfigurationManager.AppSettings["AddWaterMark"].ToUpper() == "TRUE")
                //    {
                //        img = waterMarkImage(img);
                //    }
                //    img.Save(pictureDirectory + serialTextBox.Text + "\\" + serialTextBox.Text + ConfigurationManager.AppSettings["AppendCam3"] + ".jpg");
                //    try { img.Dispose(); } catch { }
                //}
                //catch { }

                //try
                //{
                //    img = capture3.QueryFrame();
                //    if (ConfigurationManager.AppSettings["AddWaterMark"].ToUpper() == "TRUE")
                //    {
                //        img = waterMarkImage(img);
                //    }
                //    img.Save(pictureDirectory + serialTextBox.Text + "\\" + serialTextBox.Text + ConfigurationManager.AppSettings["AppendCam4"] + ".jpg");
                //    try { img.Dispose(); } catch { }
                //}
                //catch { }

                //try
                //{
                //    img = capture4.QueryFrame();
                //    if (ConfigurationManager.AppSettings["AddWaterMark"].ToUpper() == "TRUE")
                //    {
                //        img = waterMarkImage(img);
                //    }
                //    img.Save(pictureDirectory + serialTextBox.Text + "\\" + serialTextBox.Text + ConfigurationManager.AppSettings["AppendCam5"] + ".jpg");
                //    try { img.Dispose(); } catch { }
                //}
                //catch { }

                if (ConfigurationManager.AppSettings["ClearTextAfterCapture"].ToUpper() == "TRUE") { serialTextBox.Text = ""; }

            }
            else { MessageBox.Show("Serial Number não pode ser vazio", "Warning"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormParametersReport fpr = new FormParametersReport();
            Hide();
            fpr.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UsernameInsert userinsert = new UsernameInsert();
            Hide();
            userinsert.ShowDialog();
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        //public Mat waterMarkImage(Mat imageMat)
        //{
        //    Mat waterMark = new Mat(ConfigurationManager.AppSettings["WatermarkLocation"]);

        //    double betaChannel = Convert.ToDouble(ConfigurationManager.AppSettings["WaterMarkBeta"]);

        //    Image<Bgr, Byte> newImage = imageMat.ToImage<Bgr, Byte>();
        //    Image<Bgr, Byte> waterImage = waterMark.ToImage<Bgr, Byte>();
        //    Image<Bgr, Byte> waterMarkedImage = imageMat.ToImage<Bgr, Byte>();

        //    int x = 0;
        //    int y = 0;
        //    int w = waterMark.Width;
        //    int h = waterMark.Height;
        //    Rectangle rect = new Rectangle(x,y,w,h);

        //    try
        //    {
        //        newImage.ROI = rect;
        //        waterMarkedImage.ROI = rect;

        //        CvInvoke.AddWeighted(newImage, 1, waterImage, betaChannel, 1, waterMarkedImage);

        //        newImage.Dispose();
        //        waterImage.Dispose();
        //    }

        //    catch { MessageBox.Show("Watermark larger than camera resolution!"); }

        //    return waterMarkedImage.Mat;
        //}
    }
}

