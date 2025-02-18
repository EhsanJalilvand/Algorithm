using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Recursive
    {
        int fact(int n)
        {
            if (n <= 1) return 1;
            return n * fact(n - 1);

        }
        int fib(int n)
        {
            if (n <= 1) return 1;
            return fib(n - 1) + fib(n - 2);

        }
    }
}
