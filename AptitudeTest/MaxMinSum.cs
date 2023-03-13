using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTest
{
    public class MaxMinSumProblem
    {
        public static void miniMaxSum(List<int> arr)
        {
            int min = 0;
            int max = 0;
            int temp = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                temp = 0;
                for (int j = 0; j < arr.Count; j++)
                {

                    if (j != i)
                    {
                        temp += arr[j];
                    }
                }
                if(max ==0)
                    max = min = temp;
               else if (temp > max)               
                    max = temp;               
               else if (temp < min)
                    min = temp;

            }
            
            Console.WriteLine(min + " " + max);
        }

        public List<int> sum() { 
         return new List<int> { 10,12};
        }
    }
}
