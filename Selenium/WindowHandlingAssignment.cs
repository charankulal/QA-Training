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
    internal class WindowHandlingAssignment
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            // fetch the window handle
            string CurrentWindowHandle = chromeDriver.CurrentWindowHandle;
            Assert.That(CurrentWindowHandle, Is.Not.Null);

            Thread.Sleep(1500);

            // click on the link to open new window

            IWebElement link = chromeDriver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            link.Click();

            // Handling multiple window
            Thread.Sleep(1500);

            IList<string> windowsList = new List<string>(chromeDriver.WindowHandles);

            chromeDriver.SwitchTo().Window(windowsList[1]);

            string childTitle = chromeDriver.Title;

            Assert.That(childTitle, Is.EqualTo("New Window"));

            Thread.Sleep(1500);

            chromeDriver.Close();
            

            chromeDriver.SwitchTo().Window(windowsList[0]);

            string ParentTitle = chromeDriver.Title;
            Assert.That(ParentTitle, Is.EqualTo("The Internet"));



        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
