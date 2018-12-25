/*
Illustrated c-7 5th Ed.
Some code outlines
25.12.18
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {   
        
        //Some example of formatting numeric strings

        static void Main(string[] args)
        {
            int myInt = 550;
            int[] arr = {100, 200, 300, 400};
            double myDouble = 13.543267;
            string text = "Some text";
            Console.WriteLine($"The value: ${myInt:F2}");
            Console.WriteLine($"The value: {myInt:F4}");
            Console.WriteLine($"The value: {myInt:D4}");
            Console.WriteLine("|{0,  10}|", myInt);
            Console.WriteLine("|{1,  5}{0, -5}|", arr[0], arr[1]);
            Console.WriteLine("|{2, -5}{1, 5}|", arr[0], arr[1], arr[2]);
            Console.WriteLine("_______________________________________\n");
            //with double
            Console.WriteLine($"{myDouble, -10:F4}");
            Console.WriteLine($"{myDouble, 10:F2}");
            Console.WriteLine($"{myDouble, -10:E4}");
            Console.WriteLine($"{myInt, -10:X}");
            Console.WriteLine("_______________________________________\n");
            //with text
            Console.WriteLine($"{text, 20}");
            Console.WriteLine($"{text, 15}");
            Console.ReadKey();
        }
    }
}
