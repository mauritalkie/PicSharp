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
            groupBox1 = new GroupBox();
            tbBlue = new TrackBar();
            tbGreen = new TrackBar();
            tbRed = new TrackBar();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbVideo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackbar).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).BeginInit();
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
            trackbar.Location = new Point(6, 351);
            trackbar.Maximum = 15;
            trackbar.Minimum = 5;
            trackbar.Name = "trackbar";
            trackbar.Size = new Size(234, 69);
            trackbar.TabIndex = 10;
            trackbar.Value = 10;
            trackbar.Scroll += trackbar_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbBlue);
            groupBox1.Controls.Add(trackbar);
            groupBox1.Controls.Add(tbGreen);
            groupBox1.Controls.Add(tbRed);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.Gainsboro;
            groupBox1.Location = new Point(1086, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 426);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Herramientas";
            // 
            // tbBlue
            // 
            tbBlue.Location = new Point(156, 55);
            tbBlue.Name = "tbBlue";
            tbBlue.Orientation = Orientation.Vertical;
            tbBlue.Size = new Size(69, 265);
            tbBlue.TabIndex = 8;
            tbBlue.Value = 5;
            tbBlue.Scroll += tbBlue_Scroll;
            // 
            // tbGreen
            // 
            tbGreen.Location = new Point(81, 55);
            tbGreen.Name = "tbGreen";
            tbGreen.Orientation = Orientation.Vertical;
            tbGreen.Size = new Size(69, 265);
            tbGreen.TabIndex = 8;
            tbGreen.Value = 5;
            tbGreen.Scroll += tbGreen_Scroll;
            // 
            // tbRed
            // 
            tbRed.Location = new Point(6, 55);
            tbRed.Name = "tbRed";
            tbRed.Orientation = Orientation.Vertical;
            tbRed.Size = new Size(69, 265);
            tbRed.TabIndex = 8;
            tbRed.Value = 5;
            tbRed.Scroll += tbRed_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(54, 323);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 7;
            label6.Text = "Brillo / Contraste";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(156, 27);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 7;
            label5.Text = "Azul";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(6, 27);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 7;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(81, 27);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 7;
            label4.Text = "Verde";
            // 
            // Videos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 34);
            ClientSize = new Size(1344, 450);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).EndInit();
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
        private GroupBox groupBox1;
        private TrackBar tbBlue;
        private TrackBar tbGreen;
        private TrackBar tbRed;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
    }
}