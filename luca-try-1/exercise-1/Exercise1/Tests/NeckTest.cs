using NUnit.Framework;

namespace Exercise1.Tests
{
    [TestFixture]
    public class NeckTest
    {
        private Neck _target;
        private Neck _targetWithLog;
        private Log _log;

        [SetUp]
        public void SetUp()
        {
            _target = new Neck();

            _log = new Log();
            _targetWithLog = new Neck(_log);
        }

        [Test]
        public void has_a_positive_max_charge()
        {

            Assert.LessOrEqual(0, _target.MaxCharge);
        }

        [Test]
        public void has_an_onoff_status()
        {
            Assert.IsFalse(_target.IsOn);
        }

        [Test]
        public void check_command_return_diagnostic_message()
        {
            _targetWithLog.Execute("check");

            Assert.AreEqual("Neck status is ok.\n", _log.Read());
        }


        [Test]
        public void non_check_command_return_empty_message()
        {
            _targetWithLog.Execute("any");

            Assert.IsEmpty(_log.Read());
        }
    }
}
