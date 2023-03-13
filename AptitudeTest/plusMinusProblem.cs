using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTest
{
    //https://www.hackerrank.com/challenges/one-week-preparation-kit-plus-minus/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-week-preparation-kit&playlist_slugs%5B%5D=one-week-day-one
    public class plusMinusProblem
    {
        /*
    * Complete the 'plusMinus' function below.
    *
    * The function accepts INTEGER_ARRAY arr as parameter.
    */

        public static void plusMinus(List<int> arr)
        {
            decimal positive = 0;
            decimal negative = 0;
            decimal zero = 0;
            int i = 0;
            while (i < arr.Count)
            {
                if (arr[i] == 0)
                    zero++;
                else if (arr[i] > 0)
                    positive++;
                else
                    negative++;

                i++;
            }

            decimal pos = positive / arr.Count;
            decimal neg = negative / arr.Count;
            decimal zer = zero / arr.Count;

            Console.WriteLine(pos.ToString("N6"));
            Console.WriteLine(neg.ToString("N6"));
            Console.WriteLine(zer.ToString("N6"));
        }

    }
}
