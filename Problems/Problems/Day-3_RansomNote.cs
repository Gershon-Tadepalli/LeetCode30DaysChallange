using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    class Day_3_RansomNote
    {
        //Not Optimal Solution as new string is created everytime(Memory Usage is more)
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int index;
            //check if each character in ransomNote is present in magazine?
            foreach (char c in ransomNote)
            {
                index = magazine.IndexOf(c);
                if (index!=-1)
                //yes
                //Remove character from magazine & Proceed furthur
                   magazine = magazine.Remove(index, 1);
                else
                    //No, break out of loop
                    return false;
            }
            return true;
        }
    }
}
