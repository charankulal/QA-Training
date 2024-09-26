using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class Checkbox
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            //chromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");

            chromeDriver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            //Checking single checkboxes

            //IWebElement checkbox1 = chromeDriver.FindElement(By.XPath("(//input[@type='checkbox'])[1]"));
            //checkbox1.Click();

            //IWebElement checkbox2 = chromeDriver.FindElement(By.XPath("(//input[@type='checkbox'])[2]"));
            //checkbox2.Click();

            // Multiple Textboxes

            IReadOnlyList<IWebElement> checkboxes = chromeDriver.FindElements(By.XPath("(//input[@type='checkbox'])"));

            foreach (IWebElement checkbox in checkboxes)
            {
                checkbox.Click();
            }

        }


        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }

    }
}
