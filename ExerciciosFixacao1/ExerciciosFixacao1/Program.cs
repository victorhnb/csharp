using System;

namespace ExerciciosFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor = 0;
            double saque = 0;

            ContaCorrente conta; 


            Console.WriteLine("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            string TitularConta = Console.ReadLine();


            Console.WriteLine("Deseja fazer um depósito inicial? ");
            char resposta = char.Parse(Console.ReadLine());

            

            if (resposta == 's')
            {
                Console.WriteLine("Digite o valor do deposito inicial: ");
                valor = double.Parse(Console.ReadLine());
                conta = new ContaCorrente(numConta, TitularConta, valor);
             }

            else
            {
                conta = new ContaCorrente(numConta, TitularConta);
            }

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);


            Console.WriteLine("Digite um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito = deposito;

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("Entre um valor pra saque: ");
            saque = double.Parse(Console.ReadLine());


            conta.Saque = saque;


            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);









        }
    }
}
