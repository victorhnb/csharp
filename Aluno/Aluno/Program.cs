using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a = new Aluno();
            Console.WriteLine("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());

            a.NotaFinal();
            a.Resultado();




        }
    }
}
