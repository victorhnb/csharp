using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public int numeroAgencia;
        public int numeroConta;
        public double saldo = 200;

        public void Sacar(double valor)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("O valor solicitado excede o limite da conta.");
            }
            else
            {
                this.saldo -= valor;
            }


        }



        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }

        }
    }
}