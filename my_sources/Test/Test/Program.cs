using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Test!!!");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Test!!!");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Test!!!");
            Console.ReadKey();
        }
    }
}