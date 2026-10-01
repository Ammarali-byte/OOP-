using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            atm c1 = new atm();
            Console.WriteLine("Welcome to ATM ");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1- Deposit Money ");
                Console.WriteLine("2- Withdraw Money ");
                Console.WriteLine("3-  Check balance  ");
                Console.WriteLine("4- transaction record  ");
                Console.WriteLine("5 - Exit  ");
                Console.Write("Enter your opton : ");
                int option = int .Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    Console.Write("Enter the amount to deposit ");
                    double amount = double.Parse(Console.ReadLine());
                    c1.deposit(amount);
                    Console.WriteLine("Enter any key to continue ");
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Console.Clear();
                    Console.Write("Enter the amount to withdraw  ");
                    double amount = double.Parse(Console.ReadLine());
                    c1.withdraw(amount);
                    Console.WriteLine("Enter any key to continue ");
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.Clear();
                    c1.checkbalance();
                    Console.WriteLine("Enter any key to continue ");
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    Console.Clear();
                    c1.transactionhistory();
                    Console.WriteLine("Enter any key to continue ");
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid Input ");
                    Console.ReadKey();
                }
            }
            

        }
    }
    public class atm
    {
       private double balance = 6748264;
        private List<string> transactions = new List<string>();

        public void  deposit(double amount )
        {
           
            balance = balance + amount;
            transactions.Add("deposit: " + amount);

          
            
        }
        public void withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance = balance - amount;
                transactions.Add("Withdrawal: " + amount);
                
            }
            else
            {
                Console.WriteLine("Insufficent balance ");
            }
        }
        public void  checkbalance( )
        {
            Console.Write("your ammount is {0}", balance);
        }
        public void transactionhistory()
        {
            Console.WriteLine("transacctions are :");
          foreach (string transaction in transactions)
            {
                Console.WriteLine(transaction);
            }
        }

    }
}
