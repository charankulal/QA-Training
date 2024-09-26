﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
    {
        [Test]
        public void Login()
        {
            Console.WriteLine("Login successful");
        }


        [Test]
        public void Logout()
        {

            Console.WriteLine("Logout successful");
        }

        [Test]
        public void products()
        {
            Console.WriteLine("Products");
        }

        [Test]
        public void addTocart()
        {
            Console.WriteLine("Add to cart");
        }
    }
}
