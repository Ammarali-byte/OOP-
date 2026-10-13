using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace challenge_01
{
    class Book
    {
        public string title;
        public string [] author = new string[4];
        public int noofauthors;
        public string publisher;
        public double isbn;
        public double price;
        public int stock;
        public string publicationyear;
        public Book()
        {
            title = "";
            noofauthors = 0;
            publisher = "";
            isbn = 0;
            price = 0;
            stock = 0;
            publicationyear = "";

        }
        public Book(string title , string[] author , int noofauthor
            ,string publisher , double isbn , double price , int stock , string publicationyear)
        {
            this .title = title;
            this .author = author;
            this .noofauthors = noofauthor;
            this .publisher = publisher;
            this .isbn = isbn;
            this .price = price;
            this .stock = stock;
            this .publicationyear = publicationyear;

        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string GetTitle()
        {
            return title; 
        }
        public int getcopies()
        {
            return stock;
        }
        public void setstock(int s)
        {
            this.stock = s;
        }
        public void updateprice(double newprice)
        {
            this.price = newprice;
        }
        public void ShowAuthors() 
        {
            if (noofauthors == 0) 
            {
                Console.WriteLine("No authors added.");
                return;
            }
            Console.WriteLine("Authors:"); 
            for (int i = 0; i < noofauthors; i++)
            {
                Console.WriteLine((i + 1) + ". " + author[i]);
            } 
        }
        public void DisplayBook() 
        {
            Console.WriteLine("\n----- Book Information -----");
            Console.WriteLine("Title: " + title);
            ShowAuthors();
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Stock: " + stock);
            Console.WriteLine("Year of Publication: "+ publicationyear); 
            Console.WriteLine("----------------------------"); }



    }
    internal class Program
    {
        static List<Book> books = new List<Book>();
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("1- Add a book ");
                Console.WriteLine("2- search a book by its title ");
                Console.WriteLine("3- search a book by ISBN ");
                Console.WriteLine("4- add stock of book ");
                Console.WriteLine("5- exit ");
                Console.WriteLine("Enter your option ");
                int option =  int.Parse(Console.ReadLine());
                if(option == 1 )
                {
                    addbook();
                    Console.WriteLine("Enter any ley to continue ");
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Console.Write("Enter title to search: ");
                    string searchTitle = Console.ReadLine() ?? "";
                    bool titleFound = false; 
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].title == searchTitle) 
                        { books[i].DisplayBook(); 
                            titleFound = true; }
                        }
                    if (!titleFound)
                    {
                        Console.WriteLine("Book not found.");
                        break;
                    }
                    Console.WriteLine("Enter any ley to continue ");
                    Console.ReadKey();

                }
                else if (option == 3)
                {
                    Console.Write("Enter ISBN to search: ");
                    double searchISBN = double.Parse(Console.ReadLine()) ;
                    bool isbnFound = false;
                    for (int i = 0; i < books.Count; i++) 
                    {
                        if (books[i].isbn == searchISBN) 
                        {
                            books[i].DisplayBook();
                            isbnFound = true; 
                        }
                    }
                    if(!isbnFound)
                    {
                        Console.WriteLine("Book not found");
                    }
                    Console.WriteLine("Enter any ley to continue ");
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    Console.WriteLine("Enter the isbn for a book to add stock ");
                    double searchISBN = double.Parse(Console.ReadLine());
                    bool isbnFound = false;
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].isbn == searchISBN)
                        {
                            isbnFound = true;
                            Console.WriteLine("Enter the stock of a book ");
                            int stock = int.Parse(Console.ReadLine());
                            books[i].stock = stock;
                            break;
                        }
                    }
                    if (!isbnFound)
                    {
                        Console.WriteLine("Book not found");
                    }
                    Console.WriteLine("Enter any ley to continue ");
                    Console.ReadKey();
                }
                else
                {
                    break;
                }
                

            }
            

        }
        static void addbook()
        {
            Console.WriteLine("Enter the title of book ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the number of authors ");
            int noofauthors= int .Parse(Console.ReadLine());
            string[] authors = new string [noofauthors];
            for(int i = 0; i < noofauthors; i++)
            {
                Console.WriteLine("Enter the name of author " + i);
                string author = Console.ReadLine();
                authors[i] = author; 

            }
            Console.WriteLine("Enter the name of publisher ");
            string publisher = Console.ReadLine();
            Console.WriteLine("Enter the isbn number");
            double isbn = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of book ");
            double  price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of stock  ");
            int stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the publication year of book ");
            string publicationyear = Console.ReadLine();

            Book book1 = new Book(title, authors, noofauthors, publisher, isbn, price, stock, publicationyear);
            books.Add(book1);
        }

        
    }
}
