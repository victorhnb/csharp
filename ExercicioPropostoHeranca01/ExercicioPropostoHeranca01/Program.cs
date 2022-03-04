using ExercicioPropostoHeranca01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioPropostoHeranca01
{
    class Program
    {
        static void Main(string[] args)


        {
            List<Employee> employee = new List<Employee>();
            
            Console.Write("Enter the number of employees: ");
            int employeesNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= employeesNumber; i++)
            {
                Console.WriteLine("Employee " + i + "#" + " data:");
                Console.WriteLine("Outsorced? (y/n)");
                char employeeType = char.Parse(Console.ReadLine());
                
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Valuer per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    
                    if (employeeType == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employee.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                                   
                    else
                {
                    employee.Add(new Employee(name, hours, valuePerHour));
                }
                            

              
            }

            Console.WriteLine("\nPAYMENT: \n");

            foreach (var item in employee)
            {
                Console.WriteLine(item.Name + " - " + "$" + item.payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
