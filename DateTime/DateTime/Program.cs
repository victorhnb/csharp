using System;


    class Program
    {
        static void Main(string[] args)
        {

        int i = 1, x = 0, y = 1;
        while (i <= 2)
        {
            x += i;
            y = +x;
            i++;
        }
        Console.WriteLine(y);
    }
}

