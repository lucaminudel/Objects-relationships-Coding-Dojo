
namespace Exercise2
{
    public class RobotBus
    {
        private readonly bool _isOn = true;
        private readonly IRobotPart[] _robotParts;

        public RobotBus(LeftArm leftArm, RightFoot rightFoot, RightThigh rightThigh)
        {
            _robotParts = new IRobotPart[] { leftArm, rightFoot, rightThigh };
        }

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Robot bus", _isOn);

            foreach (var robotPart in _robotParts)
            {
                robotPart.AcceptLogVisitor(visitor.VisitLeaf());
            }
        }
    }
}
