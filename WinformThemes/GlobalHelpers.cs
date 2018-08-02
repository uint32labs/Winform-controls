#region

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

#endregion

namespace WinformThemes
{
    internal static class GlobalHelpers
    {
        public static readonly string DownArrowBase64String =
            "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAh0lEQVQ4T93TMQrCUAzG8V9x8QziiYSuXdzFC7h4AcELOPQAdXYovZCHEATlgQV5GFTe1ozJlz/kS1IpjKqw3wQBVyy++JI0y1GTe7DCBbMAckeNIQKk/BanALBB+16LtnDELoMcsM/BESDlz2heDR3WePwKSLo5eoxz3z6NNcFD+vu3ij14Aqz/DxGbKB7CAAAAAElFTkSuQmCC";


        public static GraphicsPath GetRoundedRect(Rectangle baseRect,
            int radius)
        {
            int corner = radius * 2;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(new Rectangle(baseRect.X, baseRect.Y, corner, corner), -180, 90);
            gp.AddArc(new Rectangle(baseRect.Width - corner + baseRect.X, baseRect.Y, corner, corner), -90, 90);
            gp.AddArc(
                new Rectangle(baseRect.Width - corner + baseRect.X, baseRect.Height - corner + baseRect.Y, corner,
                    corner), 0, 90);
            gp.AddArc(new Rectangle(baseRect.X, baseRect.Height - corner + baseRect.Y, corner, corner), 90, 90);
            gp.CloseAllFigures();
            return gp;
        }

        public static GraphicsPath GetRoundedRect(RectangleF baseRect,
            float radius)
        {
            float corner = radius * 2;
            GraphicsPath GP = new GraphicsPath();
            GP.AddArc(new RectangleF(baseRect.X, baseRect.Y, corner, corner), -180, 90);
            GP.AddArc(new RectangleF(baseRect.Width - corner + baseRect.X, baseRect.Y, corner, corner), -90, 90);
            GP.AddArc(
                new RectangleF(baseRect.Width - corner + baseRect.X, baseRect.Height - corner + baseRect.Y, corner,
                    corner), 0, 90);
            GP.AddArc(new RectangleF(baseRect.X, baseRect.Height - corner + baseRect.Y, corner, corner), 90, 90);
            GP.CloseAllFigures();
            return GP;
        }

        public static void DrawDownFade(Graphics g, Rectangle area, Color finalColor)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(area, Color.Transparent, finalColor, 270))
            {
                g.FillRectangle(brush, area);
            }

            /*
            int floorIncrements = finalColor.A / area.Height;
            for (int i = 0; i < area.Height; i++)
            {
                using (Pen pen = new Pen(Color.FromArgb(finalColor.A - (floorIncrements * (i + 1)), finalColor)))
                    g.DrawLine(pen, area.X, area.Y + i, area.Width, area.Y + i);
            }
            */
        }

        /// <summary>
        ///     Changes the overall transparency of an image
        /// </summary>
        /// <param name="originalImage">The input image to be tuned</param>
        /// <param name="alpha">the desired alpha value. It is based on the 255 alpha pixels</param>
        /// <param name="antialias">To conserve the antialiasing on the image</param>
        /// <returns></returns>
        public static Image TuneTransparency(Image originalImage, int alpha, bool antialias)
        {
            //Cast & clone image to bitmap
            Bitmap bitmap = new Bitmap(originalImage);
            //Cycle through all pixels
            Color pixel;

            //ratio between a max byte and desired alpha byte, this achieves the conservation of antialiasing
            int ratio = 255 / alpha;
            for (int i = 0; i < originalImage.Width; i++)
            for (int j = 0; j < originalImage.Height; j++)
            {
                //Get pixel color
                pixel = bitmap.GetPixel(i, j);

                //If pixel is not already transparent
                if (pixel.A != 0)
                    bitmap.SetPixel(i, j, Color.FromArgb(
                        //If antialiasing is enabled use the pixel alpha/ratio else just use the set alpha
                        antialias ? pixel.A / ratio : alpha,
                        pixel));
            }

            return bitmap;
        }

        /// <summary>
        ///     Lightens a color
        /// </summary>
        /// <param name="originalColor">Original color</param>
        /// <param name="difference">The amount of bytes to lighten the color</param>
        /// <returns></returns>
        public static Color ChangeColor(Color originalColor, int difference)
        {
            return
                Color.FromArgb(originalColor.R + difference > 255 ? 255 : originalColor.R + difference,
                    originalColor.G + difference > 255 ? 255 : originalColor.G + difference,
                    originalColor.B + difference > 255 ? 255 : originalColor.B + difference);
        }

        /// <summary>
        ///     Transforms a base64 string to an image
        /// </summary>
        /// <param name="base64string">Base64 image string</param>
        /// <returns></returns>
        public static Image Base64ToImage(string base64string)
        {
            MemoryStream stream = new MemoryStream(Convert.FromBase64String(base64string));
            return Image.FromStream(stream);
        }
    }
}