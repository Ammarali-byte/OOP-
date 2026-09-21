using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Enter second  number ");
            float n2 = float.Parse(Console.ReadLine());
            Console.Write(add(n1, n2));
            Console.Read();
        }
        static float add(float n1 , float n2)
        {
            float sum = n1 + n2;
            return sum;
        }
    }
}
