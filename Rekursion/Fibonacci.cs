using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    public class Fibonacci
    {
        public int Fibonaccii(int number)
        {
            if (number < 1)
                return 0;
            if (number == 1 || number == 2)
            {
                return 1;
            }
            return FibonacciCalc(number-1) + FibonacciCalc(number - 2);
        }

        private int FibonacciCalc(int num)
        {
            int retval = 0;
            int temp = 1;
            for (int i = 0; i < num; i++)
            {
                int temp2 = retval;
                retval = temp;
                temp = temp2 + temp;
            }
            return retval;
        }
    }
}
