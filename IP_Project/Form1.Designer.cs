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
            ((System.ComponentModel.ISupportInitialize)pbDisplay).BeginInit();
            SuspendLayout();
            // 
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(150, 12);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(334, 33);
            cbCamera.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 1;
            label1.Text = "Camera:";
            // 
            // pbDisplay
            // 
            pbDisplay.Location = new Point(12, 51);
            pbDisplay.Name = "pbDisplay";
            pbDisplay.Size = new Size(593, 347);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 450);
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
    }
}