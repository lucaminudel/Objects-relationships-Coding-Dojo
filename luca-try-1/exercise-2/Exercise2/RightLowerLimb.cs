
namespace Exercise2
{
    public class RightLowerLimb : IRobotPart
    {
        private readonly int _maxCharge = 1100;
        private readonly bool _isOn = true;
        private readonly RightFoot _rightFoot;

        public RightLowerLimb(RightFoot rightFoot)
        {
            _rightFoot = rightFoot;
        }

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Right lower limb", _isOn);
            visitor.LogMaxCharge(_maxCharge);

            _rightFoot.AcceptLogVisitor(visitor.VisitLeaf());
        }

        // Other RightLowerLimb respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
