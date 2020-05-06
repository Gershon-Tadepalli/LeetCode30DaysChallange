using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    class CountIndex
    {
        public int index, count;
        public CountIndex(int index)
        {
            this.count = 1;
            this.index = index;
        }

        public void incCount()
        {
            this.count++;
        }
    }
    class Day_5_UniqueCharacterInString
    {
        Dictionary<char, CountIndex> hm = new Dictionary<char, CountIndex>(256);
        public int FirstUniqChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                //contains
                if (!hm.ContainsKey(s[i]))
                    hm[s[i]] = new CountIndex(i);
                else
                    hm[s[i]].incCount();                
            }
            int result = int.MaxValue;
            for (int i = 0; i < s.Length; i++)
            {
                //find count is 1 and index
                if (hm[s[i]].count == 1 && result > hm[s[i]].index)
                    result = hm[s[i]].index;

            }
            return result==int.MaxValue?-1:result;
        }
    }
}
