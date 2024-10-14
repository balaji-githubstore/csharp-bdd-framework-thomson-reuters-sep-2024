using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Hooks
{
    [Binding]
    public class AutomationHooks
    {
        public IWebDriver driver;
        public int a = 10;
        public string name = "orangehrm";

        [AfterScenario]
        public void EndScenario()
        {
            if(driver !=null)
            {
                driver.Dispose();
            }
        }
       
    }
}
