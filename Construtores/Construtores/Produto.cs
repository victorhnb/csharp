using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public double Quantidade; 

        public Produto()
        {
            Quantidade = 5;
        }

           
        
        public Produto(string nome, double preco) : this ()
        {
            Nome = nome;
            Preco = preco;
        }


        public override string ToString()
        {
            return Nome+ " \n" + Preco.ToString("F2") + " \n" + Quantidade + "\n" + ;
        }
    }
}
