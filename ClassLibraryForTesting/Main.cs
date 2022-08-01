using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTesting
{
    public class Main : IMain
    {
        public int MathAddition(int numberA, int numberB)
        {
            return (numberA + numberB);
        }
    }
}
