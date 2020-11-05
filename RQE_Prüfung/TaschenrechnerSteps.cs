using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;
using Xunit;

namespace RQE_Prüfung
{
    [Binding]
    public class TaschenrechnerSteps
    {

        var result = 0;

        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the number (.*)")]
        public void GivenTheNumber(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i want the Sinus")]
        public void WhenIWantTheSinus()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i want the Cosinus")]
        public void WhenIWantTheCosinus()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I want the Tangens")]
        public void WhenIWantTheTangens()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = result;
            var actual = p0;
            Assert.Equal(expected, actual, 5);
        }
    }
}
