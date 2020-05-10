using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    class Day_9_ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            try
            {
                //binary search
                long left = 1, right = (long)Int32.MaxValue;
                long mid;
                long square;
                while(left<=right)
                {
                    mid = left + (right - left) / 2;
                    square = mid * mid;
                    if (square < num)
                        left = mid + 1;
                    else if (square > num)
                        right = mid - 1;
                    else
                        return true;
                }
            }
                       
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
