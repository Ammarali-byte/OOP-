
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.name = "Ammar";
            S1.age = 20;
            S1.EcatMarks = 306;
            S1.matricMarks = 1073;
            S1.FscMarks = 1076;
            Student S2 = new Student();
            S2.name = "Ali";
            Console.WriteLine(S1.name);
            Console.WriteLine(S2.name);
            Console.Read();
        }
    }
    class Student
    {
        public String name;
        public int age;
        public float matricMarks;
        public float EcatMarks;
        public float FscMarks;
    }
}
