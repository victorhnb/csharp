using ExercicioPropostoExcecoes.Entities;
using ExercicioPropostoExcecoes.Exceptions;
using System;
using System.Globalization;

namespace ExercicioPropostoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter account data\n");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("WithDraw Limit: ");
                double withdrawlimit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Account acc1 = new Account(number, holder, balance, withdrawlimit);

                Console.Write("Enter amount for withdraw: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc1.WithDraw(value);

                Console.WriteLine("New Balance: " + acc1.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (DomainException e)
            {
                Console.Write("Withdraw error: " + e.Message);
            }

            catch (Exception e)
            {
                Console.Write("Unexpected error: " + e.Message);
            }

        }
    }
}
