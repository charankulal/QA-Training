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
    internal class VerticalScrolling
    {

        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://www.selenium.dev/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            // vertical scrolling
            IJavaScriptExecutor js = (IJavaScriptExecutor) chromeDriver;
            js.ExecuteScript("window.scrollBy(0,200)", "");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)", "");
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
