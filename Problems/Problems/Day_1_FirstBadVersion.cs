using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Problems
{
    class Day_1_FirstBadVersion
    {
        public int firstBadVersion { get; set; }
        //There are N versions available need to find out which is the first bad version
        //Ex : n = 5 and version 4 is the first bad version
        // You should minimize the number of calls to the IsBadVersion API.
        public int FirstBadVersion(int n)
        {
            int left=1, right=n, mid;
            while (left < right)
            {
                //Handling overflow condition for bigger numbers which crossed max of int
                mid = left + (right-left) / 2;
                if(IsBadVersion(mid))
                {
                    //move left
                    right = mid;
                }
                else
                {
                    //move right
                    left = mid + 1;
                }
            }
            return left;
        }

        private bool IsBadVersion(int version)
        {
            if(version >= firstBadVersion)
              return true;
            return false;
        }
    }
}
