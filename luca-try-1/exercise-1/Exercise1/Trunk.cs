

namespace Exercise1
{
    public class Trunk
    {
        public bool IsOn { get { return true; } }

        public Hip Hip { get; private set; }
        public Shoulder Shoulder { get; private set; }

        public Trunk()
        {

            Hip = new Hip();
            Shoulder = new Shoulder();
        }

        // Other Trunk respnonsibilities omitted because implementation is not needed for the exercise
        // ...

    }
}
