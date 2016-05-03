namespace Exercise1
{
    public class LeftArm
    {
        private Log _log;

        public int MaxCharge { get { return 2100; } }
        public bool IsOn { get { return true;  } }

        public LeftArm() : this(new Log()) {}
        public LeftArm(Log log)
        {
            this._log = log;
        }

        public void Execute(string command)
        {
            if (command.Trim().ToLower() == "check")
            {
                _log.Append("Left arm status is ok.");
            }
        }

    }
}
