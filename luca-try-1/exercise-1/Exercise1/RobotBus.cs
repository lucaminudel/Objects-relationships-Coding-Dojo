

namespace Exercise1
{
    public class RobotBus
    {
        private Log _log;
        private LeftArm _leftArm;

        public RobotBus() : this(new Log()) {}

        public RobotBus(Log log)
        {
            _log = log;
            _leftArm = new LeftArm(log);
        }

        public bool IsOn { get { return true;  } }

        public void Execute(string command)
        {
            if (command.Trim().ToLower() == "check")
            {
                _log.Append("Robot bus status is ok.");
            }

            _leftArm.Execute(command);
        }
    }
}
