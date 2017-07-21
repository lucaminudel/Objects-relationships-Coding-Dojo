
namespace Exercise1
{
    public class Shoulder
    {
        public int MaxCharge { get { return 300; } }
        public bool IsOn { get { return true; } }

        public LeftArm LeftArm { get; private set; }

        public Shoulder()
        {
            LeftArm = new LeftArm();
        }

        // Other Shoulder respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
