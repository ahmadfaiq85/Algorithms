using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Factorial
    {
        //n! = n * (n-1)!
        public int RecursiveFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * RecursiveFactorial(n - 1);
        }
    }
}
