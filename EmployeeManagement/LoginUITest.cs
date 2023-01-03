using EmployeeManagement.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class Tests : AutomationWrapper
    {
       
        [Test]
        public void ValidateTitleTest()
        {
            string actualTitle= driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));

        }

        [Test]
        public void ValidatePlaceholderTest()
        {
            string actualUsernamePlaceholder = driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            string actualPasswordPlaceholder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");
            Assert.That(actualPasswordPlaceholder, Is.EqualTo("Password"));


        }
    }
}