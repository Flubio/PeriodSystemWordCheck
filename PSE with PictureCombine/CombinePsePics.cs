using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace PSE_with_PictureCombine
{
    public class CombinePsePics
    {
#if DEBUG
        static string PicPath = @"D:\Development\Dev-Main\C#\PeriodSystemWordCheck\PSE with PictureCombine\src\";
#else
        static string PicPath = Path.Combine(System.Reflection.Assembly.GetEntryAssembly().Location, @"\src\");
#endif
        static string PicPathOutPut = Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Pse_OutPut");
        static bool isFirst = true;
        public static void CombinePics(List<string> imageNames)
        {
            if (!Directory.Exists(PicPathOutPut))
            {
                Directory.CreateDirectory(PicPathOutPut);
            }

            Image image = null;
            foreach (string imgName in imageNames)
            {
                if (isFirst)
                {
                    image = Image.FromFile(PicPath + imgName + ".png");
                    isFirst = false;
                }
                else
                {
                    Image image1 = Image.FromFile(PicPath + imgName + ".png");
                    Bitmap bitmap = new Bitmap(image.Width + image1.Width, Math.Max(image.Height, image1.Height));
                    using(Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.DrawImage(image, 0, 0);
                        g.DrawImage(image1, image.Width, 0);
                    }

                    image = (Image)bitmap;
                }
            }
            isFirst = true;
            string outName = "";
            imageNames.ForEach(x => outName += x);
            imageNames.Clear();
            image.Save(PicPathOutPut + @"\"+outName+".png");
        }
    }
}
