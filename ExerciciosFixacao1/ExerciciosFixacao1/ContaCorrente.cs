using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFixacao1
{
    class ContaCorrente
    {

        public  int NumeroConta { get; set; }
        public  string TitularConta { get; set; }
        public  double Saldo { get; private set; }

        public ContaCorrente()
        {

        }

        public ContaCorrente(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

        public ContaCorrente(int numeroConta, string titularConta, double saldo) : this(numeroConta, titularConta)
        {
            Saldo = saldo;
        }

        public double Deposito
        {
            set { Saldo  += value; }
        }

        public  double Saque {

            set { Saldo -= value + 5; }
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + TitularConta + ", Saldo: " + Saldo;
        }



    }
}
