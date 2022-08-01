using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForTesting;
using Xunit;

namespace ClassLibraryyForTesting_XUnitTest
{
    public class Main_Test
    {
        IMain main = new Main();

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 1, 3)]
        [InlineData(4, 2, 6)]
        public void Math_Addition(int numberA, int numberB, int facit)
        {
            //SETUP
            int a = numberA;
            int b = numberB;
            int number;

            //ATTEMPT
            number = main.MathAddition(a, b);

            //VERIFY
            Assert.Equal(facit, number);
        }
    }
}
