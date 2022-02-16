using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);


            // UPCASTING 
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1003, "Anna", 0.0, 0.01);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(300.0);

            if (acc4 is SavingsAccount)
            {
                Console.WriteLine("Is SavingsAccounts");
            }

            else
            {
                Console.WriteLine("Not SavingsAccount");
            }

            // Usando Sobreposicao

            Account sbp1 = new Account(1001, "Alex", 500.0);
            Account sbp2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            sbp1.withDraw(10.0);
            sbp2.withDraw(10.0);

            Console.WriteLine(sbp1.Balance);
            Console.WriteLine(sbp2.Balance);



        }
    }
}
