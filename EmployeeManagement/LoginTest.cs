using EmployeeManagement.Base;
using EmployeeManagement.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public  class LoginTest : AutomationWrapper
    {
        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string actualurl=driver.Url;
            Assert.That(actualurl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
            
        }
         
       
        [Test,TestCaseSource(typeof(DataSource),nameof(DataSource.InvalidLoginData2))]
       

        
        public void InValidLoginTest(String username, string password, string exceptedError)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string errmsg = driver.FindElement(By.XPath("//p[normalize-space()='Invalid credentials']")).Text;
          // Console.WriteLine(errmsg.ToUpper());

            Assert.That(errmsg.Contains(exceptedError), "Assertion on error msg");


        }

    }
}
