using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();
            Produto p2 = new Produto();
            Produto p3 = new Produto();


            p.SetNome("TV 4K");
            p.SetPreco(2000);
            p.SetQuantidade(4);

            p2.Nome = "Celular LG";
            p2.Preco = 20000;
            p2.Quantidade = 2;

            p3.Valor = 10;

            



            // A linha abaixo imprime os resultados utilizando os metodos Gets

            Console.WriteLine(p.GetNome() + "\n" + p.GetPreco() + "\n" + p.GetQuantidade());

            // A linha abaixo imprime os resultados utilizando as propreties

            Console.WriteLine(p2.Nome + "\n" + p2.Preco+ "\n" + p2.Quantidade);

            // A linha abaixo imprime os resultados utilizando a AutoPropertie

            Console.WriteLine(p3.Valor);



        }
    }
}
