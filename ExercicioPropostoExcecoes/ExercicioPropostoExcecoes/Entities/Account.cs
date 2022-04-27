using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoExcecoes.Entities
{
    class Account
    {

        public int AccountNumber { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public int WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int accountNumber, string holder, double balance, int withDrawLimit)
        {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            Balance -= amount;
        }
    }
}
