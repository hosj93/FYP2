namespace BankCardPersonalization
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gBoxStepTwo = new System.Windows.Forms.GroupBox();
            this.lblInstructTwo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.previewImgBox = new System.Windows.Forms.PictureBox();
            this.tabImageProcess = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewImgEffect = new System.Windows.Forms.ListView();
            this.imgGradient = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblImgBrightness = new System.Windows.Forms.Label();
            this.trcBrightness = new System.Windows.Forms.TrackBar();
            this.imageIconTab = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCartoonEffect = new System.Windows.Forms.ComboBox();
            this.lblCartoonEffect = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBrightnessTag = new System.Windows.Forms.Label();
            this.lblBrightnessValue = new System.Windows.Forms.Label();
            this.gBoxStepTwo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewImgBox)).BeginInit();
            this.tabImageProcess.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrightness)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxStepTwo
            // 
            this.gBoxStepTwo.Controls.Add(this.lblInstructTwo);
            this.gBoxStepTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxStepTwo.Location = new System.Drawing.Point(31, 22);
            this.gBoxStepTwo.Name = "gBoxStepTwo";
            this.gBoxStepTwo.Size = new System.Drawing.Size(626, 149);
            this.gBoxStepTwo.TabIndex = 0;
            this.gBoxStepTwo.TabStop = false;
            this.gBoxStepTwo.Text = "Step 2";
            // 
            // lblInstructTwo
            // 
            this.lblInstructTwo.AutoSize = true;
            this.lblInstructTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructTwo.Location = new System.Drawing.Point(6, 26);
            this.lblInstructTwo.Name = "lblInstructTwo";
            this.lblInstructTwo.Size = new System.Drawing.Size(87, 20);
            this.lblInstructTwo.TabIndex = 0;
            this.lblInstructTwo.Text = "Instruction";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.previewImgBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(275, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview Image";
            // 
            // previewImgBox
            // 
            this.previewImgBox.Location = new System.Drawing.Point(71, 52);
            this.previewImgBox.Name = "previewImgBox";
            this.previewImgBox.Size = new System.Drawing.Size(460, 236);
            this.previewImgBox.TabIndex = 0;
            this.previewImgBox.TabStop = false;
            // 
            // tabImageProcess
            // 
            this.tabImageProcess.Controls.Add(this.tabPage1);
            this.tabImageProcess.Controls.Add(this.tabPage2);
            this.tabImageProcess.ImageList = this.imageIconTab;
            this.tabImageProcess.Location = new System.Drawing.Point(275, 556);
            this.tabImageProcess.Multiline = true;
            this.tabImageProcess.Name = "tabImageProcess";
            this.tabImageProcess.SelectedIndex = 0;
            this.tabImageProcess.Size = new System.Drawing.Size(611, 155);
            this.tabImageProcess.TabIndex = 2;
            this.tabImageProcess.Click += new System.EventHandler(this.tabBrightness_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewImgEffect);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 126);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image Effect";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewImgEffect
            // 
            this.listViewImgEffect.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewImgEffect.FullRowSelect = true;
            this.listViewImgEffect.LargeImageList = this.imgGradient;
            this.listViewImgEffect.Location = new System.Drawing.Point(0, 0);
            this.listViewImgEffect.Name = "listViewImgEffect";
            this.listViewImgEffect.Size = new System.Drawing.Size(603, 120);
            this.listViewImgEffect.TabIndex = 0;
            this.listViewImgEffect.UseCompatibleStateImageBehavior = false;
            this.listViewImgEffect.Click += new System.EventHandler(this.listViewImgEffect_Click);
            // 
            // imgGradient
            // 
            this.imgGradient.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgGradient.ImageStream")));
            this.imgGradient.TransparentColor = System.Drawing.Color.Transparent;
            this.imgGradient.Images.SetKeyName(0, "GrayScale.png");
            this.imgGradient.Images.SetKeyName(1, "Inverse.png");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblBrightnessValue);
            this.tabPage2.Controls.Add(this.lblBrightnessTag);
            this.tabPage2.Controls.Add(this.lblImgBrightness);
            this.tabPage2.Controls.Add(this.trcBrightness);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 126);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Brightness";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblImgBrightness
            // 
            this.lblImgBrightness.AutoSize = true;
            this.lblImgBrightness.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgBrightness.Location = new System.Drawing.Point(160, 3);
            this.lblImgBrightness.Name = "lblImgBrightness";
            this.lblImgBrightness.Size = new System.Drawing.Size(144, 23);
            this.lblImgBrightness.TabIndex = 1;
            this.lblImgBrightness.Text = "lblImgBrightness";
            this.lblImgBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcBrightness
            // 
            this.trcBrightness.Location = new System.Drawing.Point(3, 29);
            this.trcBrightness.Maximum = 255;
            this.trcBrightness.Name = "trcBrightness";
            this.trcBrightness.Size = new System.Drawing.Size(594, 56);
            this.trcBrightness.TabIndex = 27;
            this.trcBrightness.TickFrequency = 10;
            this.trcBrightness.Scroll += new System.EventHandler(this.trcBrightness_Scroll);
            // 
            // imageIconTab
            // 
            this.imageIconTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIconTab.ImageStream")));
            this.imageIconTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIconTab.Images.SetKeyName(0, "effect.png");
            this.imageIconTab.Images.SetKeyName(1, "Brightness.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCartoonEffect);
            this.panel1.Controls.Add(this.lblCartoonEffect);
            this.panel1.Location = new System.Drawing.Point(926, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 74);
            this.panel1.TabIndex = 3;
            // 
            // cmbCartoonEffect
            // 
            this.cmbCartoonEffect.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbCartoonEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCartoonEffect.FormattingEnabled = true;
            this.cmbCartoonEffect.ItemHeight = 16;
            this.cmbCartoonEffect.Location = new System.Drawing.Point(8, 41);
            this.cmbCartoonEffect.Name = "cmbCartoonEffect";
            this.cmbCartoonEffect.Size = new System.Drawing.Size(270, 24);
            this.cmbCartoonEffect.TabIndex = 1;
            this.cmbCartoonEffect.SelectedIndexChanged += new System.EventHandler(this.FilterLevelChanged);
            // 
            // lblCartoonEffect
            // 
            this.lblCartoonEffect.AutoSize = true;
            this.lblCartoonEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartoonEffect.Location = new System.Drawing.Point(3, 13);
            this.lblCartoonEffect.Name = "lblCartoonEffect";
            this.lblCartoonEffect.Size = new System.Drawing.Size(261, 24);
            this.lblCartoonEffect.TabIndex = 0;
            this.lblCartoonEffect.Text = "Cartoon Effect (Smoothing)";
            this.lblCartoonEffect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1017, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBrightnessTag
            // 
            this.lblBrightnessTag.AutoSize = true;
            this.lblBrightnessTag.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessTag.Location = new System.Drawing.Point(385, 88);
            this.lblBrightnessTag.Name = "lblBrightnessTag";
            this.lblBrightnessTag.Size = new System.Drawing.Size(152, 23);
            this.lblBrightnessTag.TabIndex = 28;
            this.lblBrightnessTag.Text = "Brightness Value :";
            // 
            // lblBrightnessValue
            // 
            this.lblBrightnessValue.AutoSize = true;
            this.lblBrightnessValue.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessValue.ForeColor = System.Drawing.Color.Green;
            this.lblBrightnessValue.Location = new System.Drawing.Point(543, 88);
            this.lblBrightnessValue.Name = "lblBrightnessValue";
            this.lblBrightnessValue.Size = new System.Drawing.Size(20, 23);
            this.lblBrightnessValue.TabIndex = 29;
            this.lblBrightnessValue.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 723);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabImageProcess);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxStepTwo);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Card Personalization System";
            this.gBoxStepTwo.ResumeLayout(false);
            this.gBoxStepTwo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewImgBox)).EndInit();
            this.tabImageProcess.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcBrightness)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxStepTwo;
        private System.Windows.Forms.Label lblInstructTwo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox previewImgBox;
        private System.Windows.Forms.TabControl tabImageProcess;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewImgEffect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imgGradient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCartoonEffect;
        private System.Windows.Forms.ComboBox cmbCartoonEffect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageIconTab;
        private System.Windows.Forms.Label lblImgBrightness;
        private System.Windows.Forms.TrackBar trcBrightness;
        private System.Windows.Forms.Label lblBrightnessTag;
        private System.Windows.Forms.Label lblBrightnessValue;

    }
}