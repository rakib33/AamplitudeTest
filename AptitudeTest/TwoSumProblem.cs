using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTest
{

    //https://leetcode.com/problems/two-sum/description/
    /*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.




Example 1:

Input: nums = [2, 7, 11, 15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3, 2, 4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3, 3], target = 6
Output: [0,1]
    */

    public class TwoSumProblem
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == nums[i] + nums[j])
                        return new int[2] { i, j };
                }
            }
            return new int[0];
        }

        public static int[] TwoSumEfficient(int[] nums, int target)
        {

            // Create a dictionary to store the complement and its index
            Dictionary<int, int> seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (seen.ContainsKey(complement))
                {
                    // If complement exists in the dictionary, return the indices
                    return new int[] { seen[complement], i };
                }
                // Otherwise, add the current element and its index to the dictionary
                seen[nums[i]] = i;
            }
            // If no solution is found, return an empty array
            return new int[0];
        }
    }
}
