using System;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + f);

            Console.WriteLine("Digite  a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());



            Console.WriteLine("Dados atualizados:" + f.Nome +  ", $" + f.AumentaSalario(porcentagem));







        }
    }
}
