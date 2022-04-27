using ExercicioPropostoExcecoes.Exceptions;
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

        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int accountNumber, string holder, double balance, double withDrawLimit)
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
            if (amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw Limit");
            }

            else if (amount < 0) {

                throw new DomainException("Amount can not be negative. ");
            }

            else if  (amount > Balance) {

                throw new DomainException("Not enought balance. ");
            }

            Balance -= amount;
        }
    }
}
