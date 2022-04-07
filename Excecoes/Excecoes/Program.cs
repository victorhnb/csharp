using System;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui vai toda a logica implementada do codigo
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            // Neste bloco capturar a exceção, caso de erro na logica
            catch (DivideByZeroException)
            {
                Console.WriteLine(" Division by zero is not allowed. ");
            }

            catch (FormatException)
            {
                Console.WriteLine("Letters are not allowed. ");
            }

            // Aqui e executado independente de ter ocorrido ou não uma exceção
            finally
            {

            }
        }
    }
}
