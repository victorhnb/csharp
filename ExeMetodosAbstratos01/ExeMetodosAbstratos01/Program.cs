using ExeMetodosAbstratos01.Entities;
using ExeMetodosAbstratos01.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeMetodosAbstratos01
{
    class Program
    {
        static void Main(string[] args)


        {
            List<Shape> list = new List<Shape>();


            Console.Write("Enter the number of shapes: ");
            int shapes = int.Parse(Console.ReadLine());

            for (int i =1; i <= shapes; i++)
            {
                Console.Write("Shape #" + i + " data: \n");
                Console.Write("Retangle or Circle: (r/c) ");
                char typeShape = char.Parse(Console.ReadLine());

                Console.Write("Color: ");
                string sColor = Console.ReadLine();

                Color color = Enum.Parse<Color>(sColor);



                if (typeShape == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }

                else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));

                }


            }

            Console.WriteLine();
            Console.Write("SHAPE AREAS: \n");

            foreach (var item in list)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }




        }
    }
}
