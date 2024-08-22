using Leetcode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearchTree
{
    public class SearchTree
    {
        // init an int to store the current minimum difference
        // and the prev node that we traversed through
        private int minDiff = int.MaxValue;
        private TreeNode prev = null;

        public int GetMinimumDifference(TreeNode root)
        {
            InOrderTraversal(root);
            return minDiff;
        }

        private void InOrderTraversal(TreeNode node)
        {
            if (node == null) { return; }
            InOrderTraversal(node.left);

            // check if we have a prev Node,
            // update the min diff by calculating the current one
            // and comparing to the old minDiff
            if (prev != null)
            {
                minDiff = Math.Min(minDiff, Math.Abs(node.val - prev.val));
            }
            prev = node;

            InOrderTraversal(node.right);
        }
    }
}
