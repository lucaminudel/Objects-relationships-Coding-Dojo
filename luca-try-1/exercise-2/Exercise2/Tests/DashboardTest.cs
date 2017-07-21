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
        public void object_graph_report()
        {
            var robotBus = new Trunk(
                new Shoulder(new LeftArm()), 
                new Hip(new RightThigh(new RightLowerLimb(new RightFoot()))));

            robotBus.AcceptLogVisitor(_target);

            var reportItems = new[]
            {
                "Trunk is: On", 
                "  Shoulder is: On", 
                "    Left arm is: Off", 
                "  Hip is: On", 
                "    Right thigh is: On", 
                "      Right lower limb is: On", 
                "        Right foot is: On", ""
            };
            Assert.AreEqual(string.Join("\n", reportItems), _target.GetStatusReport());

            Assert.AreEqual(1.08, _target.GetRechargeCosts());
        }
    }
}
