
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
            report.AppendFormat("  Shoulder is: {0}\n", IsOnToString(_trunk.Shoulder.IsOn));
            report.AppendFormat("    Left arm is: {0}\n", IsOnToString(_trunk.Shoulder.LeftArm.OnOffStatus == LeftArm.OnOffStatusEnum.On));
            report.AppendFormat("  Hip is: {0}\n", IsOnToString(_trunk.Hip.IsOn));
            report.AppendFormat("    Right thigh is: {0}\n", IsOnToString(_trunk.Hip.RightThigh.IsOn));
            report.AppendFormat("      Right lower limb is: {0}\n", IsOnToString(_trunk.Hip.RightThigh.RightLowerLimb.IsOn));
            report.AppendFormat("        Right foot is: {0}\n", IsOnToString(_trunk.Hip.RightThigh.RightLowerLimb.RightFoot.IsOn));

            return report.ToString();
        }

        public double RechargeCostsReport()
        {
            return (_trunk.Shoulder.MaxCharge
                + _trunk.Shoulder.LeftArm.MaxCharge
                + _trunk.Hip.MaxCharge
                + _trunk.Hip.RightThigh.MaxCharge
                + _trunk.Hip.RightThigh.RightLowerLimb.MaxCharge
                + _trunk.Hip.RightThigh.RightLowerLimb.RightFoot.MaxCharge
                ) * 0.2 / 1000;
        } 
        
        private static string IsOnToString(Boolean isOn)
        {
            return isOn ? "On" : "Off";
        }


    }
}
