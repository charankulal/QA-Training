using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class PrimeNumberUnitTest
    {
        PrimeNumber prime;
        [SetUp]
        public void SetUp()
        {
            prime = new PrimeNumber();
            Console.WriteLine("Completed setup");
        }

        [Test]
        public void TestForPrime()
        {
            //Assert.IsTrue(prime.IsPrime(2));
            //Assert.IsTrue(prime.IsPrime(3));
            //Assert.IsTrue(prime.IsPrime(29));
        }

        [Test]
        public void TestForNonPrime()
        {
        //    Assert.IsFalse(prime.IsPrime(1));
        //    Assert.IsFalse(prime.IsPrime(4));
        //    Assert.IsFalse(prime.IsPrime(8000));
        }

        [Test]
        public void TestForNegative()
        { 
        //    Assert.IsFalse (prime.IsPrime(-1));
        //    Assert.IsFalse(prime.IsPrime(-650));
        }
    }
}
