
namespace Exercise2
{
    public class LeftArm : IRobotPart
    {

        public enum OnOffStatusEnum { On, Off }

        private readonly int _maxCharge = 2200;
        private readonly OnOffStatusEnum _onOffStatus = OnOffStatusEnum.Off;

        public void AcceptLogVisitor(Dashboard visitor)
        {
            visitor.LogStatus("Left arm", _onOffStatus == OnOffStatusEnum.On);
            visitor.LogMaxCharge(_maxCharge);
        }

        // Other LeftArm respnonsibilities omitted because implementation is not needed for the exercise
        // ...
    }
}
