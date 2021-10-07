using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int []  vect = new int[] { 1, 30, 40, 50 };

            // item é apelido
            // vect é o vetor
            foreach (var item in vect)
            {
                Console.WriteLine(item);
            }
        }
    }
}
