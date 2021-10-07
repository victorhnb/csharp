/*Fazer um programa para ler um número inteiro N e altura de N pessoas. Armazene as N alturas em um vetores.
 * Em seguida, mostrar a altura média dessas pessoas.*/

using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            double average = 0;
            entrada = int.Parse(Console.ReadLine());

            for (int i =0; i < entrada; i++)
            {
                double[] altura = new double[entrada];
                altura[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                average += altura[i]; 
            }

            Console.WriteLine("AVERAGE HEIGHT= " + (average / entrada).ToString("F2"));
            
        }
    }
}
