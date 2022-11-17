using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowTEst.StepDefinitions

{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheFirstNumberIs)} : {number}");

        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)} : {number}");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)}");
        }

        [Then(@"the result should ""([^""]*)""")]
        public void ThenTheResultShould(string result)
        {
            Console.WriteLine($"{nameof(ThenTheResultShould)}:{result}");
        }

        [Given(@"I input following number to the calculator")]
        public void GivenIInputFollowingNumberToTheCalculator(Table table)
        {

            dynamic datas = table.CreateDynamicSet();

            foreach (var item in datas)
            {
                Console.WriteLine($"The numbers are : {item.Numbers}");
            }
            
        }

        [Then(@"I see the result and few more details")]
        public void ThenISeeTheResultAndFewMoreDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            Console.WriteLine($"The Resulto is going to hold the value {data.Results} with logo {data.Logo}");
        }


    }

    public record Calculation
    {
        public int Numbers { get; set; }
    }
}