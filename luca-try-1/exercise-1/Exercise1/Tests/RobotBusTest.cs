using NUnit.Framework;

namespace Exercise1.Tests
{
    [TestFixture]
    public class RobotBusTest
    {

        [Test]
        public void has_an_onoff_status()
        {
            var target = new RobotBus();
            Assert.IsTrue(target.IsOn);
        }

    }
}
