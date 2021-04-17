using Exerc_Abstrato.Entities.Enums;

namespace Exerc_Abstrato.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
