using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace QuickPoker
{
    public static class ExtensionMethods
    {

        // Shameless copypaste from https://stackoverflow.com/a/23831231
        public static BitmapImage ToBitmapImage(this Bitmap bitmap)
        {
            using (var memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Png);
                memory.Position = 0;

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();

                return bitmapImage;
            }
        }

        public static BitmapImage GetImage(this Card card)
        {
            StringBuilder sb = new StringBuilder();

            if (card.CardValue <= CardAttributes.Value.Ten)
            {
                // Add 2 to match index and value
                sb.Append("_" + (int)(card.CardValue + 2));
            }
            else
            {
                // Else take the first letter of the value
                sb.Append(card.CardValue.ToString()[0]);
            }

            sb.Append(card.CardSuit.ToString()[0]);

            Bitmap bitmap = new HelperMethods().GetImageResourceByName(sb.ToString());
            return bitmap.ToBitmapImage();

        }
    }
}