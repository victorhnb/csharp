﻿

namespace ExercicioPropostoHeranca01.Entities
{
    class OutsourcedEmployee : Employee
    {

        public double additionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalcharge) : base(name, hours, valuePerHour)
        {
            additionalCharge = additionalcharge;

        }

        public override double payment()
        {
            return base.payment() + (additionalCharge * 0.110);
        }

        public override string ToString()
        {
            return Name + " " + "-" + "$ " + payment();
        }

    }
}
