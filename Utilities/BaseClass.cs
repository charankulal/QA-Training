using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using NLog.Internal;
using System.Configuration;

namespace NUnitSeleniumCSharp.Utilities
{
    public class BaseClass
    {

        public static IWebDriver? driver;
        [SetUp]
        public void startbrowser()
        { 
            string browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
        }


        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox": 
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
        }
    
    }
}
