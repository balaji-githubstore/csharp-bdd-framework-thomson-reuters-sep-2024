using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class PersonalDetailPage
    {
        private IWebDriver driver;

        public PersonalDetailPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
