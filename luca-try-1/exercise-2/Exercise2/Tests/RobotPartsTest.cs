
using NUnit.Framework;

namespace Exercise2.Tests
{
    [TestFixture]
    public class RobotPartsTest
    {
        [Test]
        public void contains_left_arm_and_right_foot()
        {
            new RobotBus(new IRobotPart[] {new LeftArm(), new RightFoot()});

        }
    }
}
