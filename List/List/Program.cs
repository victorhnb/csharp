using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Victor Hugo");
            list.Add("Leo");
            list.Add("Eduardo");

            // Tamanho da Lista
            Console.WriteLine(list.Count);

            // Insere ranny na posição 2
            list.Insert(2, "Ranny");

            // Mostra em qual posição da lista está o elemento com o valor "Leo"
            Console.WriteLine(list.IndexOf("Leo"));

            //Percorre os elementos da lista
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}
