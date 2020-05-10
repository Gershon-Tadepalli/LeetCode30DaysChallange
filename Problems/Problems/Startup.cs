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
            int firstBadVersion = day_1.FirstBadVersion(2126753390);
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
            bool status = day_3.CanConstruct("aalkjzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp", "aabowureoijlkcvlcvugzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
            watch.Stop();
            Console.WriteLine($"Ransom String can be constructed from the magazine : {status} and time taken: {watch.ElapsedMilliseconds}");
            #endregion

            #region Day-4
            Day_4_NumberCompliment day_4 = new Day_4_NumberCompliment();
            int input = 10;
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
            int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 5, 5, 5, 5 };
            watch.Start();
            int majorityElement = day_6.MajorityElement(nums);
            watch.Stop();
            Console.WriteLine($"Majority Element is {majorityElement} in time {watch.ElapsedMilliseconds}");
            #endregion

            #region Day-7
            Day_7_CousinsInBinaryTree tree = new Day_7_CousinsInBinaryTree();
            tree.root = new TreeNode(1);
            tree.root.left = new TreeNode(2);
            tree.root.right = new TreeNode(3);
            tree.root.left.left = new TreeNode(4);
            tree.root.left.right = new TreeNode(5);
            tree.root.left.right.right = new TreeNode(15);
            tree.root.right.left = new TreeNode(6);
            tree.root.right.right = new TreeNode(7);
            tree.root.right.left.right = new TreeNode(8);

            TreeNode Node1, Node2;
            Node1 = tree.root.left.left;
            Node2 = tree.root.right.right;
            watch.Start();
            if (tree.IsCousins(tree.root, Node1.data, Node2.data))
                Console.WriteLine($"Status : Yes");
            else
                Console.WriteLine("No");
            watch.Stop();
            Console.WriteLine($"Executed Binary Tree process in {watch.ElapsedMilliseconds}");
            #endregion

            #region Day-8
            Day_8_CheckIfAStraightLine day_8 = new Day_8_CheckIfAStraightLine();
            int[][] coordinates = new int[][] { new int[]{ 1, 2 },new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 }, new int[] { 5, 6 }, new int[] { 6, 7 } };
            bool chkStline = day_8.CheckStraightLine(coordinates);
            Console.WriteLine($"Given coordinates form a straight line ? {chkStline}");
            #endregion

            #region Day-9
            Day_9_ValidPerfectSquare day_9 = new Day_9_ValidPerfectSquare();
            int chkPerfectSquare = Int32.MaxValue;
            bool isPerfectSquare = day_9.IsPerfectSquare(chkPerfectSquare);
            Console.WriteLine($"Given number {chkPerfectSquare} is perfect square : {isPerfectSquare }");
            #endregion

            #region Day-10
            Day_10_FindTownJudge day_10 = new Day_10_FindTownJudge();
            int[][] trusts = new int[][] { new int[] { 1, 3 }, new int[] { 1, 4 }, new int[] { 2, 3 }, new int[] { 2, 4 },
            new int[] { 4, 3 }};
            int judge = day_10.FindJudge_Optimized(4, trusts);
            Console.WriteLine($"Judge is :{judge} Person");
            #endregion
        }
    }
}
