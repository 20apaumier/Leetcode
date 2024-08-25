using Leetcode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearchTree
{
    public class ValidateBST
    {
        private int? prev = null;

        public bool IsValidBST(TreeNode root)
        {
            // in order traversal, keep prev and cur and check values
            return InOrder(root);
        }

        public bool InOrder(TreeNode node)
        {
            if (node == null) { return true; }

            if (InOrder(node.left) == false)
            {
                return false;
            }

            if (prev != null && node.val <= prev)
            {
                return false;
            }
            prev = node.val;

            return InOrder(node.right);
        }
    }
}
