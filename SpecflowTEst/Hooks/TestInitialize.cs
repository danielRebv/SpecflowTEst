using TechTalk.SpecFlow;

namespace SpecflowTEst.Hooks
{
    [Binding]
    public sealed class TestInitialize
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeTestRun] 
        public static void InitializeTest() 
        {
            Console.WriteLine("This Line is execute from before Test");
        }

        [BeforeFeature]
        public static void BeforeFeatureTest() 
        {
            Console.WriteLine("This Line is execute from before Feature");
        }


        [BeforeScenario("mytag")]
        public void BeforeScenarioWithTag()
        {
            
            Console.WriteLine("This Line is execute from before scenario with tag ");
            
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("This Line is execute from after Scenario");
        }
    }
}