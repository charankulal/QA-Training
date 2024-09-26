using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class KeyboardActions
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/single_text_input.html");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            new Actions(chromeDriver).KeyDown(Keys.Shift).SendKeys("a").Perform();
            new Actions(chromeDriver).KeyUp(Keys.Shift).SendKeys("a").Perform();
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
