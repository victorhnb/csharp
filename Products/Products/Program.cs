using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {

            Product p = new Product();
            Console.WriteLine("Enter with products data: ");
            Console.WriteLine("Name: ");
            p.name = Console.ReadLine();
            Console.WriteLine("Price: ");
            p.price = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantity: ");
            p.quantity = int.Parse(Console.ReadLine());


            Console.WriteLine("Data: " + p.name + ", "+ p.quantity + " unities" + ", Total " + p.TotalValueInStock());


            Console.WriteLine("Enter the number of products to add to stock: ");
            p.AddProducts(int.Parse(Console.ReadLine()));
            Console.WriteLine("Update Data: " + p.name + ", " + p.quantity + " unities" + ", Total " + p.TotalValueInStock());
            Console.WriteLine("Enter the number of products to remove to stock: ");
            p.RemoveProducts(int.Parse(Console.ReadLine()));
            Console.WriteLine("Update Data: " + p.name + ", " + p.quantity + " unities" + ", Total " + p.TotalValueInStock());








        }
    }
}
