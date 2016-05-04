
using System;
using System.Text;

namespace Exercise1
{
    public class Dashboard
    {
        private readonly Trunk _trunk;

        public Dashboard(Trunk trunk)
        {
            _trunk = trunk;
        }

        public string OnOffReport()
        {
            var report = new StringBuilder();

            report.AppendFormat("Trunk is: {0}\n", IsOnToString(_trunk.IsOn));
            report.AppendFormat("  Shoulders is: {0}\n", IsOnToString(_trunk.Shoulders.IsOn));
            report.AppendFormat("    Neck is: {0}\n", IsOnToString(_trunk.Shoulders.Neck.IsOn));
            report.AppendFormat("    Head is: {0}\n", IsOnToString(_trunk.Shoulders.Head.IsOn));
            report.AppendFormat("  Hip is: {0}\n", IsOnToString(_trunk.Hip.IsOn));
            report.AppendFormat("    Right thigh is: {0}\n", IsOnToString(_trunk.Hip.RightThigh.IsOn));
            report.AppendFormat("    Right lower limb is: {0}\n", IsOnToString(_trunk.Hip.RightLowerLimb.IsOn));
            report.AppendFormat("    Right foot is: {0}\n", IsOnToString(_trunk.Hip.RightFoot.IsOn));

            return report.ToString();
        }

        public double RechargeCostsReport()
        {
            return (_trunk.Shoulders.MaxCharge
                + _trunk.Shoulders.Neck.MaxCharge
                + _trunk.Shoulders.Head.MaxCharge
                + _trunk.Hip.MaxCharge
                + _trunk.Hip.RightThigh.MaxCharge
                + _trunk.Hip.RightLowerLimb.MaxCharge
                + _trunk.Hip.RightFoot.MaxCharge
                ) * 0.2 / 1000;
        } 
        
        private static string IsOnToString(Boolean isOn)
        {
            return isOn ? "On" : "Off";
        }


    }
}
