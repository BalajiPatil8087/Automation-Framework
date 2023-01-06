using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace EmployeeManagement.Base
{
    public class AutomationWrapper
    {
        protected IWebDriver driver;
        [SetUp]
        public void BeforeMethod()
        {
            string browserName = "edge";

            if (browserName.ToLower().Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            else if (browserName.ToLower().Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                driver = new ChromeDriver();
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        }
        [TearDown]
        public void AfterMethod()
        {
            driver.Quit();
        }
    }
}
