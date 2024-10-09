using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.Pages
{
    public class AddEmployeePage
    {
        private IWebDriver driver;

        public AddEmployeePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
