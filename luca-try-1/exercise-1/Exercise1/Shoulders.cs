
namespace Exercise1
{
    public class Shoulders
    {
        public int MaxCharge { get { return 300; } }
        public bool IsOn { get { return true; } }

        public Neck Neck { get; private set; }
        public Head Head { get; private set; }

        public Shoulders()
        {
            Neck = new Neck();
            Head = new Head();            
        }

        // Other Shoulders respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
