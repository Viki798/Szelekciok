using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Addj meg egy számot:");
            int szam = int.Parse(Console.ReadLine());
            if (szam%3==0)
            {
                Console.WriteLine("A szám osztahtó hárommal");
            }
            else
            {
                Console.WriteLine("A szám nem osztható hárommal");
            }
            




            Console.ReadKey();  
        }
    }
}
