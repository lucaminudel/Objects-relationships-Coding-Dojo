
namespace Exercise1
{
    public class RightLowerLimb
    {
        public int MaxCharge { get { return 1100; } }
        public bool IsOn { get { return true; } }

        public RightFoot RightFoot { get; private set; }

        public RightLowerLimb()
        {
            RightFoot = new RightFoot();            
        }

        // Other RightLowerLimb respnonsibilities omitted because implementation is not needed for the exercise
        // ...B
    }
}
