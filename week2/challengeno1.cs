using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challengeNo1
{
    public class Student
    {
        public string Student_name;
        public int matric_marks;
        public int fsc_marks;
        public int ecat_marks;
        public float agrregate;
        public Student(string studentname, int matricmarks, int fscmarks, int ecatmarks)
        {
            this.Student_name = studentname;
            this.matric_marks = matricmarks;
            this.fsc_marks = fscmarks;
            this.ecat_marks = ecatmarks;
        }
      
        public float calculate_aggregate()
        {
            agrregate = ((matric_marks / 1100) * 10) + ((fsc_marks / 1200) * 40) + ((ecat_marks / 400) * 50);
            return agrregate;
            
        }
        public void student_display()
        {
            Console.WriteLine("Student Record is Name :{0} || Matric Marks : {1}  || Ecat marks : {2} || fsc  marks : {3}" , Student_name, matric_marks, fsc_marks, ecat_marks);
        }

    }
    internal class Program
    {
       static  Student[] students = new Student[100];
        static int student_count = 0;
        static void add_student()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Matric Marks: ");
            int matric = int.Parse(Console.ReadLine());

            Console.Write("Enter FSc Marks: ");
            int fsc = int.Parse(Console.ReadLine());

            Console.Write("Enter ECAT Marks: ");
            int ecat = int.Parse(Console.ReadLine());


            Student student = new Student(name, matric, fsc, ecat);
            students[student_count] = student;
            student_count ++;
            Console.WriteLine("\nStudent added successfully!");

        }
        static void CalculateAggregates()
        {
            if (student_count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            Console.WriteLine("\n===== STUDENT AGGREGATES =====");

            for (int i = 0; i < student_count; i++)
            {
                Console.WriteLine(
                    students[i].Student_name + " = " +
                    students[i].calculate_aggregate().ToString("F2") + "%"
                );
            }
        }
        static void TopStudents()
        {
            if (student_count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            Student[] temp = new Student[student_count];

            for (int i = 0; i < student_count; i++)
            {
                temp[i] = students[i];
            }
            for (int i = 0; i < student_count - 1; i++)
            {
                for (int j = i + 1; j < student_count; j++)
                {
                    if (temp[j].calculate_aggregate() > temp[i].calculate_aggregate())
                    {
                        Student tempStudent = temp[i];
                        temp[i] = temp[j];
                        temp[j] = tempStudent;
                    }
                }
            }

          
            int topCount = student_count;

            if (topCount > 3)
            {
                topCount = 3;
            }

            Console.WriteLine("\n===== TOP STUDENTS =====");

            for (int i = 0; i < topCount; i++)
            {
                Console.WriteLine("Rank: " + (i + 1));
                temp[i].student_display();
            }
        }
        static void ShowStudents()
        {
            if (student_count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            Console.WriteLine("\n===== ALL STUDENTS =====");

            for (int i = 0; i < student_count; i++)
            {
                students[i].student_display();
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Students");
                Console.WriteLine("3. Calculate Aggregate");
                Console.WriteLine("4. Top Students");
                Console.WriteLine("5. Exit");

                Console.Write("\nEnter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (choice == 1)
                {
                    add_student();
                }
                else if (choice == 2)
                {
                    TopStudents();
                }
                else if (choice == 3)
                {
                    CalculateAggregates();
                }
                else if (choice == 4)
                {
                    TopStudents();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Program ended.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }
        }
    }
    
}
