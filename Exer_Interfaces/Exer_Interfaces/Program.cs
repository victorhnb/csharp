using System;
using System.Globalization;

namespace Exer_Interfaces
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installment: ");
            int numberInstallment = int.Parse(Console.ReadLine());  


        }
    }
}
