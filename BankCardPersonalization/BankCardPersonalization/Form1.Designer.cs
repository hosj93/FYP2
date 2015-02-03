namespace BankCardPersonalization
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImgSelectPanel = new System.Windows.Forms.Panel();
            this.btnImgRandom = new System.Windows.Forms.Button();
            this.buttonSelectImg = new System.Windows.Forms.Button();
            this.gBoxStepOne = new System.Windows.Forms.GroupBox();
            this.labelInstructOne = new System.Windows.Forms.Label();
            this.grpSelectedImg = new System.Windows.Forms.GroupBox();
            this.selectedImageBox = new System.Windows.Forms.PictureBox();
            this.panelImgGallery = new System.Windows.Forms.Panel();
            this.listViewGallery = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelImgGallery = new System.Windows.Forms.Label();
            this.lblTimerSec = new System.Windows.Forms.Label();
            this.lblDotTwo = new System.Windows.Forms.Label();
            this.lblTimerMin = new System.Windows.Forms.Label();
            this.lblDotOne = new System.Windows.Forms.Label();
            this.lblTimerHour = new System.Windows.Forms.Label();
            this.btnImgProNext = new System.Windows.Forms.Button();
            this.buttonImgGallery = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.ImgSelectPanel.SuspendLayout();
            this.gBoxStepOne.SuspendLayout();
            this.grpSelectedImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedImageBox)).BeginInit();
            this.panelImgGallery.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgSelectPanel
            // 
            this.ImgSelectPanel.BackColor = System.Drawing.Color.Silver;
            this.ImgSelectPanel.Controls.Add(this.btnImgRandom);
            this.ImgSelectPanel.Controls.Add(this.buttonSelectImg);
            this.ImgSelectPanel.Controls.Add(this.gBoxStepOne);
            this.ImgSelectPanel.Controls.Add(this.grpSelectedImg);
            this.ImgSelectPanel.Controls.Add(this.panelImgGallery);
            this.ImgSelectPanel.Controls.Add(this.lblTimerSec);
            this.ImgSelectPanel.Controls.Add(this.lblDotTwo);
            this.ImgSelectPanel.Controls.Add(this.lblTimerMin);
            this.ImgSelectPanel.Controls.Add(this.lblDotOne);
            this.ImgSelectPanel.Controls.Add(this.lblTimerHour);
            this.ImgSelectPanel.Controls.Add(this.btnImgProNext);
            this.ImgSelectPanel.Controls.Add(this.buttonImgGallery);
            this.ImgSelectPanel.Controls.Add(this.menuStrip1);
            this.ImgSelectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.ImgSelectPanel.Name = "ImgSelectPanel";
            this.ImgSelectPanel.Size = new System.Drawing.Size(1122, 835);
            this.ImgSelectPanel.TabIndex = 0;
            // 
            // btnImgRandom
            // 
            this.btnImgRandom.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnImgRandom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImgRandom.BackgroundImage")));
            this.btnImgRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImgRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImgRandom.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnImgRandom.Location = new System.Drawing.Point(69, 269);
            this.btnImgRandom.Name = "btnImgRandom";
            this.btnImgRandom.Size = new System.Drawing.Size(239, 104);
            this.btnImgRandom.TabIndex = 13;
            this.btnImgRandom.Text = "Random Photo";
            this.btnImgRandom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImgRandom.UseVisualStyleBackColor = false;
            this.btnImgRandom.Click += new System.EventHandler(this.btnImgRandom_Click);
            // 
            // buttonSelectImg
            // 
            this.buttonSelectImg.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSelectImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSelectImg.BackgroundImage")));
            this.buttonSelectImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSelectImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectImg.ForeColor = System.Drawing.Color.Crimson;
            this.buttonSelectImg.Location = new System.Drawing.Point(69, 607);
            this.buttonSelectImg.Name = "buttonSelectImg";
            this.buttonSelectImg.Size = new System.Drawing.Size(239, 104);
            this.buttonSelectImg.TabIndex = 0;
            this.buttonSelectImg.Text = "Upload Your Image";
            this.buttonSelectImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSelectImg.UseVisualStyleBackColor = false;
            this.buttonSelectImg.Click += new System.EventHandler(this.buttonSelectImg_Click);
            // 
            // gBoxStepOne
            // 
            this.gBoxStepOne.Controls.Add(this.labelInstructOne);
            this.gBoxStepOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxStepOne.Location = new System.Drawing.Point(69, 31);
            this.gBoxStepOne.Name = "gBoxStepOne";
            this.gBoxStepOne.Size = new System.Drawing.Size(777, 195);
            this.gBoxStepOne.TabIndex = 12;
            this.gBoxStepOne.TabStop = false;
            this.gBoxStepOne.Text = "Step 1 :";
            // 
            // labelInstructOne
            // 
            this.labelInstructOne.AutoSize = true;
            this.labelInstructOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructOne.Location = new System.Drawing.Point(6, 30);
            this.labelInstructOne.Name = "labelInstructOne";
            this.labelInstructOne.Size = new System.Drawing.Size(87, 20);
            this.labelInstructOne.TabIndex = 0;
            this.labelInstructOne.Text = "Instruction";
            // 
            // grpSelectedImg
            // 
            this.grpSelectedImg.Controls.Add(this.selectedImageBox);
            this.grpSelectedImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectedImg.Location = new System.Drawing.Point(421, 269);
            this.grpSelectedImg.Name = "grpSelectedImg";
            this.grpSelectedImg.Size = new System.Drawing.Size(663, 447);
            this.grpSelectedImg.TabIndex = 11;
            this.grpSelectedImg.TabStop = false;
            this.grpSelectedImg.Text = "Selected Image :";
            // 
            // selectedImageBox
            // 
            this.selectedImageBox.Location = new System.Drawing.Point(16, 69);
            this.selectedImageBox.Name = "selectedImageBox";
            this.selectedImageBox.Size = new System.Drawing.Size(637, 373);
            this.selectedImageBox.TabIndex = 2;
            this.selectedImageBox.TabStop = false;
            this.selectedImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPaint);
            // 
            // panelImgGallery
            // 
            this.panelImgGallery.Controls.Add(this.listViewGallery);
            this.panelImgGallery.Controls.Add(this.labelImgGallery);
            this.panelImgGallery.Location = new System.Drawing.Point(421, 269);
            this.panelImgGallery.Name = "panelImgGallery";
            this.panelImgGallery.Size = new System.Drawing.Size(663, 447);
            this.panelImgGallery.TabIndex = 4;
            // 
            // listViewGallery
            // 
            this.listViewGallery.FullRowSelect = true;
            this.listViewGallery.LargeImageList = this.imageList1;
            this.listViewGallery.Location = new System.Drawing.Point(23, 69);
            this.listViewGallery.Name = "listViewGallery";
            this.listViewGallery.Size = new System.Drawing.Size(620, 395);
            this.listViewGallery.TabIndex = 1;
            this.listViewGallery.UseCompatibleStateImageBehavior = false;
            this.listViewGallery.DoubleClick += new System.EventHandler(this.listViewGallery_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "airplane.jpg");
            this.imageList1.Images.SetKeyName(1, "hardrock.jpg");
            this.imageList1.Images.SetKeyName(2, "linux.png");
            this.imageList1.Images.SetKeyName(3, "maybank.jpg");
            this.imageList1.Images.SetKeyName(4, "tiger.jpg");
            // 
            // labelImgGallery
            // 
            this.labelImgGallery.AutoSize = true;
            this.labelImgGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImgGallery.ForeColor = System.Drawing.Color.Blue;
            this.labelImgGallery.Location = new System.Drawing.Point(19, 14);
            this.labelImgGallery.Name = "labelImgGallery";
            this.labelImgGallery.Size = new System.Drawing.Size(144, 24);
            this.labelImgGallery.TabIndex = 0;
            this.labelImgGallery.Text = "Image Gallery ";
            // 
            // lblTimerSec
            // 
            this.lblTimerSec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerSec.AutoSize = true;
            this.lblTimerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerSec.Location = new System.Drawing.Point(1035, 94);
            this.lblTimerSec.Name = "lblTimerSec";
            this.lblTimerSec.Size = new System.Drawing.Size(49, 32);
            this.lblTimerSec.TabIndex = 9;
            this.lblTimerSec.Text = "00";
            // 
            // lblDotTwo
            // 
            this.lblDotTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDotTwo.AutoSize = true;
            this.lblDotTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDotTwo.Location = new System.Drawing.Point(1005, 90);
            this.lblDotTwo.Name = "lblDotTwo";
            this.lblDotTwo.Size = new System.Drawing.Size(24, 36);
            this.lblDotTwo.TabIndex = 8;
            this.lblDotTwo.Text = ":";
            // 
            // lblTimerMin
            // 
            this.lblTimerMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerMin.AutoSize = true;
            this.lblTimerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerMin.Location = new System.Drawing.Point(950, 93);
            this.lblTimerMin.Name = "lblTimerMin";
            this.lblTimerMin.Size = new System.Drawing.Size(49, 32);
            this.lblTimerMin.TabIndex = 7;
            this.lblTimerMin.Text = "00";
            // 
            // lblDotOne
            // 
            this.lblDotOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDotOne.AutoSize = true;
            this.lblDotOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDotOne.Location = new System.Drawing.Point(920, 91);
            this.lblDotOne.Name = "lblDotOne";
            this.lblDotOne.Size = new System.Drawing.Size(24, 36);
            this.lblDotOne.TabIndex = 6;
            this.lblDotOne.Text = ":";
            // 
            // lblTimerHour
            // 
            this.lblTimerHour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerHour.AutoSize = true;
            this.lblTimerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerHour.Location = new System.Drawing.Point(865, 93);
            this.lblTimerHour.Name = "lblTimerHour";
            this.lblTimerHour.Size = new System.Drawing.Size(49, 32);
            this.lblTimerHour.TabIndex = 5;
            this.lblTimerHour.Text = "00";
            // 
            // btnImgProNext
            // 
            this.btnImgProNext.Location = new System.Drawing.Point(981, 762);
            this.btnImgProNext.Name = "btnImgProNext";
            this.btnImgProNext.Size = new System.Drawing.Size(103, 44);
            this.btnImgProNext.TabIndex = 2;
            this.btnImgProNext.Text = "Next";
            this.btnImgProNext.UseVisualStyleBackColor = true;
            this.btnImgProNext.Click += new System.EventHandler(this.btnImgProNext_Click);
            // 
            // buttonImgGallery
            // 
            this.buttonImgGallery.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonImgGallery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImgGallery.BackgroundImage")));
            this.buttonImgGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonImgGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImgGallery.ForeColor = System.Drawing.Color.Purple;
            this.buttonImgGallery.Location = new System.Drawing.Point(69, 440);
            this.buttonImgGallery.Name = "buttonImgGallery";
            this.buttonImgGallery.Size = new System.Drawing.Size(239, 104);
            this.buttonImgGallery.TabIndex = 1;
            this.buttonImgGallery.Text = "Browse Gallery";
            this.buttonImgGallery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonImgGallery.UseVisualStyleBackColor = false;
            this.buttonImgGallery.Click += new System.EventHandler(this.buttonImgGallery_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 1000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1122, 835);
            this.Controls.Add(this.ImgSelectPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Card Personalization";
            this.ImgSelectPanel.ResumeLayout(false);
            this.ImgSelectPanel.PerformLayout();
            this.gBoxStepOne.ResumeLayout(false);
            this.gBoxStepOne.PerformLayout();
            this.grpSelectedImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedImageBox)).EndInit();
            this.panelImgGallery.ResumeLayout(false);
            this.panelImgGallery.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ImgSelectPanel;
        private System.Windows.Forms.Button buttonImgGallery;
        private System.Windows.Forms.Button buttonSelectImg;
        private System.Windows.Forms.Panel panelImgGallery;
        private System.Windows.Forms.Label labelImgGallery;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listViewGallery;
        private System.Windows.Forms.Button btnImgProNext;
        private System.Windows.Forms.Label lblDotTwo;
        private System.Windows.Forms.Label lblTimerMin;
        private System.Windows.Forms.Label lblDotOne;
        private System.Windows.Forms.Label lblTimerHour;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.Label lblTimerSec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxStepOne;
        private System.Windows.Forms.Label labelInstructOne;
        private System.Windows.Forms.Button btnImgRandom;
        private System.Windows.Forms.GroupBox grpSelectedImg;
        private System.Windows.Forms.PictureBox selectedImageBox;
    }
}

