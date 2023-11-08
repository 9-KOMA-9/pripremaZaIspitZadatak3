using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaIspitZadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite vrijednost prve varijable");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upišite vrijednost druge varijable");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upišite vrijednost treće varijable");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upišite vrijednost treće varijable");
            double d = Convert.ToDouble(Console.ReadLine());
            double x;
            x = ((Math.Pow((a), 2) + Math.Pow((b), 2) + Math.Pow((c), 2) + Math.Pow((d), 2)) / (Math.Pow((a + b),2) + Math.Pow((c + d), 2)));
            Console.WriteLine("Rezultat je: " + x);   
            Console.ReadKey();

        }
    }
}
