
using OpenQA.Selenium;


namespace SpecflowTEst.StepDefinitions
{
    [Binding]
    public class GSearchSteps 
    {
        private IWebDriver _driver;

        public GSearchSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I navigate to google")]
        public void GivenINavigateToGoogle()

        {
            _driver.Navigate().GoToUrl("http://www.google.com");
        }

        [When(@"I Search Tsoft on google")]
        public void WhenISearchTsoftOnGoogle()
        {
            _driver.FindElement(By.Name("q")).SendKeys("Tsoft");
            _driver.FindElement(By.Name("q")).Submit();
            Thread.Sleep(1000);

        }

        [Then(@"I click Tsoft WebPage")]
        public void ThenIClickTsoftWebPage()
        {
            _driver.FindElement(By.XPath("//h3[normalize-space()='HOME - TSOFT - Make IT Real']")).Click();
            
        }

    }
}
