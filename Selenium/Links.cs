using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnitSeleniumCSharp.Utilities;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class Links : BaseClass
    {
    
        
        [Test]
        public void test()
        {
            IReadOnlyList<IWebElement> elements =driver.FindElements(By.TagName("a"));

            foreach (IWebElement element in elements)
            {
                Console.WriteLine(element.Text + " The URL is "+ element.GetAttribute("href"));
                Console.WriteLine("Thank you");
            }

        }

    }
}
