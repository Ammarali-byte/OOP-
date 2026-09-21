using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num;
            Console.WriteLine("Enter the number ");
            num = int.Parse(Console.ReadLine());
            while(num != -1)
            {
                sum = sum + num;
                Console.WriteLine("Enter the number ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Sum of Numbers is  ");
            Console.WriteLine(sum);
            Console.Read();

        }
    }
}
