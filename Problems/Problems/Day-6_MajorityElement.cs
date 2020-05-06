using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Day_6_MajorityElement
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        public int MajorityElement(int[] nums)
        {
            foreach (var num in nums)
            {
                if (frequency.ContainsKey(num))
                    //increment
                    frequency[num]++;
                else
                    frequency.Add(num, 1);
            }
            //var myList = frequency.ToList();
            //myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            //loop thru frequency dict
            foreach (var item in frequency)
            {
                //search for item with value > nums/2
                if (item.Value > nums.Length / 2)
                    return item.Key;
            }
            return -1;
        }
    }
}
