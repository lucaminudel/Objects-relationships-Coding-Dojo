using System.Linq;
using NUnit.Framework;

namespace Exercise1.Tests
{
    [TestFixture]
    public class DashboardTest
    {
        RobotBus _robotBus;
        Dashboard _target;

        [SetUp]
        public void SetUp()
        {
            _robotBus = new RobotBus();
            _target = new Dashboard(_robotBus);           
        }

        [Test]
        public void onoff_report_for_the_all_parts()
        {
            var reportItems = new[]
            {
                "Robot bus is: On", 
                "  Left arm is: On", 
                "  Right thigh is: On",
                "  Neck is: Off", 
                "  Head is: Off", ""
            };

            Assert.AreEqual(string.Join("\n", reportItems), _target.OnOffReport());
        }

        [Test]
        public void recharge_costs_report_for_the_all_parts()
        {
            Assert.AreEqual(0.96, _target.RechargeCostsReport());
        }


    }
}
