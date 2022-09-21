using System;
using System.IO;

namespace FileFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";


            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }

            catch(IOException e)
            {
                Console.WriteLine("An error ocurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
