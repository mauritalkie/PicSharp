namespace IP_Project
{
    partial class FaceCount
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
            pbDisplay = new PictureBox();
            cbDevices = new ComboBox();
            btnLoadImage = new Button();
            rbCamera = new RadioButton();
            rbImage = new RadioButton();
            lblDetectedFaces = new Label();
            btnCameraState = new Button();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnCount = new Button();
            btnRecognition = new Button();
            btnVideos = new Button();
            btnImages = new Button();
            btnUserManual = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbDisplay).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbDisplay
            // 
            pbDisplay.BackColor = SystemColors.ActiveBorder;
            pbDisplay.BorderStyle = BorderStyle.FixedSingle;
            pbDisplay.Location = new Point(245, 12);
            pbDisplay.Name = "pbDisplay";
            pbDisplay.Size = new Size(543, 338);
            pbDisplay.TabIndex = 0;
            pbDisplay.TabStop = false;
            // 
            // cbDevices
            // 
            cbDevices.FlatStyle = FlatStyle.Flat;
            cbDevices.FormattingEnabled = true;
            cbDevices.Location = new Point(794, 186);
            cbDevices.Name = "cbDevices";
            cbDevices.Size = new Size(186, 33);
            cbDevices.TabIndex = 1;
            cbDevices.SelectedIndexChanged += cbDevices_SelectedIndexChanged;
            // 
            // btnLoadImage
            // 
            btnLoadImage.BackColor = Color.Navy;
            btnLoadImage.FlatAppearance.BorderSize = 0;
            btnLoadImage.FlatStyle = FlatStyle.Flat;
            btnLoadImage.ForeColor = Color.Gainsboro;
            btnLoadImage.Location = new Point(607, 356);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(112, 34);
            btnLoadImage.TabIndex = 2;
            btnLoadImage.Text = "Cargar";
            btnLoadImage.UseVisualStyleBackColor = false;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // rbCamera
            // 
            rbCamera.AutoSize = true;
            rbCamera.FlatAppearance.BorderSize = 0;
            rbCamera.FlatStyle = FlatStyle.Flat;
            rbCamera.ForeColor = Color.Gainsboro;
            rbCamera.Location = new Point(805, 40);
            rbCamera.Name = "rbCamera";
            rbCamera.Size = new Size(95, 29);
            rbCamera.TabIndex = 3;
            rbCamera.TabStop = true;
            rbCamera.Text = "Cámara";
            rbCamera.UseVisualStyleBackColor = true;
            rbCamera.CheckedChanged += rbCamera_CheckedChanged;
            // 
            // rbImage
            // 
            rbImage.AutoSize = true;
            rbImage.FlatAppearance.BorderSize = 0;
            rbImage.FlatStyle = FlatStyle.Flat;
            rbImage.ForeColor = Color.Gainsboro;
            rbImage.Location = new Point(805, 75);
            rbImage.Name = "rbImage";
            rbImage.Size = new Size(95, 29);
            rbImage.TabIndex = 4;
            rbImage.TabStop = true;
            rbImage.Text = "Imágen";
            rbImage.UseVisualStyleBackColor = true;
            rbImage.CheckedChanged += rbImage_CheckedChanged;
            // 
            // lblDetectedFaces
            // 
            lblDetectedFaces.AutoSize = true;
            lblDetectedFaces.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDetectedFaces.ForeColor = Color.Gainsboro;
            lblDetectedFaces.Location = new Point(329, 393);
            lblDetectedFaces.Name = "lblDetectedFaces";
            lblDetectedFaces.Size = new Size(390, 48);
            lblDetectedFaces.TabIndex = 5;
            lblDetectedFaces.Text = "Número de personas: 0";
            // 
            // btnCameraState
            // 
            btnCameraState.BackColor = Color.Navy;
            btnCameraState.FlatAppearance.BorderSize = 0;
            btnCameraState.FlatStyle = FlatStyle.Flat;
            btnCameraState.ForeColor = Color.Gainsboro;
            btnCameraState.Location = new Point(319, 356);
            btnCameraState.Name = "btnCameraState";
            btnCameraState.Size = new Size(112, 34);
            btnCameraState.TabIndex = 6;
            btnCameraState.Text = "Encender";
            btnCameraState.UseVisualStyleBackColor = false;
            btnCameraState.Click += btnCameraState_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(805, 158);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 7;
            label3.Text = "Elige un dispositivo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(805, 12);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 7;
            label1.Text = "Elige una opción";
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
            btnCount.BackColor = Color.Navy;
            btnCount.Dock = DockStyle.Top;
            btnCount.FlatAppearance.BorderSize = 0;
            btnCount.FlatStyle = FlatStyle.Flat;
            btnCount.ForeColor = Color.Gainsboro;
            btnCount.Location = new Point(0, 320);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(220, 60);
            btnCount.TabIndex = 9;
            btnCount.Text = "Conteo";
            btnCount.UseVisualStyleBackColor = false;
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
            // FaceCount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 34);
            ClientSize = new Size(992, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnCameraState);
            Controls.Add(lblDetectedFaces);
            Controls.Add(rbImage);
            Controls.Add(rbCamera);
            Controls.Add(btnLoadImage);
            Controls.Add(cbDevices);
            Controls.Add(pbDisplay);
            Name = "FaceCount";
            Text = "Conteo";
            FormClosing += FaceCount_FormClosing;
            Load += FaceCount_Load;
            ((System.ComponentModel.ISupportInitialize)pbDisplay).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbDisplay;
        private ComboBox cbDevices;
        private Button btnLoadImage;
        private RadioButton rbCamera;
        private RadioButton rbImage;
        private Label lblDetectedFaces;
        private Button btnCameraState;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Button btnRecognition;
        private Button btnVideos;
        private Button btnImages;
        private Button btnUserManual;
        private Panel panel2;
        private Button btnCount;
    }
}