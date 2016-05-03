

namespace Exercise1
{
    public class RobotBus
    {
        public bool IsOn { get { return true; } }
        public LeftArm LeftArm { get; private set; }
        public Neck Neck { get; private set; }
        public Head Head { get; private set; }
        public Hip Hip { get; private set; }

        public RobotBus()
        {
            LeftArm = new LeftArm();
            Neck = new Neck();
            Head = new Head();

            Hip = new Hip();
        }

        // Other RobotBus respnonsibilities omitted because implementation is not needed for the exercise
        // ...

    }
}
