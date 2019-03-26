using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie konsolowym");

            Console.Write("Podaj swoje imie:");

            string imie = Console.ReadLine();
            Console.WriteLine($"cześć {imie}!!!");
        }
    }
}
