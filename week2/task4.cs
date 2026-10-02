
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Book
    {
        public int ID;
        public string Title;    public string Author;
        public Book(int ID , string Title , String  Author )
        {
            this.ID = ID;
            this.Title = Title;
            this.Author = Author;

        }
        public void  Displaybook()
        {
            Console.WriteLine("ID = {0} || Title = {1} || Author = {2} ", ID , Title , Author);
        }

    }
    internal class Program
    {
       static List<Book> library = new List<Book>();   

        static void addbook()
        {
            Console.WriteLine("Enter the Id of Book  ");
            int id = int.Parse(Console.ReadLine());         
            Console.WriteLine("Enter the Title of Book  ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the Author of Book  ");
            string author = Console.ReadLine();
            Book newbook = new Book (id, title, author);
            library.Add(newbook);
            
         

        }
        static void delbook()
        {
            Console.WriteLine("Enter the Id of Book to delete");
            int id = int.Parse(Console.ReadLine());

            Book bookToRemove = null;

            foreach (Book newbook in library)
            {
                if (newbook.ID == id)
                {
                    bookToRemove = newbook;
                    break;
                }
            }

            if (bookToRemove != null)
            {
                library.Remove(bookToRemove);
                Console.WriteLine("Book Removed From Library successfully");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
        static void displaybooks()

        {
            foreach(Book newbook in library )
            {
                newbook.Displaybook();
            }
        }
        static void Main(string[] args)

        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n===== LIBRARY MENU =====");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    addbook();
                    Console.WriteLine("Enter any Key to continue ");
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    displaybooks();
                    Console.WriteLine("Enter any Key to continue ");
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    delbook();
                    Console.WriteLine("Enter any Key to continue ");
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter any Key to continue ");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("invalid choice");
                    return;
                }
            }
        }
    }
}
