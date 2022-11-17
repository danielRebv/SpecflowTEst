using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SpecflowTEst.Hooks
{
    [Binding]
    public class HooksSel 
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;

        public HooksSel(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void initialize()
        {
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
            _driver.Manage().Window.Maximize();
        }


        [AfterScenario]
        public void CleanUp()
        {
           _driver.Quit();  
        }
    }
}