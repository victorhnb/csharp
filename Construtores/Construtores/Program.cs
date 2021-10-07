using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.00);

            Produto p2 = new Produto
            {
                Nome = "Celular",
                Preco = 1500.00
            };

            Produto p3 = new Produto();

            Console.WriteLine(p3);
     //       Console.WriteLine(p2);

        }
    }
}
