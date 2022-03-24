using ExePropostoHerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace ExePropostoHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Product #" + i + " data: ");
                Console.Write("Common, used, or imported (c/u/i)?");
                char producttype = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (producttype == 'i')
                {
                    Console.Write("Customs Free: ");
                    double customsFree = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFree));
                }

                else if (producttype == 'u')
                {
                    Console.Write("Manufacture Date: ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }

                else
                {
                    list.Add(new Product(name,price));
                }

            }

        }
    }
}
