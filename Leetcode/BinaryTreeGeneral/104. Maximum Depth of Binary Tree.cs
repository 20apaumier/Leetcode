using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinaryTreeGeneral
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class FindDepth
    {
        public static int MaxDepth(TreeNode root)
        {
            // base case, if the root is null, the depth is 0
            if (root == null)
            {
                return 0;
            }

            // recursively call left and right subtrees
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            // return max of left and right plus 1 for the head node
            return Math.Max(leftDepth, rightDepth) + 1;
        }


        public static int MaxDepthIterative(TreeNode root)
        {
            // edge case
            if (root == null)
            {
                return 0;
            }

            // use stack to kinda store the traversal
            Stack<(TreeNode node, int depth)> stack = new Stack<(TreeNode node, int depth)>();

            // push root node and init maxDepth
            stack.Push((root, 1));
            int maxDepth = 0;

            // continue as long as stack has a value
            while (stack.Count > 0)
            {
                // pop off the node and update the maxDepth
                var (node, depth) = stack.Pop();
                maxDepth = Math.Max(maxDepth, depth);

                // keep going down the right side if not null
                if (node.right != null)
                {
                    stack.Push((node.right, depth + 1));
                }
                // keep going down the left side if not null
                if (node.left != null)
                {
                    stack.Push((node.left, depth + 1));
                }
            }

            return maxDepth;
        }
    }
}
