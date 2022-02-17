using ExercicioPropostoHeranca01.Entities;
using System;
using System.Collections.Generic;

namespace ExercicioPropostoHeranca01
{
    class Program
    {
        static void Main(string[] args)


        {
            List<Employee> employee;
            
            Console.Write("Enter the number of employees: ");
            int employeesNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= employeesNumber; i++)
            {
                Console.WriteLine("Employee " + i + "#" + " data:");
                Console.WriteLine("Outsorced? (y/n)");
                char employeeType = char.Parse(Console.ReadLine());
                if (employeeType == 'n')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Valuer per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    employee = new List<Employee>();
                    employee.Add(new Employee(name, hours, valuePerHour));

                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Valuer per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    employee =  new List<OutsourcedEmployee>();
                    employee.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));

                }

                foreach (var item in employee)
                {
                    Console.WriteLine(employee);
                }

            }

        }
    }
}
