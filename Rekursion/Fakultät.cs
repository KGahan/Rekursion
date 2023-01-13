using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    public class Fakultät
    {

        public int Fakultätt(int number)
        {
            if(number < 1)
                return 0;
            if(number == 1)
            {
                return number;
            }
            return number * FakultätCalc(number -1);
        }

        private int FakultätCalc(int num)
        {
            int retval = num;

            for(int i = 1; i < num; i++)
            {
                retval = retval * i; 
            }
            return retval;
        }
    }
}