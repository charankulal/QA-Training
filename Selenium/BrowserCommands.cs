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
    internal class BrowserCommands
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            chromeDriver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {
            // Get the title of page
            string title= chromeDriver.Title;  
            Console.WriteLine(title);

            // current url
            string currentUrl = chromeDriver.Url;
            Console.WriteLine(currentUrl);

            // page source
            string pageSource= chromeDriver.PageSource;
            Console.WriteLine(pageSource);

            chromeDriver.Navigate().Forward();
            Thread.Sleep(2000);

            chromeDriver.Navigate().Refresh();
            Thread.Sleep(2000);

            chromeDriver.Navigate().Back();
            Thread.Sleep(2000);


        }

        [TearDown]
        public void tearDown()
        {
            // close current session of the browser
            chromeDriver.Close();


            // close all session of the browser
            //chromeDriver.Quit();
        }
    }
}
