using System;
using System.Globalization;
using System.Collections.Generic;
using Ex_Product_ImportedCommomUsed.Entities;

namespace Ex_Product_ImportedCommomUsed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i= 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                while (ch != 'I' && ch != 'i' && ch != 'C' && ch != 'c' && ch != 'U' && ch != 'u')
                {
                    Console.WriteLine("Invalid Letter..");
                    Console.Write("Enter again letter: Common, used or imported (c/u/i) -->   ");
                    ch = char.Parse(Console.ReadLine());
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: R$ ");
                double price = double.Parse(Console.ReadLine(), CI);

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Customs fee: R$ ");
                    double customsFee = double.Parse(Console.ReadLine(), CI);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }


        }
    }
}
