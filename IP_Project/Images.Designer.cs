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
            btnRecognition = new Button();
            btnVideos = new Button();
            btnImages = new Button();
            btnUserManual = new Button();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbOriginImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFilteredImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbOriginImage
            // 
            pbOriginImage.BackColor = SystemColors.ActiveBorder;
            pbOriginImage.BorderStyle = BorderStyle.FixedSingle;
            pbOriginImage.Location = new Point(283, 80);
            pbOriginImage.Name = "pbOriginImage";
            pbOriginImage.Size = new Size(300, 300);
            pbOriginImage.TabIndex = 0;
            pbOriginImage.TabStop = false;
            // 
            // pbFilteredImage
            // 
            pbFilteredImage.BackColor = SystemColors.ActiveBorder;
            pbFilteredImage.BorderStyle = BorderStyle.FixedSingle;
            pbFilteredImage.Location = new Point(672, 80);
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
            btnOriginHistogram.Location = new Point(467, 386);
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
            btnFilteredHistogram.Location = new Point(856, 386);
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
            btnLoadImage.Location = new Point(283, 386);
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
            btnSaveImage.Location = new Point(672, 386);
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
            cbFilters.Location = new Point(709, 41);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(214, 33);
            cbFilters.TabIndex = 6;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(738, 13);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 7;
            label1.Text = "Seleccione un filtro";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
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
            label2.Location = new Point(360, 26);
            label2.Name = "label2";
            label2.Size = new Size(129, 48);
            label2.TabIndex = 9;
            label2.Text = "Origen";
            // 
            // Images
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(995, 450);
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
    }
}