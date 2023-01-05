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
    public class EmployeeTest:AutomationWrapper
    {
        [Test]
        public void AddEmployeeTest()
        {

            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();

            Thread.Sleep(10000);

            driver.FindElement(By.XPath("//button[normalize-space()=\"Add\"]")).Click();

            driver.FindElement(By.Name("firstName")).SendKeys("John");
            driver.FindElement(By.Name("middleName")).SendKeys("W");
            driver.FindElement(By.Name("lastName")).SendKeys("wick");

            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();

            string actualtext=driver.FindElement(By.XPath("//h6[normalize-space()=\"John wick\"]")).Text;

            Assert.That(actualtext, Is.EqualTo("John wick"));

            Thread.Sleep(10000);
        }


        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.EmployeeData))]
        public void AddValidEmployee(string username, string password, String firstName, string middleName, string lastName, string employeename)
        {


            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            //string errmsg = driver.FindElement(By.XPath("//p[normalize-space()='Invalid credentials']")).Text;
            // Console.WriteLine(errmsg.ToUpper());

            //Assert.That(errmsg.Contains(exceptedError), "Assertion on error msg");
            Thread.Sleep(10000);

            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();

            Thread.Sleep(10000);

            driver.FindElement(By.XPath("//button[normalize-space()=\"Add\"]")).Click();


            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("middleName")).SendKeys(middleName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);

            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();

            string actualtext = driver.FindElement(By.CssSelector("[class='oxd-text oxd-text--h6 --strong']")).Text;
            actualtext.ToString();
            Assert.That(employeename.Contains(actualtext), "Assert on error msg");
        }



    }
}
