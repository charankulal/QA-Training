using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class Login
    {
        IWebDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            // navigation to link
            chromeDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            chromeDriver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {
            Thread.Sleep(2000);
            IWebElement Username = chromeDriver.FindElement(By.Name("username"));
            Username.SendKeys("Admin");

            IWebElement Password= chromeDriver.FindElement(By.Name("password"));
            Password.SendKeys("admin123");

            IWebElement Submit = chromeDriver.FindElement(By.XPath("//button[@type='submit']"));
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
