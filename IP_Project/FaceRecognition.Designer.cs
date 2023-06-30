namespace IP_Project
{
    partial class FaceRecognition
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
            pbCapture = new PictureBox();
            txtPersonName = new TextBox();
            btnAddPerson = new Button();
            pbCaptured = new PictureBox();
            btnSave = new Button();
            cbDetectFace = new CheckBox();
            cbTrainImage = new CheckBox();
            label1 = new Label();
            cbActivateCamera = new CheckBox();
            panel1 = new Panel();
            btnRecognition = new Button();
            btnVideos = new Button();
            btnImages = new Button();
            btnUserManual = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbCapture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCaptured).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbCapture
            // 
            pbCapture.BackColor = SystemColors.ActiveBorder;
            pbCapture.BorderStyle = BorderStyle.FixedSingle;
            pbCapture.Location = new Point(260, 71);
            pbCapture.Name = "pbCapture";
            pbCapture.Size = new Size(609, 327);
            pbCapture.TabIndex = 0;
            pbCapture.TabStop = false;
            // 
            // txtPersonName
            // 
            txtPersonName.Location = new Point(875, 287);
            txtPersonName.Name = "txtPersonName";
            txtPersonName.Size = new Size(161, 31);
            txtPersonName.TabIndex = 2;
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackColor = Color.Navy;
            btnAddPerson.FlatAppearance.BorderSize = 0;
            btnAddPerson.FlatStyle = FlatStyle.Flat;
            btnAddPerson.ForeColor = Color.Gainsboro;
            btnAddPerson.Location = new Point(875, 338);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(161, 34);
            btnAddPerson.TabIndex = 1;
            btnAddPerson.Text = "Agregar persona";
            btnAddPerson.UseVisualStyleBackColor = false;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // pbCaptured
            // 
            pbCaptured.BackColor = SystemColors.ActiveBorder;
            pbCaptured.BorderStyle = BorderStyle.FixedSingle;
            pbCaptured.Location = new Point(886, 93);
            pbCaptured.Name = "pbCaptured";
            pbCaptured.Size = new Size(150, 150);
            pbCaptured.TabIndex = 3;
            pbCaptured.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Navy;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Gainsboro;
            btnSave.Location = new Point(511, 404);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbDetectFace
            // 
            cbDetectFace.AutoSize = true;
            cbDetectFace.FlatAppearance.BorderSize = 0;
            cbDetectFace.FlatStyle = FlatStyle.Flat;
            cbDetectFace.ForeColor = Color.Gainsboro;
            cbDetectFace.Location = new Point(511, 36);
            cbDetectFace.Name = "cbDetectFace";
            cbDetectFace.Size = new Size(168, 29);
            cbDetectFace.TabIndex = 7;
            cbDetectFace.Text = "Activar detección";
            cbDetectFace.UseVisualStyleBackColor = true;
            cbDetectFace.CheckedChanged += cbDetectFace_CheckedChanged;
            // 
            // cbTrainImage
            // 
            cbTrainImage.AutoSize = true;
            cbTrainImage.FlatAppearance.BorderSize = 0;
            cbTrainImage.FlatStyle = FlatStyle.Flat;
            cbTrainImage.ForeColor = Color.Gainsboro;
            cbTrainImage.Location = new Point(742, 36);
            cbTrainImage.Name = "cbTrainImage";
            cbTrainImage.Size = new Size(215, 29);
            cbTrainImage.TabIndex = 8;
            cbTrainImage.Text = "Activar reconocimiento";
            cbTrainImage.UseVisualStyleBackColor = true;
            cbTrainImage.CheckedChanged += cbTrainImage_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(918, 259);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // cbActivateCamera
            // 
            cbActivateCamera.AutoSize = true;
            cbActivateCamera.FlatAppearance.BorderSize = 0;
            cbActivateCamera.FlatStyle = FlatStyle.Flat;
            cbActivateCamera.ForeColor = Color.LightGray;
            cbActivateCamera.Location = new Point(298, 36);
            cbActivateCamera.Name = "cbActivateCamera";
            cbActivateCamera.Size = new Size(149, 29);
            cbActivateCamera.TabIndex = 10;
            cbActivateCamera.Text = "Activar cámara";
            cbActivateCamera.UseVisualStyleBackColor = true;
            cbActivateCamera.CheckedChanged += cbActivateCamera_CheckedChanged;
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
            panel1.TabIndex = 11;
            // 
            // btnRecognition
            // 
            btnRecognition.BackColor = Color.Navy;
            btnRecognition.Dock = DockStyle.Top;
            btnRecognition.FlatAppearance.BorderSize = 0;
            btnRecognition.FlatStyle = FlatStyle.Flat;
            btnRecognition.ForeColor = Color.Gainsboro;
            btnRecognition.Location = new Point(0, 260);
            btnRecognition.Name = "btnRecognition";
            btnRecognition.Size = new Size(220, 60);
            btnRecognition.TabIndex = 8;
            btnRecognition.Text = "Reconocimiento";
            btnRecognition.UseVisualStyleBackColor = false;
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
            // FaceRecognition
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1070, 450);
            Controls.Add(panel1);
            Controls.Add(cbActivateCamera);
            Controls.Add(label1);
            Controls.Add(cbTrainImage);
            Controls.Add(cbDetectFace);
            Controls.Add(btnSave);
            Controls.Add(pbCaptured);
            Controls.Add(txtPersonName);
            Controls.Add(btnAddPerson);
            Controls.Add(pbCapture);
            Name = "FaceRecognition";
            Text = "FaceRecognition";
            FormClosing += FaceRecognition_FormClosing;
            Load += FaceRecognition_Load;
            ((System.ComponentModel.ISupportInitialize)pbCapture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCaptured).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCapture;
        private TextBox txtPersonName;
        private Button btnAddPerson;
        private PictureBox pbCaptured;
        private Button btnSave;
        private CheckBox cbDetectFace;
        private CheckBox cbTrainImage;
        private Label label1;
        private CheckBox cbActivateCamera;
        private Panel panel1;
        private Button btnRecognition;
        private Button btnVideos;
        private Button btnImages;
        private Button btnUserManual;
        private Panel panel2;
    }
}