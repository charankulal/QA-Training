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
    internal class DynamicWebElement
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://www.cavai.com/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            IWebElement dynamicElement = chromeDriver.FindElement(By.XPath("//a[contains(text(),'Privacy Policy')]"));
            string footer_text=dynamicElement.Text;
            Console.WriteLine(footer_text); 


        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
