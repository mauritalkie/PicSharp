namespace IP_Project
{
    partial class Videos
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
            pbVideo = new PictureBox();
            btnLoadVideo = new Button();
            cbFilters = new ComboBox();
            btnVideoState = new Button();
            label1 = new Label();
            panel1 = new Panel();
            btnCount = new Button();
            btnRecognition = new Button();
            btnVideos = new Button();
            btnImages = new Button();
            btnUserManual = new Button();
            panel2 = new Panel();
            trackbar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pbVideo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackbar).BeginInit();
            SuspendLayout();
            // 
            // pbVideo
            // 
            pbVideo.BackColor = SystemColors.ActiveBorder;
            pbVideo.BorderStyle = BorderStyle.FixedSingle;
            pbVideo.Location = new Point(279, 103);
            pbVideo.Name = "pbVideo";
            pbVideo.Size = new Size(776, 295);
            pbVideo.TabIndex = 0;
            pbVideo.TabStop = false;
            // 
            // btnLoadVideo
            // 
            btnLoadVideo.BackColor = Color.Navy;
            btnLoadVideo.FlatAppearance.BorderSize = 0;
            btnLoadVideo.FlatStyle = FlatStyle.Flat;
            btnLoadVideo.ForeColor = Color.Gainsboro;
            btnLoadVideo.Location = new Point(432, 404);
            btnLoadVideo.Name = "btnLoadVideo";
            btnLoadVideo.Size = new Size(112, 34);
            btnLoadVideo.TabIndex = 2;
            btnLoadVideo.Text = "Cargar";
            btnLoadVideo.UseVisualStyleBackColor = false;
            btnLoadVideo.Click += btnLoadVideo_Click;
            // 
            // cbFilters
            // 
            cbFilters.FlatStyle = FlatStyle.Flat;
            cbFilters.FormattingEnabled = true;
            cbFilters.Location = new Point(288, 47);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(220, 33);
            cbFilters.TabIndex = 3;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // btnVideoState
            // 
            btnVideoState.BackColor = Color.Navy;
            btnVideoState.FlatAppearance.BorderSize = 0;
            btnVideoState.FlatStyle = FlatStyle.Flat;
            btnVideoState.ForeColor = Color.Gainsboro;
            btnVideoState.Location = new Point(747, 404);
            btnVideoState.Name = "btnVideoState";
            btnVideoState.Size = new Size(112, 34);
            btnVideoState.TabIndex = 4;
            btnVideoState.Text = "Pausar";
            btnVideoState.UseVisualStyleBackColor = false;
            btnVideoState.Click += btnVideoState_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(315, 19);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 5;
            label1.Text = "Seleccione un filtro";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnCount);
            panel1.Controls.Add(btnRecognition);
            panel1.Controls.Add(btnVideos);
            panel1.Controls.Add(btnImages);
            panel1.Controls.Add(btnUserManual);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 450);
            panel1.TabIndex = 9;
            // 
            // btnCount
            // 
            btnCount.Dock = DockStyle.Top;
            btnCount.FlatAppearance.BorderSize = 0;
            btnCount.FlatStyle = FlatStyle.Flat;
            btnCount.ForeColor = Color.Gainsboro;
            btnCount.Location = new Point(0, 320);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(220, 60);
            btnCount.TabIndex = 10;
            btnCount.Text = "Conteo";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnRecognition
            // 
            btnRecognition.Dock = DockStyle.Top;
            btnRecognition.FlatAppearance.BorderSize = 0;
            btnRecognition.FlatStyle = FlatStyle.Flat;
            btnRecognition.ForeColor = Color.Gainsboro;
            btnRecognition.Location = new Point(0, 260);
            btnRecognition.Name = "btnRecognition";
            btnRecognition.Size = new Size(220, 60);
            btnRecognition.TabIndex = 8;
            btnRecognition.Text = "Reconocimiento";
            btnRecognition.UseVisualStyleBackColor = true;
            btnRecognition.Click += btnRecognition_Click;
            // 
            // btnVideos
            // 
            btnVideos.BackColor = Color.Navy;
            btnVideos.Dock = DockStyle.Top;
            btnVideos.FlatAppearance.BorderSize = 0;
            btnVideos.FlatStyle = FlatStyle.Flat;
            btnVideos.ForeColor = Color.Gainsboro;
            btnVideos.Location = new Point(0, 200);
            btnVideos.Name = "btnVideos";
            btnVideos.Size = new Size(220, 60);
            btnVideos.TabIndex = 7;
            btnVideos.Text = "Videos";
            btnVideos.UseVisualStyleBackColor = false;
            // 
            // btnImages
            // 
            btnImages.BackColor = Color.FromArgb(51, 51, 76);
            btnImages.Dock = DockStyle.Top;
            btnImages.FlatAppearance.BorderSize = 0;
            btnImages.FlatStyle = FlatStyle.Flat;
            btnImages.ForeColor = Color.Gainsboro;
            btnImages.Location = new Point(0, 140);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(220, 60);
            btnImages.TabIndex = 6;
            btnImages.Text = "Imágenes";
            btnImages.UseVisualStyleBackColor = false;
            btnImages.Click += btnImages_Click;
            // 
            // btnUserManual
            // 
            btnUserManual.BackColor = Color.FromArgb(51, 51, 76);
            btnUserManual.Dock = DockStyle.Top;
            btnUserManual.FlatAppearance.BorderSize = 0;
            btnUserManual.FlatStyle = FlatStyle.Flat;
            btnUserManual.ForeColor = Color.Gainsboro;
            btnUserManual.Location = new Point(0, 80);
            btnUserManual.Name = "btnUserManual";
            btnUserManual.Size = new Size(220, 60);
            btnUserManual.TabIndex = 5;
            btnUserManual.Text = "Manual de usuario";
            btnUserManual.UseVisualStyleBackColor = false;
            btnUserManual.Click += btnUserManual_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel2.BackgroundImage = Properties.Resources.logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 80);
            panel2.TabIndex = 0;
            // 
            // trackbar
            // 
            trackbar.Location = new Point(527, 28);
            trackbar.Maximum = 15;
            trackbar.Minimum = 5;
            trackbar.Name = "trackbar";
            trackbar.Size = new Size(528, 69);
            trackbar.TabIndex = 10;
            trackbar.Value = 10;
            trackbar.Scroll += trackbar_Scroll;
            // 
            // Videos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 34);
            ClientSize = new Size(1117, 450);
            Controls.Add(trackbar);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnVideoState);
            Controls.Add(cbFilters);
            Controls.Add(btnLoadVideo);
            Controls.Add(pbVideo);
            Name = "Videos";
            Text = "Videos";
            FormClosing += Videos_FormClosing;
            Load += Videos_Load;
            ((System.ComponentModel.ISupportInitialize)pbVideo).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVideo;
        private Button btnLoadVideo;
        private ComboBox cbFilters;
        private Button btnVideoState;
        private Label label1;
        private Panel panel1;
        private Button btnRecognition;
        private Button btnVideos;
        private Button btnImages;
        private Button btnUserManual;
        private Panel panel2;
        private Button btnCount;
        private TrackBar trackbar;
    }
}