using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class LaunchEdge
    {
        [SetUp]
        public void startbrowser()
        {
            // configuring firefox browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            // initialized driver
            EdgeDriver driver = new EdgeDriver();

            // navigation to link
            driver.Navigate().GoToUrl("https://www.orangehrm.com/");
        }

        [Test]
        public void test()
        {
        }

        [TearDown]
        public void tearDown()
        {
        }
    }
}
