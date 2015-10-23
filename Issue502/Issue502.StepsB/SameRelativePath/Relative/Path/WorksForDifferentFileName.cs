using TechTalk.SpecFlow;

namespace Issue502.StepsB.SameRelativePath.Relative.Path
{
    [Binding]
    public class WorksForDifferentFileName
    {
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
