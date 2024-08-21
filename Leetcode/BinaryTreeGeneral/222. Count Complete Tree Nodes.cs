using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinaryTreeGeneral
{
    public class CountCompletes
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;

            return 1 + CountNodes(root.left) + CountNodes(root.right);
        }

        public int CountNodesAlgo(TreeNode root)
        {
            if (root == null) return 0;

            int leftDepth = GetLeftDepth(root);
            int rightDepth = GetRightDepth(root);

            if (leftDepth == rightDepth)
            {
                // is perfect binary tree
                return (1 << leftDepth) + CountNodesAlgo(root.right);
            } else
            {
                // is not perfect binary tree, there are nodes left over
                return (1 << rightDepth) + CountNodesAlgo(root.left);
            }

        }

        public int GetLeftDepth(TreeNode node)
        {
            int height = 0;
            while (node != null)
            {
                height += 1;
                node = node.left;
            }
            return height;
        }

        public int GetRightDepth(TreeNode node)
        {
            int height = 0;
            while (node != null)
            {
                height += 1;
                node = node.right;
            }
            return height;
        }
    }
}
