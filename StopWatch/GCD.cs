using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    class GCD
    {
        public int Algorithm1(int n1, int n2)
        {
            while (n1 != 0 && n2 != 0)
                if (n1 > n2)
                    n1 = n1 % n2;
                else
                    n2 = n2 % n1;
            return n1 + n2;
        }

        public int Algorithm2(int n1, int n2)
        {
            if (n2 == 0)
                return n1;
            return Algorithm2(n2, n1 % n2);
        }
    }
}
