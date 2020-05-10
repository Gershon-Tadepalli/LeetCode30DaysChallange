using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    class Day_10_FindTownJudge
    {
        public int FindJudge(int N, int[][] arr)
        {
            //(1,3) (2,3) --> 3
            int[] trust = new int[N];
            int[] trusted = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                int a = arr[i][0];
                int b = arr[i][1];
                trust[a - 1]++;
                trusted[b - 1]++;
            }
            for (int i = 0; i < N; i++)
            {
                if (trust[i] == 0 && trusted[i] == N - 1) return i + 1;
            }
            return -1;
        }

        public int FindJudge_Optimized(int N, int[][] arr)
        {
            //(1,3) (2,3) --> 3
            int[] trusted = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                int a = arr[i][0];
                int b = arr[i][1];
                trusted[a - 1]--;
                trusted[b - 1]++;
            }
            for (int i = 0; i < N; i++)
            {
                if (trusted[i] == N - 1) return i + 1;
            }
            return -1;
        }
    }
}
