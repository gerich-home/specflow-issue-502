using TechTalk.SpecFlow;

namespace Issue502.StepsA.SameRelativePath.Relative.Path
{
    [Binding]
    public class FailsForSameFileName
    {
        [Given(@"I have entered 50 into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
