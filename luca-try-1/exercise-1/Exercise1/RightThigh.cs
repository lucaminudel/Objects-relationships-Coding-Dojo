
namespace Exercise1
{
    public class RightThigh
    {

        public int MaxCharge { get { return 1200; } }
        public bool IsOn { get { return true;  } }

        public RightLowerLimb RightLowerLimb { get; private set; }

        public RightThigh()
        {
            RightLowerLimb = new RightLowerLimb();            
        }
        // Other RightThigh respnonsibilities omitted because implemetation is not needed for the exercise
        // ...

    }
}
