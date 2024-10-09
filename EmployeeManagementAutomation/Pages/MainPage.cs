using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    /// <summary>
    /// All common elements will be handled
    /// </summary>
    public class MainPage
    {
        private By pimMenuLocator = By.XPath("//span[normalize-space()='PIM']");

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnPIMMenu()
        {
            driver.FindElement(pimMenuLocator).Click();
        }
    }
}
