namespace IP_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbCamera = new ComboBox();
            label1 = new Label();
            pbDisplay = new PictureBox();
            btnStart = new Button();
            btnUpload = new Button();
            btnGrayscale = new Button();
            btnNegative = new Button();
            btnSepia = new Button();
            btnNoise = new Button();
            btnChromatic = new Button();
            btnUploadVideo = new Button();
            btnPlay = new Button();
            btnPause = new Button();
            btnDownload = new Button();
            ((System.ComponentModel.ISupportInitialize)pbDisplay).BeginInit();
            SuspendLayout();
            // 
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(117, 12);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(334, 33);
            cbCamera.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 1;
            label1.Text = "Camera:";
            // 
            // pbDisplay
            // 
            pbDisplay.Location = new Point(12, 51);
            pbDisplay.Name = "pbDisplay";
            pbDisplay.Size = new Size(475, 387);
            pbDisplay.TabIndex = 2;
            pbDisplay.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(493, 404);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(494, 164);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(112, 34);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Load";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnGrayscale
            // 
            btnGrayscale.Location = new Point(494, 124);
            btnGrayscale.Name = "btnGrayscale";
            btnGrayscale.Size = new Size(112, 34);
            btnGrayscale.TabIndex = 5;
            btnGrayscale.Text = "Grayscale";
            btnGrayscale.UseVisualStyleBackColor = true;
            btnGrayscale.Click += btnGrayscale_Click;
            // 
            // btnNegative
            // 
            btnNegative.Location = new Point(494, 84);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(112, 34);
            btnNegative.TabIndex = 6;
            btnNegative.Text = "Negative";
            btnNegative.UseVisualStyleBackColor = true;
            btnNegative.Click += btnNegative_Click;
            // 
            // btnSepia
            // 
            btnSepia.Location = new Point(494, 44);
            btnSepia.Name = "btnSepia";
            btnSepia.Size = new Size(112, 34);
            btnSepia.TabIndex = 7;
            btnSepia.Text = "Sepia";
            btnSepia.UseVisualStyleBackColor = true;
            btnSepia.Click += btnSepia_Click;
            // 
            // btnNoise
            // 
            btnNoise.Location = new Point(494, 364);
            btnNoise.Name = "btnNoise";
            btnNoise.Size = new Size(112, 34);
            btnNoise.TabIndex = 8;
            btnNoise.Text = "Noise";
            btnNoise.UseVisualStyleBackColor = true;
            btnNoise.Click += btnNoise_Click;
            // 
            // btnChromatic
            // 
            btnChromatic.Location = new Point(494, 324);
            btnChromatic.Name = "btnChromatic";
            btnChromatic.Size = new Size(112, 34);
            btnChromatic.TabIndex = 9;
            btnChromatic.Text = "Chromatic";
            btnChromatic.UseVisualStyleBackColor = true;
            btnChromatic.Click += btnChromatic_Click;
            // 
            // btnUploadVideo
            // 
            btnUploadVideo.Location = new Point(493, 284);
            btnUploadVideo.Name = "btnUploadVideo";
            btnUploadVideo.Size = new Size(112, 34);
            btnUploadVideo.TabIndex = 10;
            btnUploadVideo.Text = "Load video";
            btnUploadVideo.UseVisualStyleBackColor = true;
            btnUploadVideo.Click += btnUploadVideo_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(494, 244);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(112, 34);
            btnPlay.TabIndex = 11;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(493, 204);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(112, 34);
            btnPause.TabIndex = 12;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(493, 4);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(112, 34);
            btnDownload.TabIndex = 13;
            btnDownload.Text = "Save";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 450);
            Controls.Add(btnDownload);
            Controls.Add(btnPause);
            Controls.Add(btnPlay);
            Controls.Add(btnUploadVideo);
            Controls.Add(btnChromatic);
            Controls.Add(btnNoise);
            Controls.Add(btnSepia);
            Controls.Add(btnNegative);
            Controls.Add(btnGrayscale);
            Controls.Add(btnUpload);
            Controls.Add(btnStart);
            Controls.Add(pbDisplay);
            Controls.Add(label1);
            Controls.Add(cbCamera);
            Name = "Form1";
            Text = "Webcam";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCamera;
        private Label label1;
        private PictureBox pbDisplay;
        private Button btnStart;
        private Button btnUpload;
        private Button btnGrayscale;
        private Button btnNegative;
        private Button btnSepia;
        private Button btnNoise;
        private Button btnChromatic;
        private Button btnUploadVideo;
        private Button btnPlay;
        private Button btnPause;
        private Button btnDownload;
    }
}