

namespace ExercicioPropostoHeranca01.Entities
{
    class OutsourcedEmployee : Employee
    {

        public double additionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, int valuePerHour, double additionalcharge) : base(name, hours, valuePerHour)
        {
            additionalCharge = additionalcharge;

        }



    }
}
