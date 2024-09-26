using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NUnitSeleniumCSharp.NUnitTest
{
    internal class Assertions
    {

        [Test]
        public void testassertion()
        {

            string actual = "charan";
            string expected = "Kulal";
            /*if (actual != expected)
            {
                Console.WriteLine("Not matching");
            }
            else
            {
                Console.WriteLine("Matching");
            }*/

            // Equal
            //Assert.AreEqual(expected, actual);

            //Same
            //Assert.AreSame(expected, actual);

            // That
            Assert.That(actual, Is.EqualTo(expected));

            //Assert for string ignore case
            Assert.That(actual, Is.EqualTo(expected).IgnoreCase);

            // substring method
            Assert.That(actual, Does.Contain("cha").IgnoreCase);
            Assert.That(actual, Does.Not.Contain("cha").IgnoreCase);

            ////Empty
            //Asse.IsEmpty(actual);
            //Assert.That(actual,Is.Empty);
            


            //Is Null
            //Assert.IsNull(actual);

            // Collection constraints

            int[] array = { 1, 2, 3 };

            // Not null
            //Assert.NotNull(array);

            //greater than
            Assert.That(array,Is.All.GreaterThan(0));

            // Empty
            Assert.That(array, Is.Empty);

            //Order
            Assert.That(array, Is.Ordered.Ascending);

            //custom assertions
            int age = 17;
            if (age < 18)
            {
                throw new AssertionException("Age should be more than 18");
            }
        }

        
    }
}
