

namespace Exercise1
{
    public class RobotBus
    {
        private readonly LeftArm _leftArm;
        private readonly RightThigh _rightThigh;
        private readonly Neck _neck;
        private readonly Head _head;
        private readonly RightLowerLimb _rightLowerLimb;
        private readonly RightFoot _rightFoot;

        public bool IsOn { get { return true; } }
        public LeftArm LeftArm { get { return _leftArm;  } }
        public RightThigh RightThigh { get { return _rightThigh; } }
        public Neck Neck { get { return _neck; } }
        public Head Head { get { return _head; } }
        public RightLowerLimb RightLowerLimb { get { return _rightLowerLimb;  } }
        public RightFoot RightFoot { get { return _rightFoot; } }

        public RobotBus()
        {
            _leftArm = new LeftArm();
            _rightThigh = new RightThigh();
            _neck = new Neck();
            _head = new Head();
            _rightLowerLimb = new RightLowerLimb();
            _rightFoot = new RightFoot();
        }

        // Other RobotBus respnonsibilities omitted because implementation is not needed for the exercise
        // ...

    }
}
