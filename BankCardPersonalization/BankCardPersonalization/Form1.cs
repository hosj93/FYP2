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
using System.Threading;
namespace BankCardPersonalization
{
    public partial class Form1 : Form
    {
        public string initPlacement = "0";
        public int hours = 00;
        public int minutes = 02;
        public int sec = 00;
        public bool imageLoaded = false;
        public bool imgAvailable = false;
        Image selectedImage;
        public Bitmap bmpSelectedImg;
        public Form1()
        {
            InitializeComponent();
            DisplayInstructOne();
            panelImgGallery.Visible = false;
            timerFunction(true);
            //timerLoad.Enabled = true;
        }

        private void timerFunction(bool timerExecuter)
        {
            timerLoad.Enabled = timerExecuter;
        }

        private void DisplayInstructOne()
        {
            StringBuilder instructOne = new StringBuilder();
            instructOne.AppendLine("You are required to choose an image or a photo that you wish to customize and print it ");
            instructOne.AppendLine("on bank card. You have two options :");
            instructOne.AppendLine("Option 1 : Random an image from our gallery");
            instructOne.AppendLine("Option 2 : Choose an image or photo from our gallery");
            instructOne.AppendLine("Option 3 : Upload your own image or photo");
            instructOne.AppendLine("You may be directed to the next page once the timer finish counting down or you may ");
            instructOne.AppendLine("press 'Next' button to proceed to the next page");
            labelInstructOne.Text = instructOne.ToString(); //.Replace(Environment.NewLine, "<br />");
        }

        private void buttonSelectImg_Click(object sender, EventArgs e)
        {
            imageLoaded = false;
            grpSelectedImg.Visible = true;
            //label1.Visible = true;
            selectedImageBox.Image = null;
            panelImgGallery.Visible = false;
            OpenFileDialog imageDirectory = new OpenFileDialog();
            imageDirectory.Filter = "All Files (*.*)|*.*";
            //"JPG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpg|GIF Files (*.gif)|*.gif"
            //Ommitted if necessary
            imageDirectory.Title = "Select an Image File";

            if (imageDirectory.ShowDialog() == DialogResult.OK)
            {
                selectedImage = Image.FromFile(imageDirectory.FileName);
                bmpSelectedImg = new Bitmap(selectedImage, 1036, 664);
                Graphics graphicImg = Graphics.FromImage(bmpSelectedImg);
                graphicImg.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphicImg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphicImg.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                //textInputImage.Text = imageDirectory.FileName;
                selectedImageBox.Image = bmpSelectedImg;
                selectedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                imageLoaded = true;

            }
        }

        private void pictureBoxPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Draw a string on the PictureBox.
            //g.DrawString("Your Image Will Be Display Here",
            //new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(150, 150));
            if (imageLoaded == false)
            {
                g.DrawString("Your Image Will Be Display Here",
                new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(150, 150));
            }
        }

        private void buttonImgGallery_Click(object sender, EventArgs e)
        {
            //label1.Visible = false;
            grpSelectedImg.Visible = false;
            panelImgGallery.Visible = true;
            int i = 0;
            string[] extensions = new[] { ".jpg", ".png", ".bmp", ".jpeg" };
            string[] directory = Directory.GetFiles(@"C:\Users\Jack\Pictures", "*.*")
                .Where(f => extensions.Contains(System.IO.Path.GetExtension(f).ToLower())).ToArray();
            this.listViewGallery.Items.Clear();                 
            foreach (string dir in directory)
            {
                listViewGallery.Items.Add(Path.GetFileNameWithoutExtension(dir),i);
                    i++;
                if(i==imageList1.Images.Count)
                    i=0;
                
            }
        }

        private void listViewGallery_DoubleClick(object sender, EventArgs e)
        {
            Image galleryImg;
            foreach (ListViewItem imgGallery in listViewGallery.SelectedItems)
            {
                int imgIndex = imgGallery.ImageIndex;
                if (imgIndex >= 0 && imgIndex < this.imageList1.Images.Count)
                {
                    panelImgGallery.Visible = false;
                    imageLoaded = true;
                    galleryImg = this.imageList1.Images[imgIndex];
                    bmpSelectedImg = new Bitmap(galleryImg, 1036, 664);
                    Graphics graphicImg = Graphics.FromImage(bmpSelectedImg);
                    graphicImg.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphicImg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    graphicImg.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    selectedImageBox.Image = bmpSelectedImg;
                    selectedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                    grpSelectedImg.Visible = true;
                }
            }

        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            string argError = "Please Choose An Image In Order To Proceed !";
            string argRndImg = "Press Yes If You Wish To Random An Image From Our Gallery.";
            string noImgMsg = "No Image Found For Customization Process" + Environment.NewLine + argRndImg;
            
            {
                if (minutes != 0 && sec < 1)
                {
                    sec = 59;
                    if (minutes == 0)
                    {
                        //minutes = 59;
                        //MessageBox.Show("FASTER");
                        if (hours != 0) hours -= 1;
                    }
                    else
                    {
                        minutes -= 1;
                    }
                }
                else if (minutes == 0 && sec == 0)
                {
                    if (selectedImageBox.Image == null)
                    {
                        timerFunction(false);
                        DialogResult noImgResult = MessageBox.Show(noImgMsg, "No Image Found",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                        if (noImgResult == DialogResult.Yes)
                        {
                            btnImgRandom.PerformClick();
                        }
                    }
                    else
                    {
                        imageConfirmation();
                    }
                }
                else
                {
                    sec -= 1;
                } 
            }
            if (minutes == 0 && sec != 0)
            {
                if (minutes == 0 && sec < 10)
                {
                    if ((sec % 2) != 0)
                    {
                        lblTimerSec.ForeColor = System.Drawing.Color.Red;
                        lblTimerHour.ForeColor = System.Drawing.Color.Red;
                        lblTimerMin.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        lblTimerSec.ForeColor = System.Drawing.Color.Black;
                        lblTimerHour.ForeColor = System.Drawing.Color.Black;
                        lblTimerMin.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
            lblTimerHour.Text = initPlacement + hours.ToString();
            lblTimerMin.Text = initPlacement + minutes.ToString();
            if (sec < 10)
            {
                lblTimerSec.Text = initPlacement + sec.ToString();
            }
            else
            {
                lblTimerSec.Text = sec.ToString();
            }
            
        }

        private void btnImgProNext_Click(object sender, EventArgs e)
        {
            string argRndImg = "Do You Wish To Random An Image From Our Gallery ?";
            string noImgFound = "No Image Available For Customization Process !" + Environment.NewLine + argRndImg;
            
            if (selectedImageBox.Image == null)
            {
                DialogResult noImgResult = MessageBox.Show(noImgFound, "No Image Found",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (noImgResult == DialogResult.Yes)
                {
                    btnImgRandom.PerformClick();
                }
            }
            else
            {
               imageConfirmation();
            }
        }

        private void imageConfirmation()
        {
            string imgConfirm = "Is This The Image That You Wish To Customize ?";
            timerFunction(false);
            DialogResult imgConfirmation = MessageBox.Show(imgConfirm, "Image Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            if (imgConfirmation == DialogResult.Yes)
            {
                Form2 f2 = new Form2();
                f2.SetImagePreview(bmpSelectedImg.Clone() as Image);
                f2.Show();
                this.Hide();
                //timerLoad.Stop();
            }
        }

        private void btnImgRandom_Click(object sender, EventArgs e)
        {
            Random rndImg = new Random();
            int iniImgIndex = 0;
            int maxImgIndex = imageList1.Images.Count;
            Image galleryImg;
            int imgIndex = rndImg.Next(iniImgIndex, maxImgIndex); 
            if (imgIndex >= iniImgIndex && imgIndex < this.imageList1.Images.Count)
                {
                    panelImgGallery.Visible = false;
                    imageLoaded = true;
                    galleryImg = this.imageList1.Images[imgIndex];
                    bmpSelectedImg = new Bitmap(galleryImg, 1036, 664);
                    Graphics graphicImg = Graphics.FromImage(bmpSelectedImg);
                    graphicImg.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphicImg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    graphicImg.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    selectedImageBox.Image = bmpSelectedImg;
                    selectedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                    grpSelectedImg.Visible = true;
                }
            
            }
        }
    
}
  