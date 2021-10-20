using System;
namespace ExercicioComposicao
{
    class HourContract
    {

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public double Hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, double hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }


        public override string ToString()
        {
            return " Date: " + Date.ToString("DD/MMMM/yyyy") + "\n" + "Value Per Hour: " + ValuePerHour + "\n" + "Hours: " + Hours;
        }
    }
}
