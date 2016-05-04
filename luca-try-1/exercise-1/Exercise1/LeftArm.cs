
namespace Exercise1
{
    public class LeftArm
    {

        public enum OnOffStatusEnum { On, Off }

        public int MaxCharge { get { return 2200; } }
        public OnOffStatusEnum OnOffStatus { get { return OnOffStatusEnum.Off; } }

        // Other LeftArm respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
