using System;
using System.Globalization;

namespace Exe_MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConversorDeMoeda conversor = new ConversorDeMoeda();
            Console.WriteLine("Qual a cotação do dolar: ");
            ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos Dolares você vai comprar: ");
            ConversorDeMoeda.Real = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.ConverteMoeda().ToString("F2"));
        }
    }
}
