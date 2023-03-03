using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTest
{
  public static class InsertionShortAlgorithm
    {
        /// <summary>
        /// Time Complexity Big 0 n square
        /// </summary>
        /// <param name="arr"></param>
        public static void InsertionShort(ref int[] arr) 
        {
            int length = arr.Length;
            int j = 0;
            for (int i = 0; i < length; i++)
            {
                j = i;
                while (j > 0) {
                    if (arr[j - 1] > arr[j]) {
                        //swap
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    j--;
                }
            }
        }
    }
}
