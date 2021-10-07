using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    class Aluno

    {
        public string Nome;
        public double Nota1;
        public double Nota2; 
        public double Nota3;

        public double NotaFinal()
        {
          return this.Nota1 + this.Nota2 + this.Nota3;
                 
        }

        public void Resultado()
        {
            if (NotaFinal() >= 60)
            {
                Console.WriteLine("Aprovado! ");
                Console.WriteLine("NOTA FINAL : " + NotaFinal());

            }

            else
            {
                Console.WriteLine("Reprovado! ");
                Console.WriteLine("NOTA FINAL : " + NotaFinal());
                Console.WriteLine("FALTAM: " + (100 - NotaFinal()));


            }
        }


    }
}
