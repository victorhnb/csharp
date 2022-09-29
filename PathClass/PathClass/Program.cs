using System;
using System.IO;

namespace PathClass
{
     class Program
    {
        static void Main(string[] args)
        {

            string path = @"c:\temp\myfolder\file1.txt";

            // busca a pasta que se encontra o arquivo

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);

            Console.WriteLine("PathSeparator: " + Path.PathSeparator);

            Console.WriteLine("GetDirectoryName: "  + Path.GetDirectoryName(path));

            Console.WriteLine("GetFileName: " + Path.GetFileName(path));

            Console.WriteLine("GetExtension: " + Path.GetExtension(path));


            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));


        }
    }
}
