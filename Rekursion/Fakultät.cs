namespace Rekursion
{
    public class Fakultät
    {
        public int FakultätCalc(int number)
        {
            if(number < 1)
                return 0;
            if(number == 1)
            {
                return number;
            }
            int retval = number;
            for (int i = 1; i < number; i++)
            {
                retval = retval * i;
            }
            return retval;
        }
    }
}