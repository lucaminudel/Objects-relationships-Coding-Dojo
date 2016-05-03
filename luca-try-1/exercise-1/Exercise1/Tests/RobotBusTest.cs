using NUnit.Framework;

namespace Exercise1.Tests
{
    [TestFixture]
    public class RobotBusTest
    {
        private RobotBus _target;

        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void has_an_onoff_status()
        {
            var target = new RobotBus();
            Assert.IsTrue(target.IsOn);
        }

        [Test]
        public void check_command_pass_over_to_left_arm()
        {
            var log = new Log();
            var target = new RobotBus(log);

            target.Execute("check");

            var reportItems = new[]
            {
                "Robot bus status is ok", 
                "Left arm status is ok", 
                "RightThigh status is ok", 
                "Neck status is ok",
                "Head status is ok", ""
            };
            Assert.AreEqual(string.Join(".\n", reportItems), log.Read());
        }

        [Test]
        public void non_check_command_return_empty_message()
        {
            var log = new Log();
            var target = new RobotBus(log);

            target.Execute("any");

            Assert.IsEmpty(log.Read());
        }
    }
}
