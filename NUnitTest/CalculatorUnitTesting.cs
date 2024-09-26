using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class CalculatorUnitTesting
    {
        Calculator calculator= new Calculator();

        [Test]
        public void AddTest()
        {
            int result = calculator.Add(2, 3);
            int result1= calculator.Add(3, -4);

            //Assertion
            //Assert.AreEqual(5, result);
            //Assert.AreEqual(-1, result1);
        }

        [Test]
        public void SubTest()
        {
            int result = calculator.Substract(2, 3);
            int result1 = calculator.Substract(3, -4);

            ////Assertion
            //Assert.AreEqual(-1, result);
            //Assert.AreEqual(7, result1);
        }
    }
}
