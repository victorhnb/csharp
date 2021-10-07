﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetor
{
    class Quarto
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Quarto(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

        public override string ToString()
        {
            return Room + ": " + Name + ", " + Email;
        }
    }
}
