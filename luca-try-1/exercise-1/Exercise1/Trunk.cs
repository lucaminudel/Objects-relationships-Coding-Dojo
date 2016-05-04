

namespace Exercise1
{
    public class Trunk
    {
        public bool IsOn { get { return true; } }

        public Hip Hip { get; private set; }
        public Shoulders Shoulders { get; private set; }

        public Trunk()
        {

            Hip = new Hip();
            Shoulders = new Shoulders();
        }

        // Other Trunk respnonsibilities omitted because implementation is not needed for the exercise
        // ...

    }
}
