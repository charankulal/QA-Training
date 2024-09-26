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
    internal class DragAndDrop
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            IWebElement Source = chromeDriver.FindElement(By.XPath("//div[@id='column-a']"));
            IWebElement Dest = chromeDriver.FindElement(By.XPath("//div[@id='column-b']"));

            new Actions(chromeDriver).DragAndDrop(Source, Dest).Perform();
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
