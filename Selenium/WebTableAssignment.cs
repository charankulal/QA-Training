using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using static System.Net.Mime.MediaTypeNames;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class WebTableAssignment
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
            // IWebElement data = chromeDriver.FindElement(By.XPath("//td[contains(text(),'QA Expert Course :Software Testing + Bugzilla + SQ')]"));
            IWebElement data = chromeDriver.FindElement(By.XPath("//table[@id = 'product' and @name = 'courses']/tbody/tr[8]/td[2]"));
            Console.WriteLine(data.Text);
            Assert.That("QA Expert Course :Software Testing + Bugzilla + SQL + Agile", Is.EqualTo(data.Text));
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
