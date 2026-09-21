using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter Your Marks");
            int marks = int.Parse(Console.ReadLine());
            if (marks > 50)
            {
                Console.WriteLine("You Are passed ");

            }
            else
            {
                Console.WriteLine("You are Failed");
            }
            Console.Read();
        }
    }
}
