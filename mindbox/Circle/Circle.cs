namespace mindbox.Circle
{
    public class Circle : ICircle
    {
        private double _radius;

        public Circle(double Radius) 
        { 
            if (Radius < 0) 
            {
                throw new ArgumentException("Радиус должен быть больше 0");
            }

            _radius = Radius;
        }

        public double Area() => Math.PI * _radius * _radius;
    }
}
