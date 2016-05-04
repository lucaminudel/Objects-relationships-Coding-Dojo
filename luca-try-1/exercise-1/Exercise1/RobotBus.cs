

namespace Exercise1
{
    public class RobotBus
    {
        public bool IsOn { get { return true; } }

        public Hip Hip { get; private set; }
        public Shoulders Shoulders { get; private set; }

        public RobotBus()
        {

            Hip = new Hip();
            Shoulders = new Shoulders();
        }

        // Other RobotBus respnonsibilities omitted because implementation is not needed for the exercise
        // ...

    }
}
