
using NUnit.Framework;

namespace Exercise1.Tests
{
    [TestFixture]
    public class RightLowerLimbTest
    {
        private RightLowerLimb _target;


        [SetUp]
        public void SetUp()
        {
            _target = new RightLowerLimb();

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
    }
}
