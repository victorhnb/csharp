﻿using System;
using System.IO;

namespace Using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file0.txt";

            try
            {
                //using (StreamReader sr = File.OpenText(path)) --> melhor 

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred. ");
                Console.WriteLine(e.Message);

            }


        }
    }
}

