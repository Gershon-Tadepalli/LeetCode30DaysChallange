using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    class TreeNode
    {
        public int data;
        public TreeNode left, right;
        public TreeNode(int item)
        {
            data = item;
            left = right = null;
        }
    }
    class Day_7_CousinsInBinaryTree
    {
        public TreeNode root;
        public bool isSibling(TreeNode node,int a,int b)
        {
            if (node == null)
                return false;

            return ((node.left?.data == a && node.right?.data == b) ||
                (node.left?.data == b && node.right?.data == a) ||
                isSibling(node.left, a, b) ||
                isSibling(node.right, a, b));
        }
        public int level(TreeNode node,int ptr,int lev)
        {
            //base case
            if (node == null)
                return 0;
            if (node.data == ptr)
                return lev;
            //check in left tree first
            int l = level(node.left, ptr, lev + 1);
            if(l!=0)
              return l;
            //then right tree
            return level(node.right, ptr, lev + 1);
        }
        public bool IsCousins(TreeNode root, int x, int y)
        {
            //1. check if both x & y are at same level
            //2. check if they are not siblings
            return (level(root, x, 1) == level(root, y, 1) && !isSibling(root, x, y));
            
        }
    }
}
