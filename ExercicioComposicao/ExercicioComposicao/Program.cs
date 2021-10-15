using ExercicioComposicao.Enums;
using System;

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
            double baseSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());







        }
    }
}
