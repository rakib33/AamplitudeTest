using System;
using System.Collections.Generic;
using System.Text;

namespace AptitudeTest
{
 public  class BankLaserBeams
    {
        //2125. Number of Laser Beams in a Bank
        //https://leetcode.com/problems/number-of-laser-beams-in-a-bank/description/
        public static int NumberOfBeams(string[] bank)
        {
            int BeamNo = 0;
            int FromBeam = 0;
            int ToBeam = 0;
       
            for (int i = 0; i < bank.Length; i++)
            {
                string bankItem = bank[i];
                ToBeam = 0;
                for (int j = 0; j < bankItem.Length; j++) {
                    if (bankItem[j].ToString() == "1")
                        ToBeam++;
                }

                if (FromBeam == 0)
                {
                    FromBeam = ToBeam;                  
                }
                else
                {
                    BeamNo += FromBeam * ToBeam;
                    FromBeam = ToBeam != 0 ? ToBeam : FromBeam;
                }
            }
            return BeamNo;
        }
    }
}
