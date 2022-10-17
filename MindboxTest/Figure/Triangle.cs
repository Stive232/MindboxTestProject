namespace MindboxTest
{
    public class Triangle : Figure
    {
        private readonly double _aSide;
        private readonly double _bSide;
        private readonly double _cSide;

        public Triangle(double aSide, double bSide, double cSide)
        {
            _aSide = aSide;
            _bSide = bSide;
            _cSide = cSide;
        }
        public override double GetArea()
        {
            Validate();
            double halfPerimeter = GetHalfPerimeter();
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _aSide) * (halfPerimeter - _bSide) * (halfPerimeter - _cSide));
        }

        private double GetHalfPerimeter() => (_aSide + _bSide + _cSide) / 2;
        public override void Validate()
        {
            if(!(_aSide + _bSide > _cSide && _aSide + _cSide > _bSide && _bSide + _cSide > _aSide && _aSide > 0 && _bSide > 0 && _cSide > 0))
            {
                throw new ArgumentException("Incorrect values of the sides of the triangle");
            }
        }

        public bool IsRectangular()
        {
            return (_cSide == Math.Sqrt(Math.Pow(_aSide, 2) + Math.Pow(_bSide, 2))
                         || _aSide == Math.Sqrt(Math.Pow(_cSide, 2) + Math.Pow(_bSide, 2))
                         || _bSide == Math.Sqrt(Math.Pow(_cSide, 2) + Math.Pow(_aSide, 2)));
        }
    }
}
