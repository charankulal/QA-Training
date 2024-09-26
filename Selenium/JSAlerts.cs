using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.DevTools.V126.Network;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class JSAlerts
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            //Simple alert

            IWebElement simpleAlert = chromeDriver.FindElement(By.XPath("//button[@onclick='jsAlert()']"));
            simpleAlert.Click();

            // switch control from driver to alert 

            IAlert alert = chromeDriver.SwitchTo().Alert();
            Thread.Sleep(2000);
            alert.Accept();

            Thread.Sleep(2000);
            //confirmational Alert
            IWebElement conditionalAlert = chromeDriver.FindElement(By.XPath("//button[@onclick='jsConfirm()']"));
            conditionalAlert.Click();
            Thread.Sleep(2000);
            alert.Dismiss();

            Thread.Sleep(2000);
            IWebElement promptAlert = chromeDriver.FindElement(By.XPath("//button[@onclick='jsPrompt()']"));
            promptAlert.Click();
            Thread.Sleep(2000);
            alert.SendKeys("ABC");
            Thread.Sleep(2000);
            Console.WriteLine(alert.Text);
            alert.Accept();

        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
