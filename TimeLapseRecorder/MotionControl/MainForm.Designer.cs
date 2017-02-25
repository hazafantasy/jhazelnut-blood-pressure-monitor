namespace MotionControl
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pcbLastFrame = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nupSaveInterval = new System.Windows.Forms.NumericUpDown();
            this.chkMotionActivation = new System.Windows.Forms.CheckBox();
            this.rbVideoSourceMjpegUrl = new System.Windows.Forms.RadioButton();
            this.txtMjpegUrl = new System.Windows.Forms.TextBox();
            this.txtJpegUrl = new System.Windows.Forms.TextBox();
            this.rbVideoSourceJpegUrl = new System.Windows.Forms.RadioButton();
            this.rbVideoSourceLocalDevice = new System.Windows.Forms.RadioButton();
            this.rbVideoSourceFile = new System.Windows.Forms.RadioButton();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.cmbLocalDevice = new System.Windows.Forms.ComboBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.nupAfterLastAlarm = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cameraWindow = new motion.CameraWindow();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLastFrame)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSaveInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAfterLastAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 189);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cameraWindow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pcbLastFrame);
            this.splitContainer1.Size = new System.Drawing.Size(790, 414);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 4;
            // 
            // pcbLastFrame
            // 
            this.pcbLastFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLastFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbLastFrame.Location = new System.Drawing.Point(0, 0);
            this.pcbLastFrame.Name = "pcbLastFrame";
            this.pcbLastFrame.Size = new System.Drawing.Size(393, 414);
            this.pcbLastFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLastFrame.TabIndex = 4;
            this.pcbLastFrame.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nupAfterLastAlarm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nupSaveInterval);
            this.groupBox1.Controls.Add(this.chkMotionActivation);
            this.groupBox1.Controls.Add(this.rbVideoSourceMjpegUrl);
            this.groupBox1.Controls.Add(this.txtMjpegUrl);
            this.groupBox1.Controls.Add(this.txtJpegUrl);
            this.groupBox1.Controls.Add(this.rbVideoSourceJpegUrl);
            this.groupBox1.Controls.Add(this.rbVideoSourceLocalDevice);
            this.groupBox1.Controls.Add(this.rbVideoSourceFile);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.cmbLocalDevice);
            this.groupBox1.Controls.Add(this.btnStartStop);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Source";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "seconds. Continue saving ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nupSaveInterval
            // 
            this.nupSaveInterval.Location = new System.Drawing.Point(331, 143);
            this.nupSaveInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupSaveInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSaveInterval.Name = "nupSaveInterval";
            this.nupSaveInterval.Size = new System.Drawing.Size(67, 20);
            this.nupSaveInterval.TabIndex = 19;
            this.nupSaveInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupSaveInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupSaveInterval.ValueChanged += new System.EventHandler(this.nupSaveInterval_ValueChanged);
            // 
            // chkMotionActivation
            // 
            this.chkMotionActivation.AutoSize = true;
            this.chkMotionActivation.Checked = true;
            this.chkMotionActivation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMotionActivation.Location = new System.Drawing.Point(100, 146);
            this.chkMotionActivation.Name = "chkMotionActivation";
            this.chkMotionActivation.Size = new System.Drawing.Size(225, 17);
            this.chkMotionActivation.TabIndex = 18;
            this.chkMotionActivation.Text = "Motion Activated and record a frame each";
            this.chkMotionActivation.UseVisualStyleBackColor = true;
            this.chkMotionActivation.CheckedChanged += new System.EventHandler(this.chkMotionActivation_CheckedChanged);
            // 
            // rbVideoSourceMjpegUrl
            // 
            this.rbVideoSourceMjpegUrl.AutoSize = true;
            this.rbVideoSourceMjpegUrl.Location = new System.Drawing.Point(6, 111);
            this.rbVideoSourceMjpegUrl.Name = "rbVideoSourceMjpegUrl";
            this.rbVideoSourceMjpegUrl.Size = new System.Drawing.Size(79, 17);
            this.rbVideoSourceMjpegUrl.TabIndex = 17;
            this.rbVideoSourceMjpegUrl.Text = "&MJPG URL";
            this.rbVideoSourceMjpegUrl.UseVisualStyleBackColor = true;
            this.rbVideoSourceMjpegUrl.CheckedChanged += new System.EventHandler(this.videoSource_CheckedChanged);
            // 
            // txtMjpegUrl
            // 
            this.txtMjpegUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMjpegUrl.Enabled = false;
            this.txtMjpegUrl.Location = new System.Drawing.Point(100, 110);
            this.txtMjpegUrl.Name = "txtMjpegUrl";
            this.txtMjpegUrl.Size = new System.Drawing.Size(684, 20);
            this.txtMjpegUrl.TabIndex = 16;
            // 
            // txtJpegUrl
            // 
            this.txtJpegUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJpegUrl.Enabled = false;
            this.txtJpegUrl.Location = new System.Drawing.Point(100, 84);
            this.txtJpegUrl.Name = "txtJpegUrl";
            this.txtJpegUrl.Size = new System.Drawing.Size(684, 20);
            this.txtJpegUrl.TabIndex = 15;
            // 
            // rbVideoSourceJpegUrl
            // 
            this.rbVideoSourceJpegUrl.AutoSize = true;
            this.rbVideoSourceJpegUrl.Location = new System.Drawing.Point(6, 85);
            this.rbVideoSourceJpegUrl.Name = "rbVideoSourceJpegUrl";
            this.rbVideoSourceJpegUrl.Size = new System.Drawing.Size(77, 17);
            this.rbVideoSourceJpegUrl.TabIndex = 14;
            this.rbVideoSourceJpegUrl.Text = "&JPEG URL";
            this.rbVideoSourceJpegUrl.UseVisualStyleBackColor = true;
            this.rbVideoSourceJpegUrl.CheckedChanged += new System.EventHandler(this.videoSource_CheckedChanged);
            // 
            // rbVideoSourceLocalDevice
            // 
            this.rbVideoSourceLocalDevice.AutoSize = true;
            this.rbVideoSourceLocalDevice.Checked = true;
            this.rbVideoSourceLocalDevice.Location = new System.Drawing.Point(6, 32);
            this.rbVideoSourceLocalDevice.Name = "rbVideoSourceLocalDevice";
            this.rbVideoSourceLocalDevice.Size = new System.Drawing.Size(88, 17);
            this.rbVideoSourceLocalDevice.TabIndex = 13;
            this.rbVideoSourceLocalDevice.TabStop = true;
            this.rbVideoSourceLocalDevice.Text = "Local &Device";
            this.rbVideoSourceLocalDevice.UseVisualStyleBackColor = true;
            this.rbVideoSourceLocalDevice.CheckedChanged += new System.EventHandler(this.videoSource_CheckedChanged);
            // 
            // rbVideoSourceFile
            // 
            this.rbVideoSourceFile.AutoSize = true;
            this.rbVideoSourceFile.Location = new System.Drawing.Point(6, 59);
            this.rbVideoSourceFile.Name = "rbVideoSourceFile";
            this.rbVideoSourceFile.Size = new System.Drawing.Size(41, 17);
            this.rbVideoSourceFile.TabIndex = 12;
            this.rbVideoSourceFile.Text = "&File";
            this.rbVideoSourceFile.UseVisualStyleBackColor = true;
            this.rbVideoSourceFile.CheckedChanged += new System.EventHandler(this.videoSource_CheckedChanged);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Location = new System.Drawing.Point(756, 56);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(28, 23);
            this.btnOpenFile.TabIndex = 11;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(100, 58);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(650, 20);
            this.txtFilePath.TabIndex = 10;
            // 
            // cmbLocalDevice
            // 
            this.cmbLocalDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLocalDevice.FormattingEnabled = true;
            this.cmbLocalDevice.Location = new System.Drawing.Point(100, 31);
            this.cmbLocalDevice.Name = "cmbLocalDevice";
            this.cmbLocalDevice.Size = new System.Drawing.Size(684, 21);
            this.cmbLocalDevice.TabIndex = 9;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(6, 142);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 8;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "AVI files (*.avi)|*.avi";
            this.ofd.Title = "Open movie";
            // 
            // nupAfterLastAlarm
            // 
            this.nupAfterLastAlarm.Location = new System.Drawing.Point(542, 143);
            this.nupAfterLastAlarm.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupAfterLastAlarm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupAfterLastAlarm.Name = "nupAfterLastAlarm";
            this.nupAfterLastAlarm.Size = new System.Drawing.Size(67, 20);
            this.nupAfterLastAlarm.TabIndex = 21;
            this.nupAfterLastAlarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupAfterLastAlarm.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupAfterLastAlarm.ValueChanged += new System.EventHandler(this.nupAfterLastAlarm_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "minutes after last movement.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cameraWindow
            // 
            this.cameraWindow.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cameraWindow.Camera = null;
            this.cameraWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraWindow.Location = new System.Drawing.Point(0, 0);
            this.cameraWindow.Name = "cameraWindow";
            this.cameraWindow.Size = new System.Drawing.Size(393, 414);
            this.cameraWindow.TabIndex = 0;
            this.cameraWindow.Text = "cameraWindow1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "TimeLapse video recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLastFrame)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSaveInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAfterLastAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pcbLastFrame;
        private System.Windows.Forms.RadioButton rbVideoSourceFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.ComboBox cmbLocalDevice;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.RadioButton rbVideoSourceLocalDevice;
        private System.Windows.Forms.RadioButton rbVideoSourceMjpegUrl;
        private System.Windows.Forms.TextBox txtMjpegUrl;
        private System.Windows.Forms.TextBox txtJpegUrl;
        private System.Windows.Forms.RadioButton rbVideoSourceJpegUrl;
        private System.Windows.Forms.OpenFileDialog ofd;
        private motion.CameraWindow cameraWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupSaveInterval;
        private System.Windows.Forms.CheckBox chkMotionActivation;
        private System.Windows.Forms.NumericUpDown nupAfterLastAlarm;
        private System.Windows.Forms.Label label2;
    }
}

