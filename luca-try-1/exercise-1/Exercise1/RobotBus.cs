

namespace Exercise1
{
    public class RobotBus
    {
        private readonly LeftArm _leftArm;
        private readonly RightThigh _rightThigh;
        private readonly Neck _neck;
        private readonly Head _head;

        public bool IsOn { get { return true; } }
        public LeftArm LeftArm { get { return _leftArm;  } }
        public RightThigh RightThigh { get { return _rightThigh; } }
        public Neck Neck { get { return _neck; } }
        public Head Head { get { return _head; } }

        public RobotBus()
        {
            _leftArm = new LeftArm();
            _rightThigh = new RightThigh();
            _neck = new Neck();
            _head = new Head();
        }

        // Other RobotBus respnonsibilities omitted because implementation is not needed for the exercise
        // ...

    }
}
