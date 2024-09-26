using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class Description
    {
        [Test]
        [Description("Verifies the login functionality with valid data")]
        public void testcase1()
        {
            Console.WriteLine("Description");
        }
    }
}
