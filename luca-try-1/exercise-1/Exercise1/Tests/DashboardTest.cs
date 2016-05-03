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
            Assert.AreEqual("Robot bus is: On\n  Left arm is: On\n  Right thigh is: On\n", _target.OnOffReport());
        }

        [Test]
        public void recharge_costs_report_for_the_all_parts()
        {
            Assert.AreEqual(0.66, _target.RechargeCostsReport());
        }


    }
}
