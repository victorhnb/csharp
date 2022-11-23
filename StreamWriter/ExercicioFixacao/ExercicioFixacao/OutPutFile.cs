using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
     class OutPutFile
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public OutPutFile(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
