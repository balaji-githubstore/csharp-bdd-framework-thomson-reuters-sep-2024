using EmployeeManagementAutomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions 
    {
        private AutomationHooks hooks;
        public EmployeeStepDefinitions(AutomationHooks hooks)
        {
            this.hooks = hooks;
        }

        [When(@"I click on PIM menu")]
        public void WhenIClickOnPIMMenu()
        {
            hooks.driver.FindElement(By.XPath("//span[normalize-space()='PIM']")).Click();
        }

        [When(@"I click on Add Employee menu")]
        public void WhenIClickOnAddEmployeeMenu()
        {

        }

        [When(@"I fill the new employee details")]
        public void WhenIFillTheNewEmployeeDetails(Table table)
        {
            Console.WriteLine(table.Rows[0][0]);
            Console.WriteLine(table.Rows[0][1]);


            Console.WriteLine(table.Rows[0]["firstname"]);
            Console.WriteLine(table.Rows[0]["middlename"]);
        }

        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {

        }

        [Then(@"I should see the profile name as '(.*)'")]
        public void ThenIShouldSeeTheProfileNameAs(string expectedProfileName)
        {
            //get the profile name and assert it
            ////div[@class='orangehrm-edit-employee-name']/h6
        }

        [Then(@"I should verify the employee full name in the text field")]
        public void ThenIShouldVerifyTheEmployeeFullNameInTheTextField()
        {

        }
    }
}
