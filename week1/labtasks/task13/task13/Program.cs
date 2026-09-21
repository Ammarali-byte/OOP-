using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number");
            float num = float.Parse(Console.ReadLine());

            Console.WriteLine("the decimal number you entered is {0}" , num);

            Console.Read();
        }
    }
}
