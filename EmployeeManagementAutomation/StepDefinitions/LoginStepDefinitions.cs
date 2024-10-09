using EmployeeManagementAutomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace EmployeeManagementAutomation.StepDefinitions
{
   [Binding]
    public class LoginStepDefinitions
    {
        private AutomationHooks hooks;
        public LoginStepDefinitions(AutomationHooks hooks)
        {
            this.hooks = hooks;
        }

        [Given(@"I have browser with OrangeHRM application")]
        public void GivenIHaveBrowserWithOrangeHRMApplication()
        {
            hooks.driver = new ChromeDriver();
            hooks.driver.Manage().Window.Maximize();
            hooks.driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            hooks.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        [When(@"I enter username as '(.*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            //send username
            hooks.driver.FindElement(By.Name("username")).SendKeys(username);
        }

        [When(@"I enter password as '(.*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            hooks.driver.FindElement(By.Name("password")).SendKeys(password);
        }

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            hooks.driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
        }

        [Then(@"I should get access to dashboard page with '(.*)'")]
        public void ThenIShouldGetAccessToDashboardPageWith(string expectedText)
        {
            Console.WriteLine("expectedText");
        }

        [Then(@"I should not get access to dashboard with error as '(.*)'")]
        public void ThenIShouldNotGetAccessToDashboardWithErrorAs(string expectedError)
        {
            Console.WriteLine("then" + expectedError);
        }
    }
}
