using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTest
{
    public class diagonalDifferenceProblem
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int m = arr.Count - 1;
            int L2R = 0;
            int R2L = 0;
            
       for (int i = 0; i < arr.Count; i++)
            {
                L2R += arr[i][i];
                R2L += arr[i][m];
                m--;

            }

            return Math.Abs(L2R - R2L);
        }
    }
}
