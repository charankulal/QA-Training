using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    internal class UnittestCalciSetUPTeardown
    {
        Calculator calculator;
        [SetUp ]
        public void Setup()
        {
           calculator = new Calculator();
            Console.WriteLine("Initialized calculator object");
        }

        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("Completed the execution");
        }
        

        [Test]
        public void AddTest()
        {
            int result = calculator.Add(2, 3);
            int result1 = calculator.Add(3, -4);

            //Assertion
            //Assert.AreEqual(5, result);
            //Assert.AreEqual(-1, result1);
        }

        [Test]
        public void SubTest()
        {
            int result = calculator.Substract(2, 3);
            int result1 = calculator.Substract(3, -4);

            //Assertion
            //Assert.AreEqual(-1, result);
            //Assert.AreEqual(7, result1);
        }
    }
}
