using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num;
            do
            {
                Console.WriteLine("Enter the number ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;

            }
            while (num != -1);
            sum = sum + 1;
            Console.WriteLine("the total sum is {0}", sum);
            Console.Read();


        }
    }
}
