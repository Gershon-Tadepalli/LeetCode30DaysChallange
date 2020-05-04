using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Day_4_NumberCompliment
    {
        string s = "";
        public int FindComplement(int num)
        {
            //Convert num to binary
            s = Convert.ToString(num, 2);
            //flip the binary
            s = string.Concat(s.Select(c => c == '0' ? '1' : '0'));
            
            //Convert binary to num
            return Convert.ToInt32(s, 2);
        }
    }
}
