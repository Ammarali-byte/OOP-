using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[,] cars = {{ 10, 7, 12, 10, 4},
                           { 18, 11, 15, 17, 2},
                           { 23, 19, 12, 16, 14},
                           { 7, 12, 16, 0, 2},
                           { 3, 5, 6, 2, 1}};
            int sum = add(cars);
            Console.WriteLine("The sum of the cars is {0}",sum);
            Console.Read();
        }
        static int add(int [,] nums)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++ )
                {
                    sum = sum + nums[i, j];
                }
            }
            return sum;
        }
    }
}
