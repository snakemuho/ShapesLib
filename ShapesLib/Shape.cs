namespace ShapesLib
{
    public abstract class Shape
    {
        private readonly double _area;
        public double Area => _area;
        public Shape(double area) => _area = area;
    }
}