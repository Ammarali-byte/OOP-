using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmenttask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction(
                101,
                "Laptop",
                85000,
                "22-09-2026",
                "09:30 PM"
            );
            Transaction t2 = new Transaction(
              t1.transID,
              t1.pname,
              t1.pquantity,
              t1.date,
              t1.time
          );
            Console.WriteLine("The transaction before changing are ");
            t1.Display();
        
            t2.Display();
            // changing the name and quantity
            t1.pname = "Mobile Phone";
            t1.pquantity = 60000;
            t2.pname = "Mobile Phone Speakers";
            t2.pquantity = 70000;
            Console.WriteLine("The transaction after changing are ");
            t1.Display();

            t2.Display();


            Console.Read();
        }
    }
    class Transaction
    {
         public int transID;
        public string pname;
        public double pquantity;
        public string date;
        public string time;

        public Transaction(int ID , string p ,double quantity, string da, string t )
        {
            transID = ID;
            pname = p;
            pquantity = quantity;
            date = da;
            time = t;


        }
        public void Display()
        {
            Console.WriteLine("Transaction ID: {0} " , transID);
            Console.WriteLine("Product Name: {0}" , pname);
            Console.WriteLine("Amount: {0}" , pquantity);
            Console.WriteLine("Date: {0}" , date);
            Console.WriteLine("Time: {0}" , time);
            Console.WriteLine();
        }
    }
}
