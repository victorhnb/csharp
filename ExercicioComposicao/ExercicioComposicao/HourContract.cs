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

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }


        public override string ToString()
        {


            return "\n" + "------------------" + "\nContract: "+ 
                "\n" + "Date: " + Date.ToString("MMMM/yyyy") + 
                "\n" + "Value Per Hour: " + ValuePerHour + "\n" + "Hours: " + Hours;
        }
    }
}
