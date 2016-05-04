
namespace Exercise2
{
    public class LeftArm : IRobotPart
    {
        private readonly int _maxCharge = 2200;
        private readonly bool _isOn = false;

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Left arm", _isOn);
            visitor.LogMaxCharge(_maxCharge);
        }
    }
}
