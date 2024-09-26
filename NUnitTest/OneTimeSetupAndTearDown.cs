using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
 
    [SetUpFixture]
    internal class OneTimeSetupAndTearDown
    {
        [OneTimeSetUp]
        public void DBConnection()
        {
            TestContext.Progress.WriteLine("Opening the DB Connection");
        }


        [OneTimeTearDown]
        public void DBTearDown() {
            TestContext.Progress.WriteLine("Closing the DB Connection"); 
        }

    }
}
