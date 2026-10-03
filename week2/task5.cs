using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        // Constructor
        public BankAccount(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        // Deposit function
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                Console.WriteLine("Money deposited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }
        }

        // Withdraw function
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine("Money withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Invalid amount or insufficient balance.");
            }
        }

        // Display account details
        public void Display()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("-----------------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            while (true)
            {
                Console.WriteLine("\n===== BANK SYSTEM =====");
                Console.WriteLine("1. Open New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Account details ");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Account Number: ");
                    int accountNumber = int.Parse(Console.ReadLine());

                    Console.Write("Enter Holder Name: ");
                    string holderName = Console.ReadLine();

                    Console.Write("Enter Opening Balance: ");
                    double balance = double.Parse(Console.ReadLine());

                    BankAccount account =
                        new BankAccount(accountNumber, holderName, balance);

                    accounts.Add(account);

                    Console.WriteLine("Account opened successfully.");
                }

                else if (choice == 2)
                {
                    Console.Write("Enter Account Number: ");
                    int accountNumber = int.Parse(Console.ReadLine());

                    BankAccount foundAccount = null;

                    foreach (BankAccount account in accounts)
                    {
                        if (account.AccountNumber == accountNumber)
                        {
                            foundAccount = account;
                            break;
                        }
                    }

                    if (foundAccount != null)
                    {
                        Console.Write("Enter amount to deposit: ");
                        double amount = double.Parse(Console.ReadLine());

                        foundAccount.Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine("Account not found.");
                    }
                }

                else if (choice == 3)
                {
                    Console.Write("Enter Account Number: ");
                    int accountNumber = int.Parse(Console.ReadLine());

                    BankAccount foundAccount = null;

                    foreach (BankAccount account in accounts)
                    {
                        if (account.AccountNumber == accountNumber)
                        {
                            foundAccount = account;
                            break;
                        }
                    }

                    if (foundAccount != null)
                    {
                        Console.Write("Enter amount to withdraw: ");
                        double amount = double.Parse(Console.ReadLine());

                        foundAccount.Withdraw(amount);
                    }
                    else
                    {
                        Console.WriteLine("Account not found.");
                    }
                }

                else if (choice == 4)
                {
                    if (accounts.Count == 0)
                    {
                        Console.WriteLine("No accounts available.");
                    }
                    else
                    {
                        Console.WriteLine("\n===== ALL ACCOUNTS =====");

                        foreach (BankAccount account in accounts)
                        {
                            account.Display();
                        }
                    }
                }

                else if (choice == 5)
                {
                    Console.WriteLine("Program ended.");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }
}