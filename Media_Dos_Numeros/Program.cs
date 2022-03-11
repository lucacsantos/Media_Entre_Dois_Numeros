using System;
using System.Globalization;

namespace Media_Dos_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números para saber a media: ");
            float x = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float y = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media(x, y);
        }

        public static float media(float num1 , float num2)
        {
            float media = (num1 + num2) / 2;
            
            Console.WriteLine("Media: {0}", media.ToString("F2", CultureInfo.InvariantCulture));
            return media;
        }
    }
}
