using System.Linq;
using NUnit.Framework;

namespace Exercise1.Tests
{
    [TestFixture]
    public class DashboardTest
    {
        Trunk _trunk;
        Dashboard _target;

        [SetUp]
        public void SetUp()
        {
            _trunk = new Trunk();
            _target = new Dashboard(_trunk);           
        }

        [Test]
        public void onoff_report_for_the_all_parts()
        {
            var reportItems = new[]
            {
                "Trunk is: On", 
                "  Shoulders is: On", 
                "    Left arm is: Off", 
                "    Head is: Off", 
                "  Hip is: On", 
                "    Right thigh is: On",
                "      Right lower limb is: On",
                "        Right foot is: On", ""
            };

            Assert.AreEqual(string.Join("\n", reportItems), _target.OnOffReport());
        }

        [Test]
        public void recharge_costs_report_for_the_all_parts()
        {
            Assert.AreEqual(1.30, _target.RechargeCostsReport());
        }


    }
}
