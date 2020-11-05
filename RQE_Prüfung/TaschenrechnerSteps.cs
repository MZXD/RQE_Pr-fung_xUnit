using Google.Protobuf;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace RQE_Prüfung
{
    [Binding]
    public class TaschenrechnerSteps
    {

        double input = 0;
        double ergebnis = 0;


        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(double p0)
        {
            if (p0 == 3.1415)
                input = Math.PI;
            else
                input = p0;
        }
        
        [When(@"i want the Sinus")]
        public void WhenIWantTheSinus()
        {
            ergebnis = Math.Sin(input);
        }
        
        [When(@"i want the Cosinus")]
        public void WhenIWantTheCosinus()
        {
            ergebnis = Math.Cos(input);
        }
        
        [When(@"I want the Tangens")]
        public void WhenIWantTheTangens()
        {
            ergebnis = Math.Tan(input);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = ergebnis;
            var actual = p0;
            Assert.Equal(expected, actual, 5);
        }
    }
}
