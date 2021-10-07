using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Produto
    {
        // Atributos privados

        private string _nome;
        private double _preco;
        private int _quantidade;

        // Autopropriedade abaixo
        public int Valor { get; set; }

        // Metodos Get e Set Implementados
        public string GetNome()
        {
            return _nome;
        }

        public string SetNome (string nome)
        {
           return _nome = nome;
        }


        public double GetPreco()
        {
            return _preco;
        }

        public double SetPreco(double preco)
        {
            return _preco = preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public int SetQuantidade(int quantidade)
        {
            return _quantidade = quantidade;
        }

        // Exemplo abaixo de criação de propreties para Get e Set
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double Preco
        {
            get { return _preco; }
            set { _preco = value;  }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }



    }
}
