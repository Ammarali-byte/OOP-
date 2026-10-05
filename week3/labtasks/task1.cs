using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Student
    {
        public int Student_id;
        public string Name;
        public string Department;
        public int Semester;
        public int markofsubject1;
        public int markofsubject2;
        public int markofsubject3;
        public int markofsubject4;
        public int markofsubject5;
        public Student (int Student_id , String Name , String Department , int Semester , int markofsubject1, int markofsubject2, int markofsubject3, int markofsubject4, int markofsubject5 )
        {
            this.Student_id = Student_id;
            this.Name = Name;
            this.Department = Department;
            this .Semester = Semester;
            this.markofsubject1 = markofsubject1;
            this.markofsubject2 = markofsubject2;
            this.markofsubject3 = markofsubject3;
            this.markofsubject4 = markofsubject4;
            this.markofsubject5 = markofsubject5;

        }
        public int totalmarks()
        {
            return markofsubject1 + markofsubject2 + +markofsubject3 + markofsubject4 + markofsubject5;
            
        }
        public int averagemarks()
        {
           return (markofsubject1 + markofsubject2 + markofsubject3 + markofsubject4 + markofsubject5)/5;
            
        }
        public void  Grade()
        {
            float percentage = ((totalmarks()) / 500F) * 100;
            if (percentage >= 95 )
            {
                Console.WriteLine("Your Grade is A+ ");
            }
            else if (percentage >= 90)
            {
                Console.WriteLine("Your Grade is A ");
            }
            else if (percentage >= 85)
            {
                Console.WriteLine("Your Grade is A- ");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Your Grade is B+ ");
            }
            else if (percentage >= 75)
            {
                Console.WriteLine("Your Grade is B ");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Your Grade is B- ");
            }
            else if (percentage >= 65)
            {
                Console.WriteLine("Your Grade is C+ ");

            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Your Grade is C ");
            }
            else if (percentage >= 55)
            {
                Console.WriteLine("Your Grade is C- ");
            }
            else
            {
                Console.WriteLine("Your Grade is F ");
                
            }
            Console.WriteLine(percentage);
        }
        public void details()
        {
            Console.WriteLine("Name : {0}",Name);
            Console.WriteLine("ROLL No : {0}",Student_id);
            Console.WriteLine("Department : {0}",Department);
            Console.WriteLine("Semester : {0}",Semester);
            Console.WriteLine("Total Obtained Marks : {0}", totalmarks());
            Console.WriteLine("mark of subject1 : {0}", markofsubject1);
            Console.WriteLine("mark of subject2 : {0}", markofsubject2);
            Console.WriteLine("mark of subject3 : {0}", markofsubject3);
            Console.WriteLine("mark of subject4 : {0}", markofsubject4);
            Console.WriteLine("mark of subject5 : {0}", markofsubject5);
            Console.WriteLine("Average Marks : {0}", averagemarks());
            Grade();

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(76, "Ammar", "Cs", 2, 80, 90, 75, 85, 95);
            s1.details();
            Console.Read();
        }
    }
}
