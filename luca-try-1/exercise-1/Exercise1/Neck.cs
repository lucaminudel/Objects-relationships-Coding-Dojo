
namespace Exercise1
{
    public class Neck
    {
        private Log _log;

        public int MaxCharge { get { return 300; } }
        public bool IsOn { get { return false;  } }

        public Neck() : this(new Log()) {}
        public Neck(Log log)
        {
            this._log = log;
        }

        public void Execute(string command)
        {
            if (command.Trim().ToLower() == "check")
            {
                _log.Append("Neck status is ok.");
            }
        }
    }
}
