using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 500.0);


            // UPCASTING 
            Account acc1 = bacc;

        }
    }
}
