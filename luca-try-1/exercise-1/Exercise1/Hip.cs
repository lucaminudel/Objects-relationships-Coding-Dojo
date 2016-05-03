
namespace Exercise1
{
    public class Hip
    {
        private readonly RightThigh _rightThigh; 
        private readonly RightLowerLimb _rightLowerLimb;
        private readonly RightFoot _rightFoot;

        public RightThigh RightThigh { get { return _rightThigh; } }
        public RightLowerLimb RightLowerLimb { get { return _rightLowerLimb; } }
        public RightFoot RightFoot { get { return _rightFoot; } }

        public int MaxCharge { get { return 300; } }
        public bool IsOn { get { return true; } }

        public Hip()
        {
            _rightThigh = new RightThigh();
            _rightLowerLimb = new RightLowerLimb();
            _rightFoot = new RightFoot();
        }

        // Other Hip respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
