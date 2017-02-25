using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AForge.Video.VFW;
using AForge.Video;
using motion;
using dshow;
using dshow.Core;
using VideoSource;

// Based on article - http://www.codeproject.com/cs/media/Motion_Detection.asp

namespace MotionControl
{
    public partial class MainForm : Form
    {
        private AVIWriter writer;
        private bool bStarted = false;
        private IMotionDetector detector = new MotionDetector3Optimized();
        private FilterCollection filters;
        private Bitmap bmpLastFrame;
        private int secsBetweenFrames = 5;
        private int minsAfterLastAlarm = 5;
        private DateTime timeLastSavedFrame = DateTime.Now.AddYears(-1);
        private DateTime timeLastAlarm = DateTime.Now.AddYears(-1);

        public MainForm()
        {
            InitializeComponent();

            try
            {
                filters = new FilterCollection(FilterCategory.VideoInputDevice);

                if (filters.Count == 0)
                    throw new ApplicationException();

                // add all devices to combo
                foreach (Filter filter in filters)
                {
                    cmbLocalDevice.Items.Add(filter.Name);
                }
            }
            catch (ApplicationException)
            {
                cmbLocalDevice.Items.Add("No local capture devices");
                cmbLocalDevice.Enabled = false;
            }

            cmbLocalDevice.SelectedIndex = 0;

            if ((filters == null) || (filters.Count == 0))
            {
                rbVideoSourceLocalDevice.Enabled = false;
                rbVideoSourceFile.Checked = true;

                ChooseVideoSource();
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!bStarted)
            {
                VideoSource.IVideoSource videoSource = null;

                if (rbVideoSourceLocalDevice.Checked)
                {
                    string device = filters[cmbLocalDevice.SelectedIndex].MonikerString;

                    // create video source
                    CaptureDevice localSource = new CaptureDevice();
                    localSource.VideoSource = device;

                    videoSource = localSource;
                }
                else if (rbVideoSourceFile.Checked)
                {
                    // create video source
                    VideoFileSource fileSource = new VideoFileSource();
                    fileSource.VideoSource = txtFilePath.Text;

                    videoSource = fileSource;
                }
                else if (rbVideoSourceMjpegUrl.Checked)
                {
                    // create video source
                    VideoSource.MJPEGStream mjpegSource = new VideoSource.MJPEGStream();
                    mjpegSource.VideoSource = txtMjpegUrl.Text;

                    videoSource = mjpegSource;
                }
                else if (rbVideoSourceJpegUrl.Checked)
                {
                    // create video source
                    VideoSource.JPEGStream jpegSource = new VideoSource.JPEGStream();
                    jpegSource.VideoSource = txtJpegUrl.Text;

                    videoSource = jpegSource;
                }

                // open it
                OpenVideoSource(videoSource);

                btnStartStop.Text = "Stop";
            }
            else
            {
                CloseFile();

                btnStartStop.Text = "Start";
            }
            bStarted = !bStarted;
        }

        private void OpenWriter(string fileName, int Width, int Height)
        {
            // create AVI writer
            writer = new AVIWriter("wmv3"); // "DIB";
            writer.FrameRate = 25;

            // open AVI file
            writer.Open(fileName, Width, Height);
        }

        private void CloseWriter()
        {
            writer.Close();

            writer = null;
        }

        // On alarm
        private void camera_Alarm(object sender, System.EventArgs e)
        {
            timeLastAlarm = DateTime.Now;
        }

        // On new frame
        private void camera_NewFrame(object sender, System.EventArgs e)
        {
            DateTime now = DateTime.Now;
            if ((!chkMotionActivation.Checked) || ((timeLastSavedFrame.AddSeconds(secsBetweenFrames) < now) && (timeLastAlarm.AddMinutes(minsAfterLastAlarm) > now)))
            {
                // lets save the frame
                if (writer == null)
                {
                    // create file name
                    DateTime date = DateTime.Now;
                    String fileName = String.Format("{0}-{1}-{2} {3}-{4}-{5}.avi",
                        date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);

                    try
                    {
                        OpenWriter(fileName, cameraWindow.Camera.Width, cameraWindow.Camera.Height);
                    }
                    catch
                    {
                        if (writer != null)
                        {
                            writer.Dispose();
                            writer = null;
                        }
                    }
                }

                // save the frame
                try
                {
                    // save the frame
                    Camera camera = cameraWindow.Camera;

                    camera.Lock();

                    // dispose old frame
                    if (bmpLastFrame != null)
                    {
                        bmpLastFrame.Dispose();
                    }

                    Bitmap bmpSource = camera.LastFrame;
                    bmpLastFrame = (Bitmap)bmpSource.Clone();
                    writer.AddFrame(bmpLastFrame);
                    pcbLastFrame.Image = bmpLastFrame;

                    camera.Unlock();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine(ex.ToString());
                }

                timeLastSavedFrame = DateTime.Now;
            }
        }

        private void videoSource_CheckedChanged(object sender, EventArgs e)
        {
            ChooseVideoSource();
        }

        private void ChooseVideoSource()
        {
            cmbLocalDevice.Enabled = false;
            txtFilePath.Enabled = false;
            txtJpegUrl.Enabled = false;
            txtMjpegUrl.Enabled = false;
            btnOpenFile.Enabled = false;

            if (rbVideoSourceLocalDevice.Checked)
            {
                cmbLocalDevice.Enabled = true;
            }
            else if (rbVideoSourceFile.Checked)
            {
                txtFilePath.Enabled = true;
                btnOpenFile.Enabled = true;
            }
            else if (rbVideoSourceJpegUrl.Checked)
            {
                txtJpegUrl.Enabled = true;
            }
            else if (rbVideoSourceMjpegUrl.Checked)
            {
                txtMjpegUrl.Enabled = true;
            }
        }

        // Open video source
        private void OpenVideoSource(VideoSource.IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // close previous file
            CloseFile();

            // Configure detector
            ((MotionDetector3Optimized)detector).ModifySourceImage = false;
            detector.MotionLevelCalculation = chkMotionActivation.Checked;

            // create camera
            Camera camera = new Camera(source, detector);
            // start camera
            camera.Start();

            // attach camera to camera window
            cameraWindow.Camera = camera;

            // reset statistics
            // statIndex = statReady = 0;

            // set event handlers
            camera.NewFrame += new EventHandler(camera_NewFrame);
            camera.Alarm += new EventHandler(camera_Alarm);

            this.Cursor = Cursors.Default;
        }

        // Close current file
        private void CloseFile()
        {
            Camera camera = cameraWindow.Camera;

            if (camera != null)
            {
                // detach camera from camera window
                cameraWindow.Camera = null;

                // signal camera to stop
                camera.SignalToStop();
                // wait for the camera
                camera.WaitForStop();

                camera = null;

                if (detector != null)
                    detector.Reset();
            }

            if (writer != null)
            {
                writer.Close();
                writer.Dispose();
                writer = null;
            }
        }

        // Open file
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseFile();
        }

        private void chkMotionActivation_CheckedChanged(object sender, EventArgs e)
        {
            if (detector != null)
            {
                detector.MotionLevelCalculation = chkMotionActivation.Checked;
            }

            nupSaveInterval.Enabled = chkMotionActivation.Checked;
            nupAfterLastAlarm.Enabled = chkMotionActivation.Checked;
        }

        private void nupSaveInterval_ValueChanged(object sender, EventArgs e)
        {
            secsBetweenFrames = (int)nupSaveInterval.Value;
        }

        private void nupAfterLastAlarm_ValueChanged(object sender, EventArgs e)
        {
            minsAfterLastAlarm = (int)nupAfterLastAlarm.Value;
        }

    }
}