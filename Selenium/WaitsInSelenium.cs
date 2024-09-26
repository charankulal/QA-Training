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
    internal class WaitsInSelenium
    {
        IWebDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            // navigation to link
            chromeDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            chromeDriver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {
            // Implicit wait will apply to every elements in the session

            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);


            IWebElement Username = chromeDriver.FindElement(By.Name("username"));
            Username.SendKeys("Admin");

            IWebElement Password = chromeDriver.FindElement(By.Name("password"));
            Password.SendKeys("admin123");

            IWebElement Submit = chromeDriver.FindElement(By.XPath("//button[@type='submit']"));


            // Explicit wait for particular element
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(2));
            wait.Until(d => Submit.Displayed);

            Submit.Click();

            // Fluent wait

            WebDriverWait wait1 = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(2))
            {
                PollingInterval = TimeSpan.FromMilliseconds(300),
            };
            wait1.IgnoreExceptionTypes(typeof(ElementNotInteractableException));

            wait1.Until(d =>
            {
                Username.SendKeys("Displayed");
                return true;
            });
        }

        [TearDown]
        public void tearDown()
        {
           
            chromeDriver.Dispose();
        }
    }
}
