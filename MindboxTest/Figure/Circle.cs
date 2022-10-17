namespace MindboxTest
{
    internal class Circle : Figure
    {
        private double _radius { get; set; }

        public Circle(double radius)
        {
            _radius = radius;
        }
        
        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }

        public override void Validate()
        {
            if (_radius <= 0)
            {
                throw new ArgumentException("Incorrect radius value");
            }
        }
    }
}
