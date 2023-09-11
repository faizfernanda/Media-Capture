

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Drawing.Imaging;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice vidioSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo deviceList in captureDevice)
            {
                comboBoxWebcamlist.Items.Add(deviceList.Name);
            }
            comboBoxWebcamlist.SelectedIndex = 0;
            vidioSource = new VideoCaptureDevice();
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            if (vidioSource.IsRunning)
            {
                vidioSource.SignalToStop();
                vidioSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            vidioSource = new VideoCaptureDevice(captureDevice[comboBoxWebcamlist.SelectedIndex].MonikerString);
            vidioSource.NewFrame += new NewFrameEventHandler(VidioSource_NewFrame);
            vidioSource.Start();
        }

        private void VidioSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void buttoncapture_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image AS";
            saveFileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg *.png";
            ImageFormat imageFormat = ImageFormat.Png;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                }
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            if (vidioSource.IsRunning)
            {
                vidioSource.SignalToStop();
                vidioSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                pictureBox2.Image = null;
                pictureBox2.Invalidate();
            }

            Application.Exit(null);
        }
    }
}