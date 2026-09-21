using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lily age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter machine price ");
            float macprice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter toys price ");
            int toyprice = int.Parse(Console.ReadLine());
            calculate(age, macprice, toyprice);
            Console.Read();
        }
        static void calculate(int age , float macprice , int toyprice )
        {
            int moneysaved = 0;
            int newmoney = 10;
            float rem = 0;
            for (int i = 1; i <= age; i++)
            {
               
                if (i%2 == 0)
                {
                    
                    moneysaved = moneysaved + newmoney - 1 ;
                    newmoney = newmoney + 10;
                }
                else
                {
                    moneysaved = moneysaved + toyprice;
                }
            }
            if (moneysaved > macprice)
            {
                rem = moneysaved - macprice;
                Console.Write("yes ! {0}", rem);
            }
            else
            {
                rem = macprice - moneysaved;
                Console.Write("No ! {0}", rem);
            }
        }
    }
}
