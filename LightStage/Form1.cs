using System;
using System.Windows.Forms;
using System.Configuration;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.IO;
using static LightStage.UsernameInsert;
using System.Diagnostics;
using AForge.Video;
using AForge.Video.DirectShow;
using Accord.Video.FFMPEG;
using AForge.Controls;
using Emgu.CV.UI;
using System.Linq;

namespace LightStage
{

    public partial class Form1 : Form
    {

        VideoCapture capture0 = null;
        VideoCapture capture1 = null;
        //VideoCapture capture2 = null;
        //VideoCapture capture3 = null;
        //VideoCapture capture4 = null;
        int h, m, s;
        public Form1()
        {
            InitializeComponent();
            videoSourcePlayer.Visible = false;
            CloseCurrentVideoSource();

            

            User user = new User();
            userTextBox.Text = User.username.ToUpper();

            if (ConfigurationManager.AppSettings["CaptureOnScan"].ToUpper() == "TRUE") { this.AcceptButton = button1; }

            resetBackColor();

            //camera settings
            capture0 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera1"]), VideoCapture.API.DShow);
            capture0.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera1X"]));
            capture0.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera1Y"]));

            if (ConfigurationManager.AppSettings["Camera2"] != "" && ConfigurationManager.AppSettings["Camera2"] != null)
            {
                capture1 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera2"]), VideoCapture.API.DShow);
                capture1.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera2X"]));
                capture1.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera2Y"]));
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
                try
                {
                    imageBox1.Image = capture0.QueryFrame();
                }
                catch
                {
                    MessageBox.Show("Câmera 1 não está conectada", "Erro");
                    Application.Exit();
                }
                try {
                    imageBox2.Image = capture1.QueryFrame();
                }
                catch {
                    MessageBox.Show("Câmera 2 não está conectada", "Erro");
                    Application.Exit();
                }

            });

            //if (capture0 == null && capture1 == null)
            //{

            //    capture0 = new Emgu.CV.VideoCapture(0);
            //    capture1 = new Emgu.CV.VideoCapture(1);
            //}
            //capture0.ImageGrabbed += VideoCapture_ImageGrabbed;
            //capture0.Start();

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
            Close();
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
            CloseCurrentVideoSource();
            Close();
        }

        private FilterInfoCollection VideoCaptureDevices;

        private VideoCaptureDevice FinalVideo = null;
        private VideoCaptureDeviceForm captureDevice;

        private Bitmap video;
        //private AVIWriter AVIwriter = new AVIWriter();
        public VideoFileWriter FileWriter = new VideoFileWriter();

        private void Form1_Load(object sender, EventArgs e)
        {
            //-----------------RECORD
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDeviceForm();
            //-----------------RECORD

        }

        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // stop current video source
            CloseCurrentVideoSource();

            // start new video source
            videoSourcePlayer.VideoSource = source;
            videoSourcePlayer.Start();

            // reset stop watch
            //stopWatch = null;

            // start timer
            //timer.Start();

            this.Cursor = Cursors.Default;
        }

        private void CloseCurrentVideoSource()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                videoSourcePlayer.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!videoSourcePlayer.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (videoSourcePlayer.IsRunning)
                {
                    videoSourcePlayer.Stop();
                }

                videoSourcePlayer.VideoSource = null;
            }
        }
        private void Filmar_Click(object sender, EventArgs e)
        {
            if (serialTextBox.Text.Length >= 1 && userTextBox.Text.Length >= 1)
            {
                if (Parar.Text == "Desligar")
                {
                    timer.Start();
                    //saveAvi = new SaveFileDialog();
                    //saveAvi.Filter = "Avi Files (*.avi)|*.avi";
                    //if (saveAvi.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    //{
                    
                    FileWriter.WriteVideoFrame(video);

                    Filmar.Enabled = false;
                    Parar.Text = "Parar";
                    RecordingGif.Visible = true;
                    //}
                }
            }
            else { MessageBox.Show("Serial Number não pode ser vazio", "Warning"); }
        }

        void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (Parar.Text == "Parar")
            {
                video = (Bitmap)eventArgs.Frame.Clone();
                //pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
                //AVIwriter.Quality = 0;
                FileWriter.WriteVideoFrame(video);
                //AVIwriter.AddFrame(video);
            }
            else //Stop
            {
                video = (Bitmap)eventArgs.Frame.Clone();
                //pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        private void Parar_Click(object sender, EventArgs e)
        {
            
            if (Parar.Text == "Parar")
            {
                timer.Stop();
                s = 0;
                m = 0;
                h = 0;
                txtTimer.Text = "00:00:00";
                Parar.Text = "Desligar";
                Filmar.Enabled = true;
                if (FinalVideo == null)
                { return; }
                if (FinalVideo.IsRunning)
                {
                    //this.FinalVideo.Stop();
                    FileWriter.Close();
                    //this.AVIwriter.Close();
                    //pictureBox1.Image = null;
                }
                RecordingGif.Visible = false;
                MessageBox.Show("Gravação Salva");
            }

            else if (Parar.Text == "Desligar")
            {               
                FileWriter.Close();
                Parar.Enabled = false;
                Ligar.Enabled = true;
                button1.Enabled = true;
                Filmar.Enabled = false;
                videoSourcePlayer.Visible = false;
                serialTextBox.Enabled = true;
                CloseCurrentVideoSource();
                capture0 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera1"]), VideoCapture.API.DShow);
                capture0.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera1X"]));
                capture0.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera1Y"]));

                capture1 = new VideoCapture(Convert.ToInt16(ConfigurationManager.AppSettings["Camera2"]), VideoCapture.API.DShow);
                capture1.SetCaptureProperty(CapProp.FrameWidth, Convert.ToInt16(ConfigurationManager.AppSettings["Camera2X"]));
                capture1.SetCaptureProperty(CapProp.FrameHeight, Convert.ToInt16(ConfigurationManager.AppSettings["Camera2Y"]));

                
                //this.AVIwriter.Close();
                //pictureBox1.Image = null;
            }
            else
            {
                this.FinalVideo.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m == 60)
            {
                m = 0;
                h += 1;
            }
            txtTimer.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }

        private void Ligar_Click(object sender, EventArgs e)
        {
            if (serialTextBox.Text.Length >= 1 && userTextBox.Text.Length >= 1)
            {
          
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoCaptureDevice videoSource = new VideoCaptureDevice(VideoCaptureDevices[0].MonikerString);

            //captureDevice = new VideoCaptureDeviceForm();

            //if (captureDevice.ShowDialog(this) == DialogResult.OK)
            //{
                capture0.Dispose();
                capture1.Dispose();
                videoSourcePlayer.Visible = true;
                Parar.Enabled = true; 
                Ligar.Enabled = false;
                button1.Enabled = false;
                Filmar.Enabled = true;

            // create video source
            FinalVideo = videoSource;

            FinalVideo.VideoResolution = FinalVideo.VideoCapabilities.First();
            int h = FinalVideo.VideoResolution.FrameSize.Height;
            int w = FinalVideo.VideoResolution.FrameSize.Width;
            FileWriter.Open(ConfigurationManager.AppSettings["SavePath"] + "\\" + serialTextBox.Text.ToUpper() + "_" + userTextBox.Text.ToUpper() + ConfigurationManager.AppSettings["AppendCam1"] + ".avi", w, h, 25, VideoCodec.Default, 5000000);
            serialTextBox.Enabled = false;
            // open it
            OpenVideoSource(FinalVideo);
                FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                FinalVideo.Start();

            }
            else { MessageBox.Show("Serial Number não pode ser vazio", "Warning"); }
            //}

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

