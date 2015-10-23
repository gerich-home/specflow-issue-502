using TechTalk.SpecFlow;

namespace Issue502.StepsB.SameRelativePath.Relative.Path
{
    [Binding]
    public class ClassNameDoesNotMatter
    {
        [Given(@"I have entered 70 into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
