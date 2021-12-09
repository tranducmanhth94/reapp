using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
using System.Diagnostics;
using System.IO;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using BasselTech_CamCapture;
using ZXing;
using ZXing.Aztec;





namespace reapp_altium
{
    public partial class form_Cam : Form
    {
        //summary
        //Filed that holds the webcamera collection

        private FilterInfoCollection VideoCaptureDevices;

        //summary
        //filed that holds information on the attached webcamera

        private VideoCaptureDevice FinalVideo;

       // Camera cam;
        Timer t;
        BackgroundWorker worker;
        Bitmap CapImage;



        public form_Cam()
        {
            InitializeComponent();

            #region Get attched cameras

            //gets the camera devices attched and adds then to attched camera combo box.

            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                comboBoxAttachedCameras.Items.Add(VideoCaptureDevice.Name);
            }
            // set the combobox to show the frist camer attached as default.
            comboBoxAttachedCameras.SelectedIndex = 0;
            #endregion


            #region Get supported modes

            //gets the camera supported modes and adds then to supported modes combobox.

            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[comboBoxAttachedCameras.SelectedIndex].MonikerString);

            foreach (var capability in FinalVideo.VideoCapabilities)
            {
                comboBoxSupportedModes.Items.Add(capability.FrameSize.ToString() + ":" + capability.MaximumFrameRate.ToString() + ":" + capability.BitCount.ToString());
            }

            comboBoxSupportedModes.SelectedIndex = 0;

            #endregion

            // attach event handler for when a new frame is received 

            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);

            // QR scan
            t = new Timer();
          //  cam = new Camera(pictureBox1);
            worker = new BackgroundWorker();

            worker.DoWork += Worker_DoWork;
            t.Tick += T_Tick;
            t.Interval = 1;

        }

        private void T_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
           // CapImage = cam.GetBitmap();
            if (CapImage != null && !worker.IsBusy)
                worker.RunWorkerAsync();
         

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // throw new NotImplementedException();
            QRCodeDecoder Decoder = new QRCodeDecoder();
            try
            {
                 MessageBox.Show(Decoder.decode(new QRCodeBitmapImage(CapImage)));

            }
            catch(Exception)
            {

            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            // sets seledted video resolution from the supported modes combobox
            FinalVideo.VideoResolution = FinalVideo.VideoCapabilities[comboBoxSupportedModes.SelectedIndex];

            // resets the client area size to properly contain the selected frame size and all controls
            this.Width = FinalVideo.VideoResolution.FrameSize.Width + pictureBox1.Width + 40;  // group check
            this.Height = FinalVideo.VideoResolution.FrameSize.Height + 70;

            // resets the client area size to properly contain the selected frame size 

            this.pictureBox1.Width = FinalVideo.VideoResolution.FrameSize.Width;
            this.pictureBox1.Height = FinalVideo.VideoResolution.FrameSize.Height;

            FinalVideo.Start();
            t.Start();


        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            FinalVideo.Stop();
          
        }

        private void FinalVideo_NewFrame(object sende, NewFrameEventArgs eventArgs)
        {
            //if the picture box already has an image then dispose of it before redrawing the new frame.
            // this prevent out of memory error.
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            // create a new bitmap from a clone of the new frame and show it in the picturebox
            // seing as we have the camera frame we could preform a whole manner of processing on it!
            Bitmap temBitmap = (Bitmap)eventArgs.Frame.Clone();
            CapImage = temBitmap;
            pictureBox1.Image = temBitmap;
        }


        private void btn_checksize_Click_1(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory.SolutionFolder(),
               @"C:\Users\trand\source\repos\reapp_altium\image\CSharp-image-AForge-master\2016310249_ObjectDetecting\bin\Debug\2016310249_ObjectDetecting.exe"));
        }

  

     
    }
}
