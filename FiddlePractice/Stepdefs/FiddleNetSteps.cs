using FiddlePractice.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace FiddlePractice.Stepdefs
{
    [Binding]
    public class FiddleNetSteps
    {
        FiddleNetPage fiddlePage;
        public FiddleNetSteps()
        {
            fiddlePage = new FiddleNetPage();
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            fiddlePage.naviagteToUrl(url);
        }
        
        [When(@"I click on getting started")]
        public void WhenIClickOnGettingStarted()
        {
            fiddlePage.IClickOnGettingStarted();
        }
        
        [When(@"I click on back editor")]
        public void WhenIClickOnBackEditor()
        {
            fiddlePage.IClickOnBackEditor();
        }
        
        [Then(@"I should see ""(.*)"" is displayed on the landing page output")]
        public void ThenIShouldSeeIsDisplayedOnTheLandingPageOutput(string helloWorld)
        {
            Assert.That(fiddlePage.IsHelloWorldDisplayed);
        }
    }
}
