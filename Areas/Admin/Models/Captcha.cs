using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace CongThongTin.Models
{
    public class Captcha
    {

        private static Random Randomizer = new Random(DateTime.Now.Second);
        public string Text { get; set; }
        public byte[] ImageAsByteArray { get; set; }

        public Captcha() // constructor
        {
            Text = GetRandomText();
            ImageAsByteArray = CreateCaptcha(Text);
        }

        private static string GetRandomText()
        {
            string text = "";
            const string chars = "0123456789abcdefghijklmnprstuxyz";
            for (int i = 0; i < 4; i++)
                text += chars.Substring(Randomizer.Next(0, chars.Length), 1);
            return text;
        }

        private static byte[] CreateCaptcha(string text)
        {
            byte[] byteArray = null;

            Font[] fonts = {
            new Font("Arial", 24, FontStyle.Bold),
            new Font("Arial", 24, FontStyle.Bold),
            new Font("Arial", 24, FontStyle.Bold),
            new Font("Arial", 24, FontStyle.Bold),
            };

            using (var bmp = new Bitmap(170, 50))
            {
                using (var graphic = Graphics.FromImage(bmp))
                {
                    using (var hb = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Silver, Color.White))
                        graphic.FillRectangle(hb, 0, 0, bmp.Width, bmp.Height);

                    for (int i = 0; i < text.Length; i++)
                    {
                        var point = new PointF(10 + (i * 35), 25);
                        graphic.DrawString(
                            text.Substring(i, 1),
                            fonts[Randomizer.Next(0, 4)],
                            Brushes.Silver,
                            point,
                            new StringFormat { LineAlignment = StringAlignment.Center }
                        );
                    }
                }
                using (var stream = new MemoryStream())
                {
                    bmp.Save(stream, ImageFormat.Png);
                    byteArray = stream.ToArray();
                }
            }
            // Cleanup Fonts (they are disposable)
            foreach (var font in fonts) font.Dispose();
            return byteArray;
        }

    }
}