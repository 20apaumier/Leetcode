using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leetcode.BinaryTreeGeneral
{
    public class Path
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            // base case
            if (root == null) { return false; }

            // If it's a leaf node, check if its value equals the remaining sum
            if (root.left == null && root.right == null)
            {
                if (root.val == targetSum) { return true; }
            }

            // recursively check left and right subtrees
            // subtract the current node's value from target sum to maintain a 'curSum'
            return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
        }
    }
}
