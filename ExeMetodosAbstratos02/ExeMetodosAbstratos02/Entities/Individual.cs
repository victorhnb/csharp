using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeMetodosAbstratos02.Entities
{
    class Individual : Payer
    {

        public int HealthExpenditure { get; set; }

        public Individual(string name, double anualIncome, int healthExpenditure) : base(name, anualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double TaxesPaid()
        {
            if (base.AnualIncome < 20000.00)
            {
                return 20000.00 * 0.15;
            }

            else
            {
                return (base.AnualIncome - 0.25) - (this.HealthExpenditure * 0.50);
            }         
        }


    }
}
