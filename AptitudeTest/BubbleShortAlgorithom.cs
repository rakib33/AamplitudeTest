﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTest
{
    /// <summary>
    /// Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in the wrong order. This algorithm is not suitable for large data sets as its average and worst-case time complexity is quite high.

    //    How does Bubble Sort Work?
    //    Input: arr[] = {5, 1, 4, 2, 8}

    //First Pass: 

    //Bubble sort starts with very first two elements, comparing them to check which one is greater.
    //( 5 1 4 2 8 ) –> (1 5 4 2 8 ), Here, algorithm compares the first two elements, and swaps since 5 > 1. 
    //( 1 5 4 2 8 ) –> (1 4 5 2 8 ), Swap since 5 > 4 
    //( 1 4 5 2 8 ) –> (1 4 2 5 8 ), Swap since 5 > 2 
    //( 1 4 2 5 8 ) –> (1 4 2 5 8 ), Now, since these elements are already in order (8 > 5), algorithm does not swap them.
    //Second Pass: 


    //Now, during second iteration it should look like this:
    //(1 4 2 5 8 ) –> (1 4 2 5 8 ) 
    //(1 4 2 5 8 ) –> (1 2 4 5 8 ), Swap since 4 > 2 
    //( 1 2 4 5 8 ) –> (1 2 4 5 8 ) 
    //(1 2 4 5 8 ) –> (1 2 4 5 8 ) 
    //Third Pass: 

    //Now, the array is already sorted, but our algorithm does not know if it is completed.
    //The algorithm needs one whole pass without any swap to know it is sorted.
    //( 1 2 4 5 8 ) –> (1 2 4 5 8 ) 
    //(1 2 4 5 8 ) –> (1 2 4 5 8 ) 
    //(1 2 4 5 8 ) –> (1 2 4 5 8 ) 
    //(1 2 4 5 8 ) –> (1 2 4 5 8 ) 
    /// </summary>
    public static class BubbleShortAlgorithom
    {
       
        public static void BubbleShort(ref int[] array) 
        {
          
            int arrLength = array.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                for (int j = 0; j < arrLength -i - 1; j++) // why arrLength - i -1
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;                      
                    }              
                }
            }
        }
    }
}
