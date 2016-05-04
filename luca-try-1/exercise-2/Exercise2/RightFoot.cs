
namespace Exercise2
{
    public class RightFoot : IRobotPart
    {
        private readonly int _maxCharge = 300;
        private readonly bool _isOn = true;

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Right foot", _isOn);
            visitor.LogMaxCharge(_maxCharge);
        }
    }
}
