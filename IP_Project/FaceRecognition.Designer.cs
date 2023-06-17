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
            btnCapture = new Button();
            btnDetectFace = new Button();
            txtPersonName = new TextBox();
            btnAddPerson = new Button();
            btnTrainImage = new Button();
            btnRecognizePerson = new Button();
            pbCaptured = new PictureBox();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCapture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCaptured).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbCapture
            // 
            pbCapture.Location = new Point(12, 12);
            pbCapture.Name = "pbCapture";
            pbCapture.Size = new Size(609, 594);
            pbCapture.TabIndex = 0;
            pbCapture.TabStop = false;
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(689, 12);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(161, 34);
            btnCapture.TabIndex = 1;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // btnDetectFace
            // 
            btnDetectFace.Location = new Point(689, 52);
            btnDetectFace.Name = "btnDetectFace";
            btnDetectFace.Size = new Size(161, 34);
            btnDetectFace.TabIndex = 1;
            btnDetectFace.Text = "Detect face";
            btnDetectFace.UseVisualStyleBackColor = true;
            btnDetectFace.Click += btnDetectFace_Click;
            // 
            // txtPersonName
            // 
            txtPersonName.Location = new Point(689, 287);
            txtPersonName.Name = "txtPersonName";
            txtPersonName.Size = new Size(161, 31);
            txtPersonName.TabIndex = 2;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(689, 92);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(161, 34);
            btnAddPerson.TabIndex = 1;
            btnAddPerson.Text = "Add person";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // btnTrainImage
            // 
            btnTrainImage.Location = new Point(689, 364);
            btnTrainImage.Name = "btnTrainImage";
            btnTrainImage.Size = new Size(161, 34);
            btnTrainImage.TabIndex = 1;
            btnTrainImage.Text = "Train Image";
            btnTrainImage.UseVisualStyleBackColor = true;
            btnTrainImage.Click += btnTrainImage_Click;
            // 
            // btnRecognizePerson
            // 
            btnRecognizePerson.Location = new Point(689, 404);
            btnRecognizePerson.Name = "btnRecognizePerson";
            btnRecognizePerson.Size = new Size(161, 34);
            btnRecognizePerson.TabIndex = 1;
            btnRecognizePerson.Text = "Recognize person";
            btnRecognizePerson.UseVisualStyleBackColor = true;
            // 
            // pbCaptured
            // 
            pbCaptured.Location = new Point(689, 129);
            pbCaptured.Name = "pbCaptured";
            pbCaptured.Size = new Size(161, 152);
            pbCaptured.TabIndex = 3;
            pbCaptured.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(689, 324);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(627, 444);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 162);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(764, 444);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(131, 162);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // FaceRecognition
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 618);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(pbCaptured);
            Controls.Add(txtPersonName);
            Controls.Add(btnRecognizePerson);
            Controls.Add(btnTrainImage);
            Controls.Add(btnAddPerson);
            Controls.Add(btnDetectFace);
            Controls.Add(btnCapture);
            Controls.Add(pbCapture);
            Name = "FaceRecognition";
            Text = "FaceRecognition";
            ((System.ComponentModel.ISupportInitialize)pbCapture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCaptured).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCapture;
        private Button btnCapture;
        private Button btnDetectFace;
        private TextBox txtPersonName;
        private Button btnAddPerson;
        private Button btnTrainImage;
        private Button btnRecognizePerson;
        private PictureBox pbCaptured;
        private Button btnSave;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}