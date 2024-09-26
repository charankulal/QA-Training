﻿using NUnitSeleniumCSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.Parallel
{
    [Parallelizable]
    internal class ParallelExecutionTestParams : BaseClass
    {
        [Parallelizable(ParallelScope.Children)]
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(username + " " + password);
            Console.WriteLine(currentTime.ToString("yyyy-mm-dd-hh-mm-ss"));
            Thread.Sleep(2000);
            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement Submit = driver.FindElement(By.XPath("//button[@type='submit']"));
            Submit.Click();
            Thread.Sleep(2000);

        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("Admin", "admin123");
            yield return new TestCaseData("cds@gmail.com", "1232");
            yield return new TestCaseData("sss@gmail.com", "1232");
        }
    }
}
