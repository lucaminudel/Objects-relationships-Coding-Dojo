using NUnit.Framework;

namespace Exercise1.Tests
{
    [TestFixture]
    public class TrunkTest
    {

        [Test]
        public void has_an_onoff_status()
        {
            var target = new Trunk();
            Assert.IsTrue(target.IsOn);
        }

    }
}
