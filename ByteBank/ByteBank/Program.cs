using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente c1 = new ContaCorrente();
            ContaCorrente c2 = new ContaCorrente();

            //Console.WriteLine("Saldo atual: " + c1.saldo + "$");
            //c1.Sacar(50);
            //Console.WriteLine("Saldo atual: " + c1.saldo + "$");
            //c1.Depositar(500);
            //Console.WriteLine("Saldo atual: " + c1.saldo + "$");
            //c1.Sacar(400);
            //Console.WriteLine("Saldo atual: " + c1.saldo + "$");

            Console.WriteLine("Saldo atual da conta n1 é: " + c1.saldo);
            Console.WriteLine("Saldo atual da conta n1 é: " + c2.saldo);

            c1.Transferir(150, c2);


            Console.WriteLine("Saldo atual da conta n1 é: " + c1.saldo);
            Console.WriteLine("Saldo atual da conta n1 é: " + c2.saldo);










        }
    }
}
