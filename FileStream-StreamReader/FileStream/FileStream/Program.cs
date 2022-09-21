using System;
using System.IO;


    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            FileStream FS = null;
            StreamReader sr = null;
        
            try
        {
            //mais inchuto
            // sr = File.OpenText(path); elimina a necessidade de instanciar mais um objeto (FS)

            FS = new FileStream(path, FileMode.Open);
            sr = new StreamReader(FS);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            
        }

        catch (IOException e)
        {
            Console.WriteLine("An error ocurred.");
            Console.WriteLine(e.Message);

        }

        finally
        {
            if(sr != null)
            {
                sr.Close();
            }
            if (FS != null)
            {
                FS.Close();
            }
        }



    }
    }

