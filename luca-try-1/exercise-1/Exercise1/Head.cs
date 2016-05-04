
namespace Exercise1
{
    public class Head
    {
        public enum OnOffStatusEnum { On, Off }

        public int MaxCharge { get { return 1200; } }
        public OnOffStatusEnum OnOffStatus { get { return OnOffStatusEnum.Off; } }

        // Other Head respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
