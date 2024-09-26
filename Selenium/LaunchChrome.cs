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
    internal class LaunchChrome
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            
            // initialized driver
            chromeDriver = new ChromeDriver();

            // navigation to link
            chromeDriver.Navigate().GoToUrl("https://www.orangehrm.com/");
        }

        [Test]
        public void test()
        {
            IWebElement Username = chromeDriver.FindElement(By.Name("username"));
        }

        [TearDown]
        public void tearDown()
        {
            chromeDriver.Close();
        }
    }
}
