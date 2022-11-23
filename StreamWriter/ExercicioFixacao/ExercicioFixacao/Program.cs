using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ExercicioFixacao
{
     class Program
    {
        static void Main(string[] args)
        {


            string sourcePath = @"C:\temp\projects\StreamWriter\ExercicioFixacao\out\summary.csv";
            string targetPath = @"C:\temp\projects\StreamWriter\ExercicioFixacao\out\summary2.csv";

              //StreamWriter sw = null;

            try
            {

                
                
                    string[] lines = File.ReadAllLines(sourcePath);
                    using (StreamWriter sw = File.AppendText(targetPath))
                    {

                        foreach (var item in lines)
                        {
                            var fields = item.Split(',');

                            var operation = Convert.ToDouble(fields[1]) * Convert.ToDouble(fields[2]);


                            OutPutFile of = new OutPutFile(fields[0], operation);

                            
                           sw.Write(of.Name + "," + of.Price.ToString("F2", CultureInfo.InvariantCulture) + "\n");


                        }
                    }
                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

           /* finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }*/

        }
    }
}
