

using System.Text;

namespace Exercise2
{
    public class Dashboard
    {
        private class LogRecord
        {
            public StringBuilder StatusReport = new StringBuilder();
            public int TotalMaxCharge = 0;
        }

        private readonly LogRecord _logRecord;
        private readonly int _statusReportIdentation;

        public Dashboard() : this(0, new LogRecord()) { }

        private Dashboard(int statusReportIdentation, LogRecord logRecord)
        {
            _logRecord = logRecord;
            _statusReportIdentation = statusReportIdentation;
        }

        public void LogStatus(string partName, bool isOn)
        {
            _logRecord.StatusReport.AppendFormat("{0}{1} is: {2}\n", new string(' ', _statusReportIdentation), partName, IsOnToString(isOn));
        }

        public void LogMaxCharge(int maxCharge)
        {
            _logRecord.TotalMaxCharge += maxCharge;
        }

        public string GetStatusReport()
        {
            return _logRecord.StatusReport.ToString();
        }

        public double GetRechargeCosts()
        {
            return _logRecord.TotalMaxCharge * 0.2 / 1000;
        }

        public Dashboard VisitLeaf()
        {
            return new Dashboard(_statusReportIdentation + 2, _logRecord);
        }

        private static string IsOnToString(bool isOn)
        {
            return isOn ? "On" : "Off";
        }
    }
}
