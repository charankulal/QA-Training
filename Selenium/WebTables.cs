using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class WebTables
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            IWebElement TableElement = chromeDriver.FindElement(By.XPath("//table[@id='table1']"));

            List<IWebElement> AllRows = new List<IWebElement>(TableElement.FindElements(By.XPath("//table[@id='table1']/tbody/tr")));
            List<IWebElement> AllCols = new List<IWebElement>(TableElement.FindElements(By.XPath("//table[@id='table1']/tbody/tr[1]/td")));

            List<IWebElement> ALLData = new List<IWebElement>(TableElement.FindElements(By.XPath("//table[@id='table1']/tbody/tr/td")));

            foreach (IWebElement row in ALLData)
            {
                Console.WriteLine(row.Text);
            }

            Console.WriteLine(AllRows.Count());
            Console.WriteLine(AllCols.Count());
        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(5000);
            chromeDriver.Dispose();
        }
    }
}
