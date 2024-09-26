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
    internal class RadioButtons
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            //Checking single checkboxes

            IWebElement rb1 = chromeDriver.FindElement(By.XPath("(//input[@type='radio'])[1]"));
            rb1.Click();

            //Thread.Sleep(2000);

            //IWebElement rb2 = chromeDriver.FindElement(By.XPath("(//input[@type='radio'])[2]"));
            //rb2.Click();


        }


        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
