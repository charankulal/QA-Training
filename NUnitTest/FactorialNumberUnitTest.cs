using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class FactorialNumberUnitTest
    {
        FactorialNumber factorialNumber;

        [SetUp]
        public void SetupFactorial()
        {
            factorialNumber = new FactorialNumber();
            Console.WriteLine("Completed SetUP");
        }

        [Test]
        public void TestCaseOne()
        {
            int result = factorialNumber.Factorial(0);
            //Assert.AreEqual(1, result);
        }

        [Test]
        public void TestCaseTwo()
        {
            int result = factorialNumber.Factorial(1);
            //Assert.AreEqual(1, result);

        }

        [Test]
        public void TestCaseThree()
        {
            int result = factorialNumber.Factorial(2);
            //Assert.AreEqual(2, result);
        }

        [Test]
        public void TestCaseFour()
        {
            int result = factorialNumber.Factorial(3);
            //Assert.AreEqual(6, result);
        }

        [TearDown]
        public void TearDownFactorial()
        {
            Console.WriteLine("Teardown");
        }
    }
}
