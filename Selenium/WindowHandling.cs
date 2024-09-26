using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Models.Chrome;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class WindowHandling
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/window_switching_tests/page_with_frame.html");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            // fetch the window handle
            string CurrentWindowHandle = chromeDriver.CurrentWindowHandle;
            Assert.That(CurrentWindowHandle,Is.Not.Null);

            // click on the link to open new window

            IWebElement link = chromeDriver.FindElement(By.XPath("//a[@id='a-link-that-opens-a-new-window']"));
            link.Click();

            // Handling multiple window
            Thread.Sleep(1500);

            IList<string> windowsList = new List<string>(chromeDriver.WindowHandles);

            chromeDriver.SwitchTo().Window(windowsList[1]);

            IWebElement title = chromeDriver.FindElement(By.XPath("//div[normalize-space()='Simple page with simple test.']"));

            Assert.That( title.Text,Is.EqualTo("Simple page with simple test."));

            Thread.Sleep(1500);

            chromeDriver.SwitchTo().Window(windowsList[0]);

            string ParentTitle = chromeDriver.Title;
            Assert.That(ParentTitle, Is.EqualTo("Test page for WindowSwitchingTest.testShouldFocusOnTheTopMostFrameAfterSwitchingToAWindow"));
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
