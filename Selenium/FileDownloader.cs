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
    internal class FileDownloader
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            

            IWebElement file = chromeDriver.FindElement(By.XPath("//a[normalize-space()='cypress_architecture.jpg']"));
            file.Click();

            string text = file.Text;
            string path = "C:\\Users\\ckula\\Downloads\\"+text;
            Thread.Sleep(4000);
            Console.WriteLine(path);
            Assert.That(File.Exists(path));

        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
