using System;
using System.IO;

class Program
    {
        static void Main(string[] args)
        {

        string path = @"c:\temp\myfolder";

        try
        {
            // lista os diretorios no path indicado
            var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS: ");

            foreach (string s in folders)
            {
                Console.WriteLine(s);
            }
            // lista os arquivos no path de origem informado informado
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine();
            Console.WriteLine("FILES: ");

            foreach (string s in files)
            {
                Console.WriteLine(s);
            }

            // cria um diretorio a partir do path de origem

            Directory.CreateDirectory(path + @"\newfolder");



        }
        catch (IOException e)
        {

            Console.WriteLine("An error ocorrued.");
            Console.WriteLine(e.Message);

        }

    }
    }

