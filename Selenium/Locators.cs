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
    internal class Locators
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            // navigation to link
            chromeDriver.Navigate().GoToUrl("https://automationexercise.com/contact_us");

            chromeDriver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {
            Thread.Sleep(2000);
            IWebElement Name = chromeDriver.FindElement(By.Name("name"));
            Name.SendKeys("Jeeva");

            IWebElement Email = chromeDriver.FindElement(By.CssSelector("input[placeholder='Email']"));
            Email.SendKeys("jeeva@gmail.com");

            IWebElement Subject = chromeDriver.FindElement(By.Name("subject"));
            Subject.SendKeys("Leave Application");

            IWebElement Message = chromeDriver.FindElement(By.Id("message"));
            Message.SendKeys("I am going to home town.");

            
            IWebElement SubmitButton = chromeDriver.FindElement(By.Name("submit"));
            SubmitButton.Click();
        }


        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
