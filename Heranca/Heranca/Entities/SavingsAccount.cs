using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class SavingsAccount : Account
    {

        public double InteresetRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interesetRate) : base(number, holder, balance)
        {
            InteresetRate = interesetRate;
        }


        public void updateBalance()
        {
            Balance += Balance * InteresetRate;
        }

        public override void withDraw(double amount)
        {
            Balance -= amount;
        }


    }
}
