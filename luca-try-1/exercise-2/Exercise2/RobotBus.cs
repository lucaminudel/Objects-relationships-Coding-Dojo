
namespace Exercise2
{
    public class RobotBus
    {
        private readonly bool _isOn = true;
        private readonly IRobotPart[] _robotParts;

        public RobotBus(IRobotPart[] robotParts)
        {
            _robotParts = (IRobotPart[])robotParts.Clone();
        }

    }
}
