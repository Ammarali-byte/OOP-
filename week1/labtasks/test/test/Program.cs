
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter the numnber to Add ");
                int temp = int.Parse(Console.ReadLine());
                sum = sum + temp;
            }
            Console.Write(sum);
            Console.Read();
        }
    }
}
