
namespace Exercise1
{
    public class Head
    {
        private Log _log;

        public int MaxCharge { get { return 1200; } }
        public bool IsOn { get { return false;  } }

        public Head() : this(new Log()) {}
        public Head(Log log)
        {
            this._log = log;
        }

        public void Execute(string command)
        {
            if (command.Trim().ToLower() == "check")
            {
                _log.Append("Head status is ok.");
            }
        }
    }
}
