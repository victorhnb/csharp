using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeMetodosAbstratos02.Entities
{
    class Company : Payer


    {

        public int Employee { get; set; }

        public Company(string name, double anualIncome, int employee) : base(name,anualIncome)
        {
            Employee = employee;
        }

        public override double TaxesPaid()
        {
            if (Employee >= 25)
            {
                return base.AnualIncome * 0.14;
            }
            else
            {
                return base.AnualIncome * 0.16;
            }
        }
    }
}
