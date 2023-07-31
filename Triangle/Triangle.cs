namespace mindbox.Triangle
{
    public class Triangle : ITriangle
    {
        private double _firstEdgeLength;
        private double _secondEdgeLength;
        private double _thirdEdgeLength;
        private const double RIGHT_TRIANGLE_TOLERANCE = 0.00000001;

        /// <summary>
        /// Треугольник по трем сторонам
        /// </summary>
        /// <param name="firstEdgeLength">Длина первой стороны</param>
        /// <param name="secondEdgeLength">Длина второй стороны</param>
        /// <param name="thirdEdgeLength">Длина третьей стороны</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double firstEdgeLength, double secondEdgeLength, double thirdEdgeLength)
        {
            if (_firstEdgeLength < 0
                || _secondEdgeLength < 0
                || _thirdEdgeLength < 0)
            {
                throw new ArgumentException("Длины сторон должны быть больше 0");
            }

            _firstEdgeLength = firstEdgeLength;
            _secondEdgeLength = secondEdgeLength;
            _thirdEdgeLength = thirdEdgeLength;
        }

        private double _halfPerimeter => (_firstEdgeLength + _secondEdgeLength + _thirdEdgeLength)/2;

        /// <summary>
        /// Рассчет площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double Area() => Math.Sqrt(_halfPerimeter * (_halfPerimeter - _firstEdgeLength) * (_halfPerimeter - _secondEdgeLength) * (_halfPerimeter - _thirdEdgeLength));

        /// <summary>
        /// Является ли правильным треугольником
        /// </summary>
        /// <returns>true - правильный</returns>
        public bool IsRightTriangle()
        {
            var edges = new List<double>
            {
                _firstEdgeLength,
                _secondEdgeLength,
                _thirdEdgeLength,
            };

            edges.Sort();

            return Math.Abs(edges[2] * edges[2] - edges[1] * edges[1] - edges[0] * edges[0]) < RIGHT_TRIANGLE_TOLERANCE;
        }

    }
}
