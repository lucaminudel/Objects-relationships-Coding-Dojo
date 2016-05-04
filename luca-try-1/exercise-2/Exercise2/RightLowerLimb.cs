
namespace Exercise2
{
    public class RightLowerLimb : IRobotPart
    {
        private readonly int _maxCharge = 1100;
        private readonly bool _isOn = true;

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Right lower limb", _isOn);
            visitor.LogMaxCharge(_maxCharge);
        }

        // Other RightLowerLimb respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
