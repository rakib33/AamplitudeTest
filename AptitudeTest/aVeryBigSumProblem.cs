using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTest
{
    public class aVeryBigSumProblem
    {
        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach (long v in ar)
            {
                sum += v;
            }
            return sum;
        }
    }
}
