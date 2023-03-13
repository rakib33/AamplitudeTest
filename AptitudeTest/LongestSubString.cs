using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTest
{
  public  class LongestSubString
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int start = 0;
            int end = 0;
            int maxLength = 0;
            HashSet<char> list = new HashSet<char>();
            while (end < s.Length) {
                char c = s[end];
                if (list.Contains(c))
                {
                    list.Remove(s[start]);
                    start++;
                }
                else { 
                   list.Add(c);
                   end++;
                   maxLength = Math.Max(maxLength, end-start);
                }
            }
            return maxLength;
        }
    }

}

