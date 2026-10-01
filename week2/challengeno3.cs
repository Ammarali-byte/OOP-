using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challengeno3
{
    public class MUser
    {
        public string username;
        public string password;
        public string role;
        public MUser(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role= role;
        }

    }
    internal class Program
    {
        static MUser[] users = new MUser[10];
        static int count = 0;
        static void signup()
        {
            Console.WriteLine("ENter your username to signup ");
            string username = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (users[i].username == username)
                {
                    Console.WriteLine("Username already exists! try some other username ");
                    return;
                }
            }
            Console.WriteLine("make your own strong password ");
            string password = Console.ReadLine();
            Console.WriteLine("enter your role ");
            string role = Console.ReadLine();
            MUser newusers = new MUser(username, password, role);
            users[count] = newusers;
            count++;
            Console.WriteLine("You signned up successfully \n");
        }
        static void signin()
        {
            bool found = false;
            Console.WriteLine("ENter your username to signin ");
            string username = Console.ReadLine();
            Console.WriteLine("make your password  ");
            string password = Console.ReadLine();
            
            for(int i = 0; i < count; i++ )
            {
                if ( users[i].username == username && users[i].password == password)
                {
                    found = true; 
                }
              
            }
            if (found == true)
            {
                Console.WriteLine("You signned in successfully \n");
            }
            else
            {
                Console.WriteLine("Invalid Username  or password ");
            }

        }
        static void Main(string[] args)
        {

            while(true)
            {
                Console.Clear();
                Console.WriteLine("1- Sign in ");
                Console.WriteLine("2- Sign up ");
                Console.WriteLine("3- EXit ");
                Console.WriteLine("\n Enter your Option ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    signin();
                    Console.WriteLine("Enter any key to continue ");
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    signup();
                    Console.WriteLine("Enter any key to continue ");
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine("Enter any key to continue ");
                    Console.ReadKey();
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                    
                    return;
                }
            }

            Console.Read();
        }
    }
}
