using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge02
{
    class Member
    {
        public string name;
        public int memberID;
        public List<string> booksBought;
        public int numberOfBooksBought;
        public double moneyInBank;
        public double amountSpent;
        public Member()
        {
            name = "Unknown";
            memberID = 0;
            booksBought = new List<string>();
            numberOfBooksBought = 0;
            moneyInBank = 0;
            amountSpent = 0;
        }
        public Member(string n, int id, double money)
        {
            name = n;
            memberID = id;
            booksBought = new List<string>();
            numberOfBooksBought = 0;
            moneyInBank = money;
            amountSpent = 0;
        }

        public void SetName(string n)
        {
            name = n;
        }

        public void ModifyName(string n)
        {
            name = n;
        }

        public void ShowName()
        {
            Console.WriteLine("Member Name: " + name);
        }
        public void SetMemberID(int id)
        {
            memberID = id;
        }

        public void ShowMemberID()
        {
            Console.WriteLine("Member ID: " + memberID);
        }

        public void BuyBook(string bookName, double price)
        {
            if (price <= 0)
            {
                Console.WriteLine("Book price must be greater than zero.");
                return;
            }

            if (price > moneyInBank)
            {
                Console.WriteLine("Insufficient money in bank!");
                return;
            }

            booksBought.Add(bookName);
            numberOfBooksBought++;
            moneyInBank -= price;
            amountSpent += price;

            Console.WriteLine("Book purchased successfully!");
        }

        public void ModifyNumberOfBooks(int number)
        {
            if (number >= 0 && number == booksBought.Count)
            {
                numberOfBooksBought = number;
                Console.WriteLine("Number of books updated.");
            }
            else
            {
                Console.WriteLine("Invalid number. It must match the book list.");
            }
        }

        public void ShowNumberOfBooks()
        {
            Console.WriteLine("Number of Books Bought: " + numberOfBooksBought);
        }

        public void ShowBooks()
        {
            Console.WriteLine("\nBooks Bought:");

            if (booksBought.Count == 0)
            {
                Console.WriteLine("No books purchased yet.");
            }
            else
            {
                foreach (string book in booksBought)
                {
                    Console.WriteLine("- " + book);
                }
            }
        }

        public void ModifyAmountSpent(double amount)
        {
            if (amount >= 0)
            {
                amountSpent = amount;
                Console.WriteLine("Amount spent updated.");
            }
            else
            {
                Console.WriteLine("Amount cannot be negative.");
            }
        }

        public void ShowAmountSpent()
        {
            Console.WriteLine("Amount Spent: " + amountSpent);
        }

        public void ShowMoneyInBank()
        {
            Console.WriteLine("Money in Bank: " + moneyInBank);
        }

        public void DepositMoney(double amount)
        {
            if (amount > 0)
            {
                moneyInBank += amount;
                Console.WriteLine("Money deposited successfully.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        public void ShowMember()
        {
            Console.WriteLine("\n----- Member Information -----");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Member ID: " + memberID);
            Console.WriteLine("Number of Books Bought: " + numberOfBooksBought);
            Console.WriteLine("Money in Bank: " + moneyInBank);
            Console.WriteLine("Amount Spent: " + amountSpent);
            ShowBooks();
            Console.WriteLine("------------------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Member m = new Member();

            int choice;

            do
            {
                Console.WriteLine("\n===== MEMBER MENU =====");
                Console.WriteLine("1. Set Member Name");
                Console.WriteLine("2. Modify Member Name");
                Console.WriteLine("3. Show Member Name");
                Console.WriteLine("4. Set Member ID");
                Console.WriteLine("5. Buy a Book");
                Console.WriteLine("6. Show Books Bought");
                Console.WriteLine("7. Show Number of Books");
                Console.WriteLine("8. Modify Number of Books");
                Console.WriteLine("9. Modify Amount Spent");
                Console.WriteLine("10. Show Amount Spent");
                Console.WriteLine("11. Deposit Money");
                Console.WriteLine("12. Show Money in Bank");
                Console.WriteLine("13. Show All Member Information");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter member name: ");
                        m.SetName(Console.ReadLine() ?? "");
                        break;

                    case 2:
                        Console.Write("Enter new member name: ");
                        m.ModifyName(Console.ReadLine() ?? "");
                        break;

                    case 3:
                        m.ShowName();
                        break;

                    case 4:
                        Console.Write("Enter member ID: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                            m.SetMemberID(id);
                        else
                            Console.WriteLine("Invalid ID.");
                        break;

                    case 5:
                        Console.Write("Enter book name: ");
                        string bookName = Console.ReadLine() ?? "";

                        Console.Write("Enter book price: ");
                        if (double.TryParse(Console.ReadLine(), out double price))
                            m.BuyBook(bookName, price);
                        else
                            Console.WriteLine("Invalid price.");
                        break;

                    case 6:
                        m.ShowBooks();
                        break;

                    case 7:
                        m.ShowNumberOfBooks();
                        break;

                    case 8:
                        Console.Write("Enter number of books: ");
                        if (int.TryParse(Console.ReadLine(), out int number))
                            m.ModifyNumberOfBooks(number);
                        else
                            Console.WriteLine("Invalid number.");
                        break;

                    case 9:
                        Console.Write("Enter new amount spent: ");
                        if (double.TryParse(Console.ReadLine(), out double amount))
                            m.ModifyAmountSpent(amount);
                        else
                            Console.WriteLine("Invalid amount.");
                        break;

                    case 10:
                        m.ShowAmountSpent();
                        break;

                    case 11:
                        Console.Write("Enter deposit amount: ");
                        if (double.TryParse(Console.ReadLine(), out double deposit))
                            m.DepositMoney(deposit);
                        else
                            Console.WriteLine("Invalid amount.");
                        break;

                    case 12:
                        m.ShowMoneyInBank();
                        break;

                    case 13:
                        m.ShowMember();
                        break;

                    case 0:
                        Console.WriteLine("Program exited.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 0);
        }
    }
}

