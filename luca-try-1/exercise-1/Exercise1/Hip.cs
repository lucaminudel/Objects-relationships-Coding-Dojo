
namespace Exercise1
{
    public class Hip
    {
        public RightThigh RightThigh { get; private set; }
        public RightLowerLimb RightLowerLimb { get; private set; }
        public RightFoot RightFoot { get; private set; }

        public int MaxCharge { get { return 300; } }
        public bool IsOn { get { return true; } }

        public Hip()
        {
            RightThigh = new RightThigh();
            RightLowerLimb = new RightLowerLimb();
            RightFoot = new RightFoot();
        }

        // Other Hip respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
