using System;
using System.Diagnostics;

namespace Problems
{
    class Startup
    {
        static void Main(string[] args)
        {
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
        }
    }
}
