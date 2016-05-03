

namespace Exercise1
{
    public class RobotBus
    {
        private readonly Log _log;
        private readonly LeftArm _leftArm;
        private readonly RightThigh _rightThigh;
        private readonly Neck _neck;
        private readonly Head _head;

        public bool IsOn { get { return true; } }
        public LeftArm LeftArm { get { return _leftArm;  } }
        public RightThigh RightThigh { get { return _rightThigh; } }
        public Neck Neck { get { return _neck; } }
        public Head Head { get { return _head; } }

        public RobotBus() : this(new Log()) { }

        public RobotBus(Log log)
        {
            _log = log;
            _leftArm = new LeftArm(log);
            _rightThigh = new RightThigh(log);
            _neck = new Neck(log);
            _head = new Head(log);
        }

        public void Execute(string command)
        {
            if (command.Trim().ToLower() == "check")
            {
                _log.Append("Robot bus status is ok.");
            }

            _leftArm.Execute(command);
            _rightThigh.Execute(command);
            _neck.Execute(command);
            _head.Execute(command);
        }
    }
}
