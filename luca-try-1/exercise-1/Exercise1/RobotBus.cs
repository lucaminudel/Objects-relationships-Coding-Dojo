

namespace Exercise1
{
    public class RobotBus
    {
        private readonly LeftArm _leftArm;
        private readonly Neck _neck;
        private readonly Head _head;

        private readonly Hip _hip;

        public bool IsOn { get { return true; } }
        public LeftArm LeftArm { get { return _leftArm;  } }
        public Neck Neck { get { return _neck; } }
        public Head Head { get { return _head; } }
        public Hip Hip { get { return _hip; } }

        public RobotBus()
        {
            _leftArm = new LeftArm();
            _neck = new Neck();
            _head = new Head();

            _hip = new Hip();
        }

        // Other RobotBus respnonsibilities omitted because implementation is not needed for the exercise
        // ...

    }
}
