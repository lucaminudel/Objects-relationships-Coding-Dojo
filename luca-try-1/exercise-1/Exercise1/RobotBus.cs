

namespace Exercise1
{
    public class RobotBus
    {
        public bool IsOn { get { return true; } }
        public Neck Neck { get; private set; }
        public Head Head { get; private set; }
        public Hip Hip { get; private set; }

        public RobotBus()
        {
            Neck = new Neck();
            Head = new Head();

            Hip = new Hip();
        }

        // Other RobotBus respnonsibilities omitted because implementation is not needed for the exercise
        // ...

    }
}
