using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_робота.Services
{
    public static class ImageService
    {
        public static Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            int newWidth;
            int newHeight;
            if (image.Width > image.Height)
            {
                newWidth = maxWidth;
                newHeight = (int)(image.Height * ((float)maxWidth / image.Width));
            }
            else
            {
                newHeight = maxHeight;
                newWidth = (int)(image.Width * ((float)maxHeight / image.Height));
            }
            if (image.Width <= maxWidth && image.Height <= maxHeight)
            {
                return new Bitmap(image);
            }

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return resizedImage;
        }
    }
}
