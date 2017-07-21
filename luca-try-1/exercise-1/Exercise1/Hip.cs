
namespace Exercise1
{
    public class Hip
    {
        public RightThigh RightThigh { get; private set; }

        public int MaxCharge { get { return 300; } }
        public bool IsOn { get { return true; } }

        public Hip()
        {
            RightThigh = new RightThigh();
        }

        // Other Hip respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
