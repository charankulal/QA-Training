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
    internal class FacebookAssignment
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://www.facebook.com/login/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            IWebElement UsernameInput = chromeDriver.FindElement(By.XPath("//input[@id='email']"));

            new Actions(chromeDriver).KeyDown(Keys.Shift).SendKeys("abc2gmail").KeyUp(Keys.Shift).SendKeys(".").KeyDown(Keys.Shift).SendKeys("com").KeyUp(Keys.Shift).KeyDown(Keys.Tab).SendKeys("abcd").KeyDown(Keys.Tab).Click().Perform();


        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
