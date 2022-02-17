using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoHeranca01.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public int ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, int valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        protected double payment()
        {
            return Hours * ValuePerHour;
        }

    }
}
