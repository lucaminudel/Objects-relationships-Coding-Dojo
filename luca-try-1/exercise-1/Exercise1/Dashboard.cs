
using System;
using System.Text;

namespace Exercise1
{
    public class Dashboard
    {
        private readonly RobotBus _robotBus;

        public Dashboard(RobotBus robotBus)
        {
            _robotBus = robotBus;
        }

        public string OnOffReport()
        {
            var report = new StringBuilder();

            report.AppendFormat("Robot bus is: {0}\n", IsOnToString(_robotBus.IsOn));
            report.AppendFormat("  Left arm is: {0}\n", IsOnToString(_robotBus.LeftArm.IsOn));
            report.AppendFormat("  Right thigh is: {0}\n", IsOnToString(_robotBus.RightThigh.IsOn));

            return report.ToString();
        }

        public double RechargeCostsReport()
        {
            return (_robotBus.LeftArm.MaxCharge + _robotBus.RightThigh.MaxCharge)*0.2/1000;
        }
        
        private static string IsOnToString(Boolean isOn)
        {
            return isOn ? "On" : "Off";
        }


    }
}
