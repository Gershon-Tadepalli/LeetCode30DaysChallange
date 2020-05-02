using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    class Day_2_JewelsAndStones
    {
        //J - Jewels, S - stones
        //In S,You want to know how many of the stones you have are also jewels?
        //Input: J = "aA", S = "aAAbbbb"
        //Output: 3
        public int NumJewelsInStones(string J, string S)
        {
            //Find each stone in S if it is Jewel or not by searching in J
            int count = 0;
            foreach (char c in S)
            {
                if (J.IndexOf(c) != -1)
                    count++;
            }
            return count;
        }
    }
}
