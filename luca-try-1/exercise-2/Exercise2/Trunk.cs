
namespace Exercise2
{
    public class Trunk
    {
        private readonly bool _isOn = true;
        private readonly IRobotPart[] _robotParts;

        public Trunk(Shoulder shoulder, Hip hip)
        {
            _robotParts = new IRobotPart[] { shoulder, hip };
        }

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Trunk", _isOn);

            foreach (var robotPart in _robotParts)
            {
                robotPart.AcceptLogVisitor(visitor.VisitLeaf());
            }
        }

        // Other Trunk respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
