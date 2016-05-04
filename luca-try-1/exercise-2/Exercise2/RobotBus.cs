
namespace Exercise2
{
    public class RobotBus
    {
        private readonly bool _isOn = true;
        private readonly IRobotPart[] _robotParts;

        public RobotBus(Shoulder shoulder, Hip hip)
        {
            _robotParts = new IRobotPart[] { shoulder, hip };
        }

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Robot bus", _isOn);

            foreach (var robotPart in _robotParts)
            {
                robotPart.AcceptLogVisitor(visitor.VisitLeaf());
            }
        }

        // Other RobotBus respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
