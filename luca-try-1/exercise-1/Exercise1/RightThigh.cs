
namespace Exercise1
{
    public class RightThigh
    {
        private Log _log;

        public int MaxCharge { get { return 1200; } }
        public bool IsOn { get { return true;  } }

        public RightThigh() : this(new Log()) {}
        public RightThigh(Log log)
        {
            this._log = log;
        }

        public void Execute(string command)
        {
            if (command.Trim().ToLower() == "check")
            {
                _log.Append("RightThigh status is ok.");
            }
        }
    }
}
