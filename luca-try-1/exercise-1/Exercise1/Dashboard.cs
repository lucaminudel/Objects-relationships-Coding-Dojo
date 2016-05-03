
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
            report.AppendFormat("  Neck is: {0}\n", IsOnToString(_robotBus.Neck.IsOn));
            report.AppendFormat("  Head is: {0}\n", IsOnToString(_robotBus.Head.IsOn));
            report.AppendFormat("  Hip is: {0}\n", IsOnToString(_robotBus.Hip.IsOn));
            report.AppendFormat("    Right thigh is: {0}\n", IsOnToString(_robotBus.Hip.RightThigh.IsOn));
            report.AppendFormat("    Right lower limb is: {0}\n", IsOnToString(_robotBus.Hip.RightLowerLimb.IsOn));
            report.AppendFormat("    Right foot is: {0}\n", IsOnToString(_robotBus.Hip.RightFoot.IsOn));

            return report.ToString();
        }

        public double RechargeCostsReport()
        {
            return (_robotBus.LeftArm.MaxCharge 
                + _robotBus.Neck.MaxCharge
                + _robotBus.Head.MaxCharge
                + _robotBus.Hip.MaxCharge
                + _robotBus.Hip.RightThigh.MaxCharge
                + _robotBus.Hip.RightLowerLimb.MaxCharge
                + _robotBus.Hip.RightFoot.MaxCharge
                ) * 0.2 / 1000;
        } 
        
        private static string IsOnToString(Boolean isOn)
        {
            return isOn ? "On" : "Off";
        }


    }
}
