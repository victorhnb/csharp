
using ExeMetodosAbstratos01.Enums;

namespace ExeMetodosAbstratos01.Entities
{
    class Circle : Shape
    {

        public double radious { get; set; }

      
        public Circle(double radious, Color color) : base (color)
        {
            this.radious = radious;
        }

        public override double Area()
        {
            return 3.14 * (radious * radious);
        }
    }
}
