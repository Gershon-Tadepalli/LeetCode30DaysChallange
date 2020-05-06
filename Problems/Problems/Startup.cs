using System;
using System.Diagnostics;

namespace Problems
{
    class Startup
    {
        static void Main(string[] args)
        {
            #region Day-1
            //2126753390
            //1702766719
            //Given n = 5, and version = 4 is the first bad version.
            Stopwatch watch = new Stopwatch();
            Day_1_FirstBadVersion day_1 = new Day_1_FirstBadVersion();
            day_1.firstBadVersion = 1702766719;
            watch.Start();
            int firstBadVersion =  day_1.FirstBadVersion(2126753390);
            watch.Stop();
            Console.WriteLine($"First Bad Version : {firstBadVersion} and time taken : {watch.ElapsedMilliseconds}");
            #endregion

            #region Day-2
            Day_2_JewelsAndStones day_2 = new Day_2_JewelsAndStones();
            string J = "z";
            string S = "ZZ";
            watch.Start();
            int numJewelsInStones = day_2.NumJewelsInStones(J, S);
            watch.Stop();
            Console.WriteLine($"Number of Jewels in Stones : {numJewelsInStones} in time : {watch.ElapsedMilliseconds}");
            #endregion

            #region Day-3
            Day_3_RansomNote day_3 = new Day_3_RansomNote();
            watch.Start();
            bool status = day_3.CanConstruct("aalkjzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp","aabowureoijlkcvlcvugzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
            watch.Stop();
            Console.WriteLine($"Ransom String can be constructed from the magazine : {status} and time taken: {watch.ElapsedMilliseconds}");
            #endregion

            #region Day-4
            Day_4_NumberCompliment day_4 = new Day_4_NumberCompliment();
            int input=10;
            watch.Start();
            int compliment = day_4.FindComplement(input);
            watch.Stop();
            Console.WriteLine($"Number Compliment of {input} is {compliment}");
            #endregion

            #region Day-5
            
            Day_5_UniqueCharacterInString day_5 = new Day_5_UniqueCharacterInString();
            string findUniqueCharacter = "slakjfdlskjfdlsk";
            watch.Start();
            int uniqueCharacter = day_5.FirstUniqChar(findUniqueCharacter);
            watch.Stop();
            Console.WriteLine($"First Unique Character in String is : {uniqueCharacter}");
            #endregion

            #region Day-6
            Day_6_MajorityElement day_6 = new Day_6_MajorityElement();
            int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2,1,1,1,1,1,1,1,1,1,1,5,5,5,5,5};
            watch.Start();
            int majorityElement = day_6.MajorityElement(nums);
            watch.Stop();
            Console.WriteLine($"Majority Element is {majorityElement} in time {watch.ElapsedMilliseconds}");
            #endregion
        }
    }
}
