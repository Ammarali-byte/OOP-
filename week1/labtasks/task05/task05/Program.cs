using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the number ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int largest = arr[0];
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine("The largest of these numbers is {0}", largest);
            Console.Read();
        }
    }
}
