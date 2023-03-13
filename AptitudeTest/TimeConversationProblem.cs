using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTest
{
    public class TimeConversationProblem
    {
        public static string TimeConversion(string s)
        {
            int hour = 0;
            if (s.Contains("PM"))
            {
                s = s.Replace("PM", "");
                string[] arr = s.Split(':');
                hour = Convert.ToInt32(arr[0]);
                if (hour < 12)
                    hour = hour + 12;
                return hour.ToString().PadLeft(2,'0') + ":" + arr[1] + ":" + arr[2];
            }
            else
            {
                //AM
                s = s.Replace("AM", "");
                string[] arr = s.Split(':');
                hour = Convert.ToInt32(arr[0]);
                if (hour == 12)
                    hour = Math.Abs(hour - 12);
                return hour.ToString().PadLeft(2,'0') + ":" + arr[1] + ":" + arr[2];

            }
        }
    }
}
