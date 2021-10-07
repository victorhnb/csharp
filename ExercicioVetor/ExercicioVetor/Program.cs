/*A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados
pelos números de 0 a 9.

Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma quantidade N representando o número de estudantes que vão alugar quaratos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome e email do estudante, bem como qual dos quartos
ele escolheu (0 a 9). Suponho que seja escolhido um quarto vago. Ao final do seu programa, deve imprimir um relatorio de todas as ocupações de pensionato, por ordem de quarto.
*/


using System;

namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=1;
            Console.WriteLine("How many room will be rented? ");
            int rooms = int.Parse(Console.ReadLine());

            Quarto[] hospede = new Quarto[10];

            for (int i =0; i < rooms; i++)
            {
                
                Console.WriteLine("Rent #" + cont);
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Room: ");
                int room = int.Parse(Console.ReadLine());
<<<<<<< HEAD
                hospede[room] = new Quarto(name, email, room);
=======
>>>>>>> 397585dc07782fe8754f85e6540a73447d7c5971
                cont++;
                
            }


            Console.WriteLine("Busy room: ");
            for (int j=0; j < hospede.Length; j++)
            {
                if (hospede[j] != null)
                {
                    Console.WriteLine(hospede[j]);
                }
            }

<<<<<<< HEAD

=======
>>>>>>> 397585dc07782fe8754f85e6540a73447d7c5971
        }
    }
}
