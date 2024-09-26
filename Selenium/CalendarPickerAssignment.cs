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
    internal class CalendarPickerAssignment
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://www.makemytrip.com/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            //closing ad button
            IWebElement ClosingAdButton = chromeDriver.FindElement(By.XPath("//span[@class='commonModal__close']"));
            ClosingAdButton.Click();

            Thread.Sleep(1500);

            // Opening calendar by pressing departure button
            IWebElement CalendarButton = chromeDriver.FindElement(By.XPath("//span[normalize-space()='Departure']"));
            CalendarButton.Click();
            Thread.Sleep(1500);

            // Changing date to 20
            IWebElement DateButton = chromeDriver.FindElement(By.XPath("//div[@aria-label='Sat Sep 21 2024']//div[@class='dateInnerCell']"));
            DateButton.Click();
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(2000);
            chromeDriver.Dispose();
        }
    }
}
