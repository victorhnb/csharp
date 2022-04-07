using ExeMetodosAbstratos02.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeMetodosAbstratos02
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Payer> list = new List<Payer>();
            double sum = 0.0;

            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= taxPayers; i++)
            {
                Console.Write("Tax payer #" + i + " data: \n");
                Console.Write("Individual or company (i/c)? ");
                char payerType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (payerType == 'i')
                {
                    Console.Write("Health expeditures: ");
                    double healthExpediture = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpediture));
                }

                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, employees));
                }
            }

            Console.Write("\nTAXES PAID: \n");

            foreach (var item in list)
            {
                Console.WriteLine(item.Name + ": " + item.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
                sum += item.TaxesPaid();
            }

                          
           

            Console.Write("\nTOTAL TAXES $ " + sum.ToString("F2", CultureInfo.InvariantCulture)+ "\n");

                


        }
    }
}
