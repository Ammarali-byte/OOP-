using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    internal class Program
    {

       
        static void Main(string[] args)
        {

            string path = "D:\\OOP\\textfile.txt";
            string [] names = new string[5];
            string [] password = new string[5];
            while(true)
            {
                int option = menu();

               

                    readdata(path, names, password);
                    Console.Clear();
                    if (option == 1)
                    {
                        Console.WriteLine("Enter your username ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter your password ");
                        string pass = Console.ReadLine();
                        signin(username, pass, names, password);
                        break;
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("Enter New Name: ");

                        string n = Console.ReadLine();

                        Console.WriteLine("Enter New Password: ");

                        string p = Console.ReadLine();

                        signUp(path, n, p);
                        break;

                    }
                else if(option ==3 )
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
                
                

                Console.Read();
            }

           
        }
        static int menu()
        {
            Console.Write("\n===================================================================");
            Console.Write("\n====================Welcome to Our Software========================");
            Console.Write("\n===================================================================\n");
            Console.WriteLine("1- Sign In ");
            Console.WriteLine("2- Sign Up ");
            Console.WriteLine("3-Exit ");
            Console.WriteLine("Enter Your Option  ");
            int option = int.Parse(Console.ReadLine());
            return option;


        }
        static void signin(String username, String pass, string[] names , string[] password)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)

            {

                if (username == names[x] && pass == password[x])

                {

                    Console.WriteLine("Valid User");

                    flag = true;

                }

            }

            if (flag == false)

            {

                Console.WriteLine("Invalid User");

            }

            Console.ReadKey();
            

        }
        static  void readdata(String path , String[] names , string[] password ) 
        {
            
            if (File.Exists(path))
            {
                int x = 0;

                    StreamReader fileVariable = new StreamReader(path);

                    string record;

                    while ((record = fileVariable.ReadLine()) != null)

                    {

                        names[x] = parseData(record, 1);

                        password[x] = parseData(record, 2);

                        x++;

                        if (x >= 5)

                        {

                            break;

                        }

                    }

                    fileVariable.Close();

                }

                else

                {

                Console.WriteLine("File not exists");
                
            }
        }
        static string parseData(string record, int field)

        {

            int comma = 1;

            string item = "";

            for (int x = 0; x < record.Length; x++)

            {

                if (record[x] == ',')

                {

                    comma++;

                }

                else if (comma == field)

                {

                    item = item + record[x];

                }

            }

            return item;

        }
        static void signUp(string path, string n, string p)

        {

            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine(n + "," + p);

            file.Flush();

            file.Close();

        }
    }
}
