using Leetcode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearchTree
{
    public class KthSmallestElement
    {
        int count = 0;
        int result = 0;

        public int KthSmallest(TreeNode root, int k)
        {
            // in order traversal, keep a count, if reach k, return cur node val
            InOrderTrav(root, k);
            return result;
        }

        public void InOrderTrav(TreeNode node, int k)
        {
            if (node == null) { return; }

            InOrderTrav(node.left, k);
            count++;
            if (count == k)
            {
                result = node.val;
                return;
            }
            InOrderTrav(node.right, k);
        }
    }
}
