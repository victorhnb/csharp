using System;
using System.Collections.Generic;

namespace ExeLista01
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            double salary;


            Console.WriteLine("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i=0; i < n; i++)
            {
                Console.WriteLine("Employee " + i+"#:");
                Console.WriteLine("Id: ");
                 id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Salary: ");
                salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));

            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int idSalaryIncrease = int.Parse(Console.ReadLine());
            
            Employee emp = list.Find(x => x.Id == idSalaryIncrease);
            if (emp != null)
            {

                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }

            else
            {
                Console.WriteLine("This id doesn't exists.");
            }



            foreach (var item in list)
            {
                Console.WriteLine(item);

            }

        }
    }
}
