using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm)
            Console.WriteLine("*************** Implicit Conversion ***************");
            byte a = 5;
            sbyte b = 30;
            short c = 20;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float f = h;
            Console.WriteLine("f: " + f);
            string isim = "Zehra";
            char x = 'K';
            object z = isim + x + a;
            Console.WriteLine("z: " + z);


            //Explicit Conversion (Bilinçli ya da açık dönüşüm)
            Console.WriteLine("*************** Explicit Conversion ***************");
            int w = 4;
            byte r = (byte)w;
            Console.WriteLine("r: " + r);

            int t = 110;
            byte g = (byte)t;
            Console.WriteLine("g: " + g);

            float u = 10.3f;
            byte v = (byte)u;
            Console.WriteLine("v: " + v);

            //ToString Methodu 
            Console.WriteLine("*************** ToString Methodu ***************");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            //System Convert
            Console.WriteLine("*************** System Convert ***************");
            string s1 = "10", s2 = "20";
            int say1, say2;
            int toplam;
            say1 = Convert.ToInt32(s1);
            say2 = Convert.ToInt32(s2);
            toplam = say1 + say2;
            Console.WriteLine("Toplam: " + toplam);

            //Parse Method
            Console.WriteLine("*************** Parse Method ***************");
            ParseMethod();


        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam;
            double dbl;
            rakam = int.Parse(metin1);

            Console.WriteLine("Rakam: " + rakam);
           dbl = double.Parse(metin2);
            Console.WriteLine(dbl);
            Console.ReadKey();
        }
    }
}
