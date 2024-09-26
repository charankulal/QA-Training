using NUnitSeleniumCSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.DataDrivenTesting
{
    internal class TestParamExcel : BaseClass
    {

        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + " " + password);
            Thread.Sleep(2000);
            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement Submit = driver.FindElement(By.XPath("//button[@type='submit']"));
            Submit.Click();
            Thread.Sleep(2000);

            IWebElement error = driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
            Assert.That(error.Text, Is.EqualTo("Invalid credentials"));
        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            var columns = new List<string> { "username", "password" };
            return ExcelRead.GetTestDataFromExcel("C:\\Users\\ckula\\source\\repos\\NUnitSeleniumCSharp\\testdata.xlsx", "LoginTest", columns);
        }
    }
}
