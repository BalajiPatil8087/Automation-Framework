using EmployeeManagement.Base;
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
          public static object[] InValidLogin()
        {

            string[] dataset1 = new string[3];
            dataset1[0] = "John";
            dataset1[1] = "John123";
            dataset1[2] = "Invalid credentials";

            string[] dataset2 = new string[3];
            dataset2[0] = "peter";
            dataset2[1] = "peter123";
            dataset2[2] = "Invalid credentials";

            string[] dataset3 = new string[3];
            dataset3[0] = "saul";
            dataset3[1] = "saul123";
            dataset3[2] = "Invalid credentials";

            object[] alldataset = new object[3];//no of testcase

            alldataset[0] = dataset1;
            alldataset[1] = dataset2;
            alldataset[2] = dataset3;

            return alldataset;
        }
       
        [Test,TestCaseSource(nameof(InValidLogin))]
       

        //[Test]
        // [TestCase("John", "John123", "Invalid credentials")]
        //[TestCase("peter", "peter123", "Invalid credentials")]
        //[TestCase("saul", "saul123", "Invalid credentials")]
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
