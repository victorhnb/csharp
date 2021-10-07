using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)

        {

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            r.Altura = double.Parse(Console.ReadLine());
            r.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + r.Area());
            Console.WriteLine("PERIMETRO = " + r.Perimetro());
            Console.WriteLine("DIAGONAL = " + r.Diagonal());




        }
    }
}
