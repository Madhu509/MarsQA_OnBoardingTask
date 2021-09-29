using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature.Profile
{
    [Binding]
    public class SearchSkillsSteps
    {
        [Given(@"the user is on Profile tab")]
        public void GivenTheUserIsOnProfileTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the user inputs search key in search inputbox and click on searchicon")]
        public void GivenTheUserInputsSearchKeyInSearchInputboxAndClickOnSearchicon()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user input search key Refine search and click on searchicon")]
        public void WhenTheUserInputSearchKeyRefineSearchAndClickOnSearchicon()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user input search user key search user and click on searchicon")]
        public void WhenTheUserInputSearchUserKeySearchUserAndClickOnSearchicon()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"add  any of the filters the filtered search should be displayed")]
        public void WhenAddAnyOfTheFiltersTheFilteredSearchShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the refined search items should be Displayed")]
        public void ThenTheRefinedSearchItemsShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
