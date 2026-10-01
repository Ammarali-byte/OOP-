using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator
{
    internal class Calculator
    {
        int num1;
        int num2;

        public Calculator(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }
        public int Add()
        {
            return num1 + num2;
        }

        public int Subtract()
        {
            return num1 - num2;
        }

        public int Multiply()
        {
            return num1 * num2;
        }
        public double Divide()
        {
            return (double)num1 / num2;
        }

        static void Main(string[] args)
        {
            Calculator obj = new Calculator(20, 5);

            Console.WriteLine("Addition = " + obj.Add());
            Console.WriteLine("Subtraction = " + obj.Subtract());
            Console.WriteLine("Multiplication = " + obj.Multiply());
            Console.WriteLine("Division = " + obj.Divide());

            Console.ReadLine();
        }
    }
}
