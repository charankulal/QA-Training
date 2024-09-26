using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class CategoryTesting
    {
        [Test]
        [Category("Regression")]
        public void Login()
        {
            Console.WriteLine("Login successful");
        }



        [Test]
        //[Category("Sanity, Regression")]
        [Ignore("Id: 4")]
        public void products()
        {
            Console.WriteLine("Products");
        }

        [Test]
        [Category("Regression")]
        public void addTocart()
        {
            Console.WriteLine("Add to cart");
        }
    }
}
