using System;
using SixLabors.ImageSharp.Formats.Gif;
using Spectre.Console;
using SoGoodLib;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CanvasImage image = new CanvasImage("tux.jpg");
            image = image.MaxWidth(24);
            string randomImage = "";
            string n = "";
            int Width = int.Parse(n);

            if (args.Length >= 2)
            {
                Console.WriteLine(SoGoodClass.SoGoodMethod());
                CanvasImage image2 = new CanvasImage(randomImage);
                image2.MaxWidth(Width);
                AnsiConsole.Write(image2);
                return;
            }
            else if (args.Length == 0)
            {
                AnsiConsole.Write(image);
                return;
            }
        }
    }
}
