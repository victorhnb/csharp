
using ExercicioComposicao.Enums;

namespace ExercicioComposicao
{
    class Worker
    {
        public string  Name { get; set; }
        public int BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }

        public void AddContract(HourContract contract)
        {

        }

        public void RemoveContract(HourContract contract)
        {

        }

        public double Income(int year, int month)
        {
            return 0;
        }
    }
}
