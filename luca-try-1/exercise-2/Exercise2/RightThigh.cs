namespace Exercise2
{
    public class RightThigh : IRobotPart
    {
        private readonly int _maxCharge = 1200;
        private readonly bool _isOn = true;

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Right thigh", _isOn);
            visitor.LogMaxCharge(_maxCharge);
        }

        // Other RightThigh respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
