namespace ShapesLib
{
    public class Circle : Shape
    {
        public readonly double Radius;
        /// <summary>
        /// Creates a circle, stores its radius and area.
        /// </summary>
        /// <param name="Radius"></param>
        public Circle(double radius) : base(CalculateArea(radius))
        {
            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of a circle.
        /// </summary>
        /// <param name="Radius"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double CalculateArea(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius should be a positive number.");
            return Math.PI * radius * radius;
        }

        public override string ToString() => $"A circle with radius of {Radius} and area of {Area.ToString("0.###")}";
    }
}
