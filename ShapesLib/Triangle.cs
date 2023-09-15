namespace ShapesLib
{
    public class Triangle : Shape
    {
        public readonly double[] Sides;
        public readonly bool IsRight;
        /// <summary>
        /// Creates a triangle, stores the length of its sides, its area and whether the triangle is right angled.
        /// </summary>
        /// <param name="side A length"></param>
        /// <param name="side B length"></param>
        /// <param name="side C length"></param>
        public Triangle(double a, double b, double c) : base(CalculateArea(a, b, c))
        {
            Sides = new double[3] { a, b, c };
            IsRight = CheckIfRight(a, b, c);
        }

        /// <summary>
        /// Calculates an area of a triangle with sides of length A, B and C.
        /// </summary>
        /// <param name="side A length"></param>
        /// <param name="side B length"></param>
        /// <param name="side C length"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double CalculateArea(double a, double b, double c)
        {
            ExceptionChecks(a, b, c);
            double semiP = (a + b + c) / 2;
            return Math.Sqrt(semiP * (semiP - a) * (semiP - b) * (semiP - c));
        }

        /// <summary>
        /// Checks if a triangle with sides of length A, B and C is right angled.
        /// </summary>
        /// <param name="side A length"></param>
        /// <param name="side B length"></param>
        /// <param name="side C length"></param>
        /// <returns></returns>
        public static bool CheckIfRight(double a, double b, double c)
        {
            ExceptionChecks(a, b, c);
            double[] sides = new double[]{ a, b, c };
            Array.Sort(sides);
            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) <= 1E-6;
        }

        private static void ExceptionChecks(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Length of all sides should be positive.");
            else if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Sides do not form a triangle.");
        }

        public override string ToString() => 
            $"A {(IsRight ? "right-angled " : "")}triangle with sides of length {Sides[0]}, {Sides[1]}, {Sides[2]} and area of {Area.ToString("0.###")}";

    }
}
