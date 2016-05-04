using NUnit.Framework;

namespace Exercise2.Tests
{
    [TestFixture]
    public class DashboardTest
    {
        private Dashboard _target;

        [SetUp]
        public void SetUp()
        {
            _target = new Dashboard();            
        }

        [Test]
        public void empty_report()
        {
            Assert.AreEqual(string.Empty, _target.GetStatusReport());

            Assert.AreEqual(0, _target.GetRechargeCosts());
        }


        [Test]
        public void two_levels_report()
        {
            var robotBus = new RobotBus(new LeftArm(), new RightFoot());

            robotBus.AcceptLogVisitor(_target);

            var reportItems = new[]
            {
                "Robot bus is: On", 
                "  Left arm is: Off", 
                "  Right foot is: On", ""
            };
            Assert.AreEqual(string.Join("\n", reportItems), _target.GetStatusReport());

            Assert.AreEqual(0.5, _target.GetRechargeCosts());
        }
    }
}
