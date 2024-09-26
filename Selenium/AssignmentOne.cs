using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class AssignmentOne
    {
        EdgeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            // initialized driver
            chromeDriver = new EdgeDriver();

            // navigation to link
            chromeDriver.Navigate().GoToUrl("https://www.saucedemo.com/");

            chromeDriver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {
            Thread.Sleep(2000);
            IWebElement Username = chromeDriver.FindElement(By.Name("user-name"));
            Username.SendKeys("standard_user");

            IWebElement Password = chromeDriver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            IWebElement Submit = chromeDriver.FindElement(By.Name("login-button"));
            Submit.Click();
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
