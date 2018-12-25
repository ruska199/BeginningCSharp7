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
            Console.WriteLine($"The value: {myInt:C}");
            Console.WriteLine($"The value: {myInt:F}");
            Console.WriteLine("|{0,  10}|", myInt);
            Console.WriteLine("|{1,  5}{0, -5}|", arr[0], arr[1]);
            Console.WriteLine("|{2, -5}{1, 5}|", arr[0], arr[1], arr[2]);
            Console.ReadKey();
        }
    }
}
