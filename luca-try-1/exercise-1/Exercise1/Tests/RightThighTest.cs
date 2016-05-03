using NUnit.Framework;

namespace Exercise1.Tests
{
    [TestFixture]
    public class RightThighTest
    {
        private RightThigh _target;
        private RightThigh _targetWithLog;
        private Log _log;

        [SetUp]
        public void SetUp()
        {
            _target = new RightThigh();

            _log = new Log();
            _targetWithLog = new RightThigh(_log);
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

            Assert.AreEqual("RightThigh status is ok.\n", _log.Read());
        }


        [Test]
        public void non_check_command_return_empty_message()
        {
            _targetWithLog.Execute("any");

            Assert.IsEmpty(_log.Read());
        }

    }
}
