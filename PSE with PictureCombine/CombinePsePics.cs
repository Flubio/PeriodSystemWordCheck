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
        static string PicPath = @"..\..\..\src\";
#else
        static string PicPath = @".\src\";
#endif
        static string OptPicPathOut = "";
        static string PicPathOutPut = Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Pse_OutPut");
        static bool isFirst = true;
        public static void CombinePics(List<string> imageNames)
        {
            Console.WriteLine("Please Enter an output Folder (Optional -> skip with enter)");
            OptPicPathOut = Console.ReadLine();

            if(OptPicPathOut == "")
            {
            if (!Directory.Exists(PicPathOutPut))
            {
                Directory.CreateDirectory(PicPathOutPut);
            }
            }
            else
            {
                if (!Directory.Exists(OptPicPathOut))
                {
                    Directory.CreateDirectory(OptPicPathOut);
                }
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
            string dir = (OptPicPathOut == ""? Path.Combine(PicPathOutPut, outName) : Path.Combine(OptPicPathOut, outName));
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            image.Save(dir + @"\"+outName+".png");
            Console.WriteLine("Generated " + outName + ".png");
            image.Save(dir + @"\"+outName+".jpg");
            Console.WriteLine("Generated " + outName + ".jpg");
            Console.WriteLine("Pictures saved at: " + dir + "/");
        }
    }
}
