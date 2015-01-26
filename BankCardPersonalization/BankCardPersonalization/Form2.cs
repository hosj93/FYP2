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
        public Form2()
        {
                
            InitializeComponent();
            DisplayInstructTwo();
            //ImageTesting();
            ImgGradientPrompt();
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
    }
}
