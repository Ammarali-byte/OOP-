
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of one side ");
            int len = int .Parse(Console.ReadLine());
            int area = len * len;
            Console.Write(" the  total area of square is {0} " , area);
            Console.Read();
        }
    }
}
