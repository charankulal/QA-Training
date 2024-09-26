using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCSharp.NUnitTest
{
    internal class FactorialNumber
    {
        public int Factorial(int a)
        {
            int factorial = 1;
            for(int i=2;i<=a;i++)
                factorial *= i;
            return factorial;
        }
    }
}
