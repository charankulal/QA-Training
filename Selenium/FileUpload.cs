using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Models.Chrome;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class FileUpload
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            IWebElement fileuploader = chromeDriver.FindElement(By.XPath("//input[@id='file-upload']"));
            fileuploader.SendKeys("C:\\Users\\ckula\\Pictures\\Screenshots\\Screenshot 2024-08-17 192718.png");

            Thread.Sleep(2000);
            IWebElement uploadbutton = chromeDriver.FindElement(By.XPath("//input[@id='file-submit']"));
            uploadbutton.Click();

            Thread.Sleep(2000);
            IWebElement textres = chromeDriver.FindElement(By.XPath("//h3[normalize-space()='File Uploaded!']"));
            string res = textres.Text;
            Console.WriteLine(res);

            Assert.That(res.Equals("File Uploaded!"));

        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
