using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator c1 = new Calculator();

            int a = 3;
            c1.Triple(ref a);
            Console.WriteLine(a);

        }
    }
}
