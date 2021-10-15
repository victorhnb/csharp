﻿using ExercicioComposicao.Enums;
using System;
using System.Globalization;

namespace ExercicioComposicao
{
    class Program
    {
        static void Main(string[] args)
        {

            // Le o departamento
            Console.WriteLine("Enter Department Name: ");
            string dpName = Console.ReadLine();
            Department dp = new Department(dpName);

            //Entrada com os dados do trabalhador
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior: ");
            string level = Console.ReadLine();
            WorkerLevel wl = Enum.Parse<WorkerLevel>(level);
            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());

            for (int i=1; i <= contracts; i++)
            {
                Console.WriteLine("Enter " +i+ "# data contract: " );
                DateTime date = new DateTime();
                date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration per hour: ");
                double durationPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }







        }
    }
}
