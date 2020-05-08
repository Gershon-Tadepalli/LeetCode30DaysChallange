using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    class Day_8_CheckIfAStraightLine
    {
        public float CalSlope(int[] p1,int[] p2)
        {
            if (p1[0] - p2[0] == 0) return 0;
            return (float)(p2[1] - p1[1]) / (p2[0] - p1[0]);
        }
        public bool CheckStraightLine(int[][] coordinates)
        {
            //calculate slope for 1st two points
            float gradient = CalSlope(coordinates[0], coordinates[1]);
            //and check with all other points if they have same slope or not
            for (int i = 1; i < coordinates.Length; i++)
            {
                float slope= CalSlope(coordinates[i], coordinates[0]);
                if (gradient != slope)
                    return false;
            }
            return true;
        }
    }
}
