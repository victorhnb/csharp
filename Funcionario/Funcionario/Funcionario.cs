using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    class Funcionario
    {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return this.SalarioBruto - this.Imposto;
        }

        public double AumentaSalario(double porcentagem)
        {

            return SalarioLiquido() + this.SalarioBruto * porcentagem / 100;
            // return SalarioLiquido() + Ajuste;
            // return porcentagem;                   
        }


        public override string ToString()
        {
            return Nome + ", " + "$" + SalarioLiquido();
        }

    }
}

