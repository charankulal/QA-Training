using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class DropDown
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            IWebElement dropdown = chromeDriver.FindElement(By.XPath("(//select[@id='dropdown-class-example'])"));
            Assert.That(dropdown, Is.Not.Null);

            var select = new SelectElement(dropdown);

            // select by visible text

            select.SelectByText("Option2");

            Thread.Sleep(2000);
            //select by index

            select.SelectByIndex(1);

            //select by attribute value
            Thread.Sleep(2000);
            select.SelectByValue("option3");

            
        }


        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
