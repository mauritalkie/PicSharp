namespace IP_Project
{
    partial class Images
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
            pbOriginImage = new PictureBox();
            pbFilteredImage = new PictureBox();
            btnOriginHistogram = new Button();
            btnFilteredHistogram = new Button();
            btnLoadImage = new Button();
            btnSaveImage = new Button();
            cbFilters = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            btnCount = new Button();
            btnRecognition = new Button();
            btnVideos = new Button();
            btnImages = new Button();
            btnUserManual = new Button();
            panel2 = new Panel();
            label2 = new Label();
            groupBox1 = new GroupBox();
            tbClusters = new TrackBar();
            tbBlue = new TrackBar();
            tbGreen = new TrackBar();
            tbRed = new TrackBar();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbOriginImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFilteredImage).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbClusters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).BeginInit();
            SuspendLayout();
            // 
            // pbOriginImage
            // 
            pbOriginImage.BackColor = SystemColors.ActiveBorder;
            pbOriginImage.BorderStyle = BorderStyle.FixedSingle;
            pbOriginImage.Location = new Point(261, 98);
            pbOriginImage.Name = "pbOriginImage";
            pbOriginImage.Size = new Size(300, 300);
            pbOriginImage.TabIndex = 0;
            pbOriginImage.TabStop = false;
            // 
            // pbFilteredImage
            // 
            pbFilteredImage.BackColor = SystemColors.ActiveBorder;
            pbFilteredImage.BorderStyle = BorderStyle.FixedSingle;
            pbFilteredImage.Location = new Point(611, 98);
            pbFilteredImage.Name = "pbFilteredImage";
            pbFilteredImage.Size = new Size(300, 300);
            pbFilteredImage.TabIndex = 0;
            pbFilteredImage.TabStop = false;
            // 
            // btnOriginHistogram
            // 
            btnOriginHistogram.BackColor = Color.Navy;
            btnOriginHistogram.FlatAppearance.BorderSize = 0;
            btnOriginHistogram.FlatStyle = FlatStyle.Flat;
            btnOriginHistogram.ForeColor = Color.Gainsboro;
            btnOriginHistogram.Location = new Point(445, 404);
            btnOriginHistogram.Name = "btnOriginHistogram";
            btnOriginHistogram.Size = new Size(116, 34);
            btnOriginHistogram.TabIndex = 2;
            btnOriginHistogram.Text = "Histograma";
            btnOriginHistogram.UseVisualStyleBackColor = false;
            btnOriginHistogram.Click += btnOriginHistogram_Click;
            // 
            // btnFilteredHistogram
            // 
            btnFilteredHistogram.BackColor = Color.Navy;
            btnFilteredHistogram.FlatAppearance.BorderSize = 0;
            btnFilteredHistogram.FlatStyle = FlatStyle.Flat;
            btnFilteredHistogram.ForeColor = Color.Gainsboro;
            btnFilteredHistogram.Location = new Point(795, 404);
            btnFilteredHistogram.Name = "btnFilteredHistogram";
            btnFilteredHistogram.Size = new Size(116, 34);
            btnFilteredHistogram.TabIndex = 3;
            btnFilteredHistogram.Text = "Histograma";
            btnFilteredHistogram.UseVisualStyleBackColor = false;
            btnFilteredHistogram.Click += btnFilteredHistogram_Click;
            // 
            // btnLoadImage
            // 
            btnLoadImage.BackColor = Color.Navy;
            btnLoadImage.FlatAppearance.BorderSize = 0;
            btnLoadImage.FlatStyle = FlatStyle.Flat;
            btnLoadImage.ForeColor = Color.Gainsboro;
            btnLoadImage.Location = new Point(261, 404);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(112, 34);
            btnLoadImage.TabIndex = 4;
            btnLoadImage.Text = "Cargar";
            btnLoadImage.UseVisualStyleBackColor = false;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.BackColor = Color.Navy;
            btnSaveImage.FlatAppearance.BorderSize = 0;
            btnSaveImage.FlatStyle = FlatStyle.Flat;
            btnSaveImage.ForeColor = Color.Gainsboro;
            btnSaveImage.Location = new Point(611, 404);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(112, 34);
            btnSaveImage.TabIndex = 5;
            btnSaveImage.Text = "Guardar";
            btnSaveImage.UseVisualStyleBackColor = false;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // cbFilters
            // 
            cbFilters.FlatStyle = FlatStyle.Flat;
            cbFilters.FormattingEnabled = true;
            cbFilters.Location = new Point(648, 59);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(220, 33);
            cbFilters.TabIndex = 6;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(677, 31);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 7;
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
            panel1.TabIndex = 8;
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
            btnVideos.Dock = DockStyle.Top;
            btnVideos.FlatAppearance.BorderSize = 0;
            btnVideos.FlatStyle = FlatStyle.Flat;
            btnVideos.ForeColor = Color.Gainsboro;
            btnVideos.Location = new Point(0, 200);
            btnVideos.Name = "btnVideos";
            btnVideos.Size = new Size(220, 60);
            btnVideos.TabIndex = 7;
            btnVideos.Text = "Videos";
            btnVideos.UseVisualStyleBackColor = true;
            btnVideos.Click += btnVideos_Click;
            // 
            // btnImages
            // 
            btnImages.BackColor = Color.Navy;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(274, 44);
            label2.Name = "label2";
            label2.Size = new Size(278, 48);
            label2.TabIndex = 9;
            label2.Text = "Imagen sin filtro";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbClusters);
            groupBox1.Controls.Add(tbBlue);
            groupBox1.Controls.Add(tbGreen);
            groupBox1.Controls.Add(tbRed);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.Gainsboro;
            groupBox1.Location = new Point(956, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 426);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Herramientas";
            // 
            // tbClusters
            // 
            tbClusters.Location = new Point(6, 351);
            tbClusters.Maximum = 11;
            tbClusters.Minimum = 1;
            tbClusters.Name = "tbClusters";
            tbClusters.Size = new Size(234, 69);
            tbClusters.TabIndex = 8;
            tbClusters.Value = 6;
            tbClusters.Scroll += tbClusters_Scroll;
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
            label6.Size = new Size(142, 25);
            label6.TabIndex = 7;
            label6.Text = "Segmentaciones";
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
            // Images
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 34);
            ClientSize = new Size(1214, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(cbFilters);
            Controls.Add(btnSaveImage);
            Controls.Add(btnLoadImage);
            Controls.Add(btnFilteredHistogram);
            Controls.Add(btnOriginHistogram);
            Controls.Add(pbFilteredImage);
            Controls.Add(pbOriginImage);
            ForeColor = SystemColors.ControlText;
            Name = "Images";
            Text = "Imágenes";
            FormClosing += Images_FormClosing;
            Load += Images_Load;
            ((System.ComponentModel.ISupportInitialize)pbOriginImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFilteredImage).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbClusters).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbOriginImage;
        private PictureBox pbFilteredImage;
        private Button btnOriginHistogram;
        private Button btnFilteredHistogram;
        private Button btnLoadImage;
        private Button btnSaveImage;
        private ComboBox cbFilters;
        private Label label1;
        private Panel panel1;
        private Button btnRecognition;
        private Button btnVideos;
        private Button btnImages;
        private Button btnUserManual;
        private Panel panel2;
        private Label label2;
        private Button btnCount;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TrackBar tbRed;
        private TrackBar tbClusters;
        private TrackBar tbBlue;
        private TrackBar tbGreen;
    }
}