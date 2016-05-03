using NUnit.Framework;

namespace Exercise1.Tests
{

    [TestFixture]
    public class LeftArmTest
    {
        private LeftArm _target;
        private LeftArm _targetWithLog;
        private Log _log;

        [SetUp]
        public void SetUp()
        {
            _target = new LeftArm();

            _log = new Log();
            _targetWithLog = new LeftArm(_log);
        }

        [Test]
        public void has_a_positive_max_charge()
        {

            Assert.LessOrEqual(0, _target.MaxCharge);
        }

        [Test]
        public void has_an_onoff_status()
        {
            Assert.IsTrue(_target.IsOn);            
        }

        [Test]
        public void check_command_return_diagnostic_message()
        {
            _targetWithLog.Execute("check");

            Assert.AreEqual("Left arm status is ok.\n", _log.Read());
        }
    }
}
