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
        [When(@"I click on PIM menu")]
        public void WhenIClickOnPIMMenu()
        {
  
        }

        [When(@"I click on Add Employee menu")]
        public void WhenIClickOnAddEmployeeMenu()
        {
  
        }

        [When(@"I fill the new employee details")]
        public void WhenIFillTheNewEmployeeDetails(Table table)
        {
       
        }

        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {
 
        }

        [Then(@"I should see the profile name as '(.*)'")]
        public void ThenIShouldSeeTheProfileNameAs(string expectedProfileName)
        {
      
        }

        [Then(@"I should verify the employee full name in the text field")]
        public void ThenIShouldVerifyTheEmployeeFullNameInTheTextField()
        {
           
        }
    }
}
