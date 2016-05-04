
namespace Exercise2
{
    public class Hip : IRobotPart
    {
        private readonly int _maxCharge = 300;
        private readonly bool _isOn = true;
        private readonly RightThigh _rightThigh;

        public Hip(RightThigh rightThigh)
        {
            _rightThigh = rightThigh;
        }

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Hip", _isOn);
            visitor.LogMaxCharge(_maxCharge);

            _rightThigh.AcceptLogVisitor(visitor.VisitLeaf());
        }

        // Other Hip respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
