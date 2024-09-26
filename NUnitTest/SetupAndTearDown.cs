using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class SetupAndTearDown
    {
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Launching chrome broswer");
        }

        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("Closing chrome browser");
        }

        [Test]
        [Order(1)]
        public void Login()
        {
            Console.WriteLine("Login successful");
        }


        [Test]
        [Order(2)]
        public void Logout()
        {

            Console.WriteLine("Logout successful");
        }

        [Test]
        [Order(3)]
        public void products()
        {
            Console.WriteLine("Products");
        }

        [Test]
        [Order(4)]
        public void addTocart()
        {
            Console.WriteLine("Add to cart");
        }
    }
}
