
namespace Exercise2
{
    public class Hip : IRobotPart
    {
        private readonly int _maxCharge = 300;
        private readonly bool _isOn = true;
        private readonly IRobotPart[] _robotParts;

        public Hip(RightFoot rightFoot, RightThigh rightThigh, RightLowerLimb rightLowerLimb)
        {
            _robotParts = new IRobotPart[] { rightFoot, rightThigh, rightLowerLimb };
        }

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Hip", _isOn);
            visitor.LogMaxCharge(_maxCharge);

            foreach (var robotPart in _robotParts)
            {
                robotPart.AcceptLogVisitor(visitor.VisitLeaf());
            }
        }

        // Other Hip respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
