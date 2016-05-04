
namespace Exercise2
{
    public class Shoulder : IRobotPart
    {
        private readonly int _maxCharge = 300;
        private readonly bool _isOn = true;
        private readonly IRobotPart _robotPart;

        public Shoulder(LeftArm leftArm)
        {
            _robotPart = leftArm;
        }

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Shoulder", _isOn);
            visitor.LogMaxCharge(_maxCharge);

            _robotPart.AcceptLogVisitor(visitor.VisitLeaf());
        }

        // Other Shoulder respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
