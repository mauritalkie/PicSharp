﻿namespace IP_Project
{
    partial class UserManual
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
            pbPreview = new PictureBox();
            btnPrev = new Button();
            btnNext = new Button();
            panel1 = new Panel();
            btnCount = new Button();
            btnRecognition = new Button();
            btnVideos = new Button();
            btnImages = new Button();
            btnUserManual = new Button();
            panel2 = new Panel();
            lblInfo = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPreview).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbPreview
            // 
            pbPreview.BackColor = SystemColors.ActiveBorder;
            pbPreview.BorderStyle = BorderStyle.FixedSingle;
            pbPreview.Location = new Point(267, 84);
            pbPreview.Name = "pbPreview";
            pbPreview.Size = new Size(924, 365);
            pbPreview.TabIndex = 1;
            pbPreview.TabStop = false;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Navy;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.ForeColor = Color.Gainsboro;
            btnPrev.Location = new Point(369, 537);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(112, 34);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "Anterior";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Navy;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = Color.Gainsboro;
            btnNext.Location = new Point(981, 537);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 34);
            btnNext.TabIndex = 3;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
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
            panel1.Size = new Size(220, 583);
            panel1.TabIndex = 4;
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
            btnImages.Dock = DockStyle.Top;
            btnImages.FlatAppearance.BorderSize = 0;
            btnImages.FlatStyle = FlatStyle.Flat;
            btnImages.ForeColor = Color.Gainsboro;
            btnImages.Location = new Point(0, 140);
            btnImages.Name = "btnImages";
            btnImages.Size = new Size(220, 60);
            btnImages.TabIndex = 6;
            btnImages.Text = "Imágenes";
            btnImages.UseVisualStyleBackColor = true;
            btnImages.Click += btnImages_Click;
            // 
            // btnUserManual
            // 
            btnUserManual.BackColor = Color.Navy;
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
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.Gainsboro;
            lblInfo.Location = new Point(267, 452);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(59, 25);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(348, 9);
            label1.Name = "label1";
            label1.Size = new Size(769, 72);
            label1.TabIndex = 6;
            label1.Text = "Manual de usuario de PicSharp";
            // 
            // UserManual
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 34);
            ClientSize = new Size(1242, 583);
            Controls.Add(label1);
            Controls.Add(lblInfo);
            Controls.Add(panel1);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(pbPreview);
            Name = "UserManual";
            Text = "Manual de usuario";
            FormClosing += UserManual_FormClosing;
            Load += UserManual_Load;
            ((System.ComponentModel.ISupportInitialize)pbPreview).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbPreview;
        private Button btnPrev;
        private Button btnNext;
        private Panel panel1;
        private Panel panel2;
        private Button btnUserManual;
        private Button btnRecognition;
        private Button btnVideos;
        private Button btnImages;
        private Button btnCount;
        private Label lblInfo;
        private Label label1;
    }
}