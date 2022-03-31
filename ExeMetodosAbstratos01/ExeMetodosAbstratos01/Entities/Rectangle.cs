using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeMetodosAbstratos01.Entities
{
    class Rectangle
    {

        public double width { get; set; }
        public double height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }


    }
}
