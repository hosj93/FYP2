using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCardPersonalization
{
    public class ImageProp
    {
        public Image originalImage;
        public Image previewImage;

       // public setImage(Image originalImage, Image previewImage)
       // {
       //    this.originalImage= originalImage;
       //this.previewImage = previewImage;
       // }

        public Image RetrieveOriImage 
        {
            get
            {
                return this.originalImage;
            }
            set
            {
                this.originalImage=value;
            }
        }
        public Image RetrievePreviewImage
        {
            get
            {
                return this.previewImage;
            }
            set
            {
                this.previewImage=value;
            }
        }
    }
}
