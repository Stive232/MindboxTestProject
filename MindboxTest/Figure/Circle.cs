namespace MindboxTest
{
    public class Circle : Figure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        
        public override double GetArea()
        {
            Validate();
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
