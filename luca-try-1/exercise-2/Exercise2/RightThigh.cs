namespace Exercise2
{
    public class RightThigh : IRobotPart
    {
        private readonly int _maxCharge = 1200;
        private readonly bool _isOn = true;
        private readonly RightLowerLimb _rightLowerLimb;

        public RightThigh(RightLowerLimb rightLowerLimb)
        {
            _rightLowerLimb = rightLowerLimb;
        }
        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Right thigh", _isOn);
            visitor.LogMaxCharge(_maxCharge);

            _rightLowerLimb.AcceptLogVisitor(visitor.VisitLeaf());
        }

        // Other RightThigh respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
