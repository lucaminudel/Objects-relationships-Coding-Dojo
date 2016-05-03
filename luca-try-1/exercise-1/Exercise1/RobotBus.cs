

namespace Exercise1
{
    public class RobotBus
    {
        private readonly Log _log;
        private readonly LeftArm _leftArm;
        private readonly RightThigh _rightThigh;

        public bool IsOn { get { return true; } }
        public LeftArm LeftArm { get { return _leftArm;  } }
        public RightThigh RightThigh { get { return _rightThigh; } }

        public RobotBus() : this(new Log()) { }

        public RobotBus(Log log)
        {
            _log = log;
            _leftArm = new LeftArm(log);
            _rightThigh = new RightThigh(log);
        }

        public void Execute(string command)
        {
            if (command.Trim().ToLower() == "check")
            {
                _log.Append("Robot bus status is ok.");
            }

            _leftArm.Execute(command);
            _rightThigh.Execute(command);
        }
    }
}
