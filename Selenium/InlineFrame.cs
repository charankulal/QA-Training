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
    internal class InlineFrame
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            IWebElement IframeOne = chromeDriver.FindElement(By.XPath("//iframe[@class='demo-frame']"));

            //chromeDriver.SwitchTo().Frame(IframeOne);

            chromeDriver.SwitchTo().Frame(0);

            

            IWebElement radio = chromeDriver.FindElement(By.XPath("//label[normalize-space()='New York']"));
            radio.Click();
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
