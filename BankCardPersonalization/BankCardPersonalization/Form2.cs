using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BankCardPersonalization
{
    public partial class Form2 : Form
    {
        Form1 f1 = new Form1();

        public static Bitmap image;
        public Image prvImage;
        public Image origImage;

        public Bitmap selectedSource = null;
        public Bitmap bitmapResult = null;
        public Bitmap oriImageEffect = null;
        public Bitmap tempImageEffect = null;
        public Bitmap oriBrightnessEffect = null;
        public Bitmap tempBrightnessEffect = null;

        public bool cartoonEffectChecker = false;
        public bool imageEffect;
        public bool brightnessEffect;

        public Form2()
        {
            InitializeComponent();
            f1.timerFunction(false);
            DisplayInstructTwo();
            ImgGradientPrompt();
            cmbCarEffectImplement();
            cmbColorSwappingImplement();
        }
     
        public void cmbColorSwappingImplement()
        {
            cmbColorSwapping.Items.Add(ColorSwapFilter.ColorSwapType.ShiftLeft);
            cmbColorSwapping.Items.Add(ColorSwapFilter.ColorSwapType.ShiftRight);
            cmbColorSwapping.Items.Add(ColorSwapFilter.ColorSwapType.SwapBlueAndGreen);
            cmbColorSwapping.Items.Add(ColorSwapFilter.ColorSwapType.SwapBlueAndRed);
            cmbColorSwapping.Items.Add(ColorSwapFilter.ColorSwapType.SwapRedAndGreen);

            cmbColorSwapping.SelectedIndex = 0;
        }
        public void cmbCarEffectImplement()
        {
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Default);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Gaussian3x3);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Gaussian5x5);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Gaussian7x7);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Median3x3);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Median5x5);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Median7x7);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Median9x9);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Mean3x3);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Mean5x5);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.LowPass3x3);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.LowPass5x5);
            cmbCartoonEffect.Items.Add(CartoonEffect.SmoothingFilterType.Sharpen3x3);

            cmbCartoonEffect.SelectedIndex = 0;
        }

   
        public void SetImagePreview(Image oriImage, Image previewImg)
        {
            previewImgBox.Image = previewImg;
            prvImage = previewImg;
            origImage = oriImage;
            previewImgBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ApplyImageFilter(bool preview, Image prvImage, Image origImage)
        {
            if (prvImage == null || cmbCartoonEffect.SelectedIndex == -1)
            {
                return;
            }

            if (preview == true)
            {
                selectedSource = new Bitmap(prvImage);
            }
            else
            {
                //selectedSource = new Bitmap (oriImage);
            }

            if (selectedSource != null)
            {
                if ((CartoonEffect.SmoothingFilterType)cmbCartoonEffect.SelectedItem == CartoonEffect.SmoothingFilterType.Default)
                {
                    imageEffect = false;
                    bitmapResult = new Bitmap(origImage);
                }
                else
                {
                    CartoonEffect.SmoothingFilterType filterType =
                        ((CartoonEffect.SmoothingFilterType)cmbCartoonEffect.SelectedItem);

                    bitmapResult = selectedSource.CartoonEffectFilter(
                                       (byte)60, filterType);
                    //trcThreshold.Value
                }
            }

            if (bitmapResult != null)
            {
                if (preview == true)
                {
                    previewImgBox.Image = bitmapResult;
                    cartoonEffectChecker = true;   
                }
                else
                {
                    //resultBitmap = bitmapResult;
                }
            }
        }

        private void ImgGradientPrompt()
        {
            //label1.Visible = false;
            int i = 0;
            string[] extensions = new[] { ".jpg", ".png", ".bmp", ".jpeg" };
            string[] directory = Directory.GetFiles(@"C:\Users\Jack\Pictures\imgGradient", "*.*")
                .Where(f => extensions.Contains(System.IO.Path.GetExtension(f).ToLower())).ToArray();
            this.listViewImgEffect.Items.Clear();
           
            foreach (string dir in directory)
            {
                listViewImgEffect.Items.Add(Path.GetFileNameWithoutExtension(dir), i);
                i++;
                if (i == imgGradient.Images.Count)
                    i = 0;
                
            }
        }

        private void DisplayInstructTwo()
        {
            StringBuilder instructTwo = new StringBuilder();
            instructTwo.AppendLine("Please customize your photo or image using the image proceessing ");
            instructTwo.AppendLine("features provided.");
            instructTwo.AppendLine("Once you have done it, please proceed to next step by simply clicking ");
            instructTwo.AppendLine("on the 'Next' button.");
            lblInstructTwo.Text = instructTwo.ToString();
        }

        private void FilterLevelChanged(object sender, EventArgs e)
        {
            if (imageEffect == true)
            {
                prvImage = oriImageEffect;
                ApplyImageFilter(true, prvImage, origImage);
            }
            else
            {
                prvImage = origImage;
                ApplyImageFilter(true, prvImage, origImage);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("muahaha");
        }

        private void listViewImgEffect_Click(object sender, EventArgs e)
        {
            int imgEffectIndex;
            foreach(ListViewItem imgGradient in listViewImgEffect.SelectedItems)
            {
                imgEffectIndex = imgGradient.ImageIndex;
                if (imgEffectIndex >= 0 && imgEffectIndex < this.imgGradient.Images.Count)
                {
                    switch (imgEffectIndex)
                    {
                        case 0:
                            {
                                ApplyFlipping();
                            }break;
                        case 1:
                            {
                                ApplyGrayScale();
                                
                            }break;
                        case 2:
                            {
                                ApplyInvertEffect();
                            }break;
                    }
                }
                
            }
        }

        private void ApplyFlipping()
        {
            Bitmap rotateImage = null;
            rotateImage = new Bitmap(previewImgBox.Image);
            previewImgBox.Image = rotateImage.FlipPixels();
        }

        private void BrightnessLabel()
        {
            StringBuilder ImgBrightnessText = new StringBuilder();
            ImgBrightnessText.AppendLine("Adjust the brightness of your Image ");
            lblImgBrightness.Text = ImgBrightnessText.ToString();
        }

        private void ApplyInvertEffect()
        {
            if (cartoonEffectChecker == true)
            {
                oriImageEffect = new Bitmap(bitmapResult);
                tempImageEffect = (Bitmap)oriImageEffect.Clone();
            }
            else
            {
                oriImageEffect = new Bitmap(prvImage);
                tempImageEffect = (Bitmap)oriImageEffect.Clone();
            }

            Color c;
            for (int i = 0; i < tempImageEffect.Width; i++)
            {
                for (int j = 0; j < tempImageEffect.Height; j++)
                {
                    c = tempImageEffect.GetPixel(i, j);
                    tempImageEffect.SetPixel(i, j,
                    Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }           
            }
            oriImageEffect = (Bitmap)tempImageEffect.Clone();
            previewImgBox.Image = oriImageEffect;
            previewImgBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageEffect = true;
            GrabLatestImage(imageEffect);
        }

        private void ApplyGrayScale()
        {
            if (cartoonEffectChecker == true)
            {
                 oriImageEffect = new Bitmap(bitmapResult);
                 tempImageEffect = (Bitmap)oriImageEffect.Clone();
            }
            else
            {
                oriImageEffect = new Bitmap(origImage);
                tempImageEffect = (Bitmap)oriImageEffect.Clone();
            }
            
            Color c;
            for (int i = 0; i < tempImageEffect.Width; i++)
            {
                for (int j = 0; j < tempImageEffect.Height; j++)
                {
                    c = tempImageEffect.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                    tempImageEffect.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            oriImageEffect = (Bitmap)tempImageEffect.Clone();
            previewImgBox.Image = oriImageEffect;
            previewImgBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageEffect = true;
            GrabLatestImage(imageEffect);
        }

        private void GrabLatestImage(bool imageEffect)
        {
            if (imageEffect == true)
            {
                oriBrightnessEffect = oriImageEffect;
                
            }
            else
            {
                oriBrightnessEffect = new Bitmap(prvImage);
            }
        }

        private void tabBrightness_Click(object sender, EventArgs e)
        {
            BrightnessLabel();
        }

        private void trcBrightness_Scroll(object sender, EventArgs e)
        {
            int brightnessVal = trcBrightness.Value;
            oriImageEffect = new Bitmap(oriBrightnessEffect);
            tempImageEffect = (Bitmap)oriImageEffect.Clone();
            //if (imageEffect == true)
            //{
            //    oriImageEffect = new Bitmap(oriBrightnessEffect);
            //    tempImageEffect = (Bitmap)oriImageEffect.Clone();
            //}
            //else
            //{
             //   oriImageEffect = new Bitmap(prvImage);
             //   tempImageEffect = (Bitmap)oriImageEffect.Clone();
            //}
            if (brightnessVal < -255) brightnessVal = -255;
            if (brightnessVal > 255) brightnessVal = 255;
            Color c;
            for (int i = 0; i < tempImageEffect.Width; i++)
            {
                for (int j = 0; j < tempImageEffect.Height; j++)
                {
                    c = tempImageEffect.GetPixel(i, j);
                    int cR = c.R + brightnessVal;
                    int cG = c.G + brightnessVal;
                    int cB = c.B + brightnessVal;

                    if (cR < 0) cR = 1;
                    if (cR > 255) cR = 255;

                    if (cG < 0) cG = 1;
                    if (cG > 255) cG = 255;

                    if (cB < 0) cB = 1;
                    if (cB > 255) cB = 255;

                    tempImageEffect.SetPixel(i, j,
                    Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
            if (brightnessVal < 100)
            {
                lblBrightnessValue.ForeColor = System.Drawing.Color.Green;
            }
            else if (brightnessVal > 100 && brightnessVal < 180)
            {
                lblBrightnessValue.ForeColor = System.Drawing.Color.Blue;
            }
            else
                lblBrightnessValue.ForeColor = System.Drawing.Color.Red;

            lblBrightnessValue.Text = brightnessVal.ToString();
            oriImageEffect = (Bitmap)tempImageEffect.Clone();
            previewImgBox.Image = oriImageEffect;
            previewImgBox.SizeMode = PictureBoxSizeMode.StretchImage;
           // imageEffect = true;
            //GrabLatestImage(imageEffect);
            
        }

        private void ColorEffectChanged(object sender, EventArgs e)
        {
            ApplyColorFilter();
        }

        private void ApplyColorFilter()
        {
            if (prvImage != null)
            {
                ColorSwapFilter swapFilter = new ColorSwapFilter();
                swapFilter.SwapType = (ColorSwapFilter.ColorSwapType)cmbColorSwapping.SelectedItem;
                //swapFilter.InvertColorsWhenSwapping = chkInvertColours.Checked;
                //swapFilter.SwapHalfColorValues = chkHalfColours.Checked;

                previewImgBox.Image = ((Bitmap)(prvImage)).SwapColorsCopy(swapFilter);
            }
        }  
    }
}


