using TechTalk.SpecFlow;

namespace Issue502.StepsA
{
    [Binding]
    public class WorksForDifferentFileName
    {
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
