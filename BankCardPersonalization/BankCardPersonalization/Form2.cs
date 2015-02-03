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
        public Form2()
        {
            InitializeComponent();
            f1.timerFunction(false);
            DisplayInstructTwo();
            ImgGradientPrompt();
            cmbCarEffectImplement();
        }
       // private void refreshImage()
        //{
         //   ApplyImageFilter(true, oriImage, previewImage);
       // }

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
            //ImageProp imgProp = new ImageProp();
            previewImgBox.Image = previewImg;
            prvImage = previewImg;
            origImage = oriImage;
            previewImgBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ApplyImageFilter(true, prvImage, origImage);
        }

        private void ApplyImageFilter(bool preview, Image prvImage, Image origImage)
        {
            if (prvImage == null || cmbCartoonEffect.SelectedIndex == -1)
            {
                return;
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

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
            this.listViewImgGradient.Items.Clear();
           
            foreach (string dir in directory)
            {
                listViewImgGradient.Items.Add(Path.GetFileNameWithoutExtension(dir), i);
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
            ApplyImageFilter(true, prvImage, origImage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("muahaha");
        }

       
    }
}


