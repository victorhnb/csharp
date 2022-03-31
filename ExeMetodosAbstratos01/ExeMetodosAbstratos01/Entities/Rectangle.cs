

using ExeMetodosAbstratos01.Enums;

namespace ExeMetodosAbstratos01.Entities
{
    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle (double width, double height, Color color) : base (color)   
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
