
namespace Exercise1
{
    public class Shoulders
    {
        public int MaxCharge { get { return 300; } }
        public bool IsOn { get { return true; } }

        public LeftArm LeftArm { get; private set; }
        public Head Head { get; private set; }

        public Shoulders()
        {
            LeftArm = new LeftArm();
            Head = new Head();            
        }

        // Other Shoulders respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
