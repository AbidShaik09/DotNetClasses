using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Cal
    {
        internal int res;

        internal int add(int x, int y)
        {
            res = x + y;
            return res;
        }
        internal int sub(int x, int y)
        {
            res = x - y;
            return res;
        }
        internal int mul(int x, int y) {
            res = x * y;
            return res;
        }
        internal double div(int x, int y)
        {
            if (y != 0)
            {
                res = x / y;
                return x / y;
            }
            else
            {
                throw new DivideByZeroException();
                
            }

        }
        internal int mod(int x, int y)
        {
            res = x % y;
            return res;
        }

    }

    internal class MathCal: Cal
    {
        internal int add(int[] x) {
            res = 0;
           
                foreach (int i in x)
                {
                    res += i;
                }
            return res;
        }
    }
}
