using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Imaging;

namespace hslfilterblob
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoCaptureDevices;
        private VideoCaptureDevice finalVideo;
        private int minHue = 0, maxHue = 355;
        private float minLum = 0, maxLum = 1, minSat = 0, maxSat = 1;
        private Byte[] buffer = new Byte[1];
        //private bool serialok = false;
        //private float map = 0f;

        public Form1()
        {
            InitializeComponent();
            videoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            finalVideo = new VideoCaptureDevice(videoCaptureDevices[0].MonikerString);
            finalVideo.NewFrame += new NewFrameEventHandler(Finalvideo_newframe);
            finalVideo.Start();
        }

        void Finalvideo_newframe(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            Bitmap video2 = (Bitmap)eventArgs.Frame.Clone();
            //Create color filter
            HSLFiltering HslFilter = new HSLFiltering();
            //configre the filter
            HslFilter.Hue = new AForge.IntRange(minHue, maxHue);
            HslFilter.Saturation = new AForge.Range(minSat, maxSat);
            HslFilter.Luminance = new AForge.Range(minLum, maxLum);
            //apply color filter to the image
            HslFilter.ApplyInPlace(video2);
            //create gray filter 
            Grayscale grayFilter = new GrayscaleBT709();
            Bitmap grayImage = grayFilter.Apply(video2);
            //display Image
            BlobCounter blobcounter = new BlobCounter();
            blobcounter.MinHeight = 100;
            blobcounter.MinWidth = 100;
            blobcounter.ObjectsOrder = ObjectsOrder.Size;
            //locate blobs
            blobcounter.ProcessImage(grayImage);
            Rectangle[] rects = blobcounter.GetObjectsRectangles();
            //draw rectangle around the biggest blob
            if (rects.Length > 0)
            {
                Rectangle objectRect1 = rects[0];

                Graphics g = Graphics.FromImage(video);

                using (Pen pen = new Pen(Color.Red, 3))
                {
                    g.DrawRectangle(pen, objectRect1);
                    PointF drawPoin = new PointF(objectRect1.X, objectRect1.Y);
                    int objectX = objectRect1.X + objectRect1.Width / 2 - video.Width / 2;
                    int objectY = video.Height / 2 - (objectRect1.Y + objectRect1.Height / 2);
                    String Blobinformation = "X= " + objectX.ToString() + "\nY= " + objectY.ToString() + "\nSize=" + objectRect1.Size.ToString();
                    g.DrawString(Blobinformation, new Font("Arial", 16), new SolidBrush(Color.Blue), drawPoin);

                    //if (serialok == true)
                    //{
                    //    int second = 0;
                    //    int offset = 300;
                    //    second = offset - Math.Abs(objectX);
                    //    map = (float)0.85 * second;
                    //    buffer[0] = (byte)Math.Abs((int)map);
                    //    serialPort1.Write(buffer, 0, 1);
                    //}
                }
                g.Dispose();

            }
            pictureBox1.Image = video;
            pictureBox2.Image = grayImage;
        }

        private void trackBarMaxHue_Scroll(object sender, EventArgs e)
        {
            //maxHue = trackBarMaxHue.Value;
        }

        private void trackBarMinHue_Scroll(object sender, EventArgs e)
        {
            //minHue = trackBarMinHue.Value;
        }

        private void trackBarMaxSat_Scroll(object sender, EventArgs e)
        {
            //maxSat = trackBarMaxSat.Value / 100F;
        }

        private void trackBarSatMin_Scroll(object sender, EventArgs e)
        {
            //minSat = trackBarSatMin.Value / 100F;
        }

        private void trackBarLumMax_Scroll(object sender, EventArgs e)
        {
            //maxLum = trackBarLumMax.Value / 100F;
        }

        private void trackBarLumMin_Scroll(object sender, EventArgs e)
        {
            //minLum = trackBarSatMin.Value / 100F;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = colorDlg.Color.GetHue().ToString();
                textBox2.Text = colorDlg.Color.GetSaturation().ToString();
                textBox3.Text = colorDlg.Color.GetBrightness().ToString();
            }
        }

        private void btnCommunication_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    serialPort1.Open();
            //    btnCommunication.BackColor = Color.Green;
            //    serialok = true;
            //}
            //catch (Exception t)
            //{
            //    MessageBox.Show(t.ToString());
            //}
        }
    }
}