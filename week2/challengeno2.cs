
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challengeno2
{
    public class Product
    {
        public int id;
        public string product_name;
        public int price;
        public string category;
        public string brandname;
        public string country;
        public Product( int id , string product_name, int price, string category, string brandname, string country)
        {
            this.id = id;
            this .product_name = product_name;
            this.price = price;
            this.category = category;
            this.brandname = brandname;
            this.country = country;
        }
        //public void showproduct()
        //{
        //    Console.WriteLine("PRODUCT ID = {0}||PRODUCT NAME = {1}||PRODUCT PRICE = {2}||PRODUCT CATEGORY = {3}||PRODUCT BRANDNAME = {4}||PRODUCT COUNTRY = {5}"
        //        , id,product_name,price,category,brandname,country);

        //}

    }
    internal class Program
    {
        static Product[] products = new Product[100];
        static int count = 0;
        static double worth = 0;
        static void addproduct()
        {

            Console.WriteLine("Enterv the product id ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enterv the product name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enterv the product price ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enterv the product category ");
            string category = Console.ReadLine();
            Console.WriteLine("Enterv the product brand ");
            string brand = Console.ReadLine();
            Console.WriteLine("Enterv the product country ");
            string country = Console.ReadLine();
            Product product = new Product(id, name, price, category, brand, country);
            products[count] = product;
            count += 1;
            
        }
        static void showproduct()
        {
            for (int i = 0;i < count ; i++)
            {
                Console.WriteLine("PRODUCT ID = {0}||PRODUCT NAME = {1}||PRODUCT PRICE = {2}||PRODUCT CATEGORY = {3}||PRODUCT BRANDNAME = {4}||PRODUCT COUNTRY = {5}"
                 , products[i].id, products[i].product_name, products[i].price, products[i].category, products[i].brandname, products[i].country);
            }
        }
        static void showworth()
        {
            worth = 0;
            for (int i = 0; i < count; i++)
            { 
                worth+= products[i].price ;
            }
            Console.WriteLine("Total worth of store = " + worth);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("====== Welcome to product management system ===== ");
            while (true)
            {
                Console.WriteLine("1-Add Product ");
                Console.WriteLine("2-show product ");
                Console.WriteLine("3-show total worth of store ");
                Console.WriteLine("4-exit ");
                Console.WriteLine("\n Enter your option ");
                int option = int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    addproduct();
                }
                else if (option == 2)
                {
                    showproduct();
                }

                else if (option == 3)
                {
                    showworth();
                }

                else if (option == 4)
                {
                    break;
                }
                else
                {
                    return;
                }



            }
            Console.Read();
        }
    }
}
