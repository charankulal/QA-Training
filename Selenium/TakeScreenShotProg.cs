using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class TakeScreenShotProg
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
            // taking screen shots
            Screenshot ss = chromeDriver.TakeScreenshot();
            ss.SaveAsFile("C:\\Users\\ckula\\Downloads\\err.jpg");

        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
