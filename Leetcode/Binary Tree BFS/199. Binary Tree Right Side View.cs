using Leetcode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Binary_Tree_BFS
{
    public class RightSide
    {
        public static IList<int> RightSideView(TreeNode root)
        {
            // init the output list, if root is null return empty list
            List<int> output = new List<int>();
            if (root == null) { return output; }

            // init queue of Nodes and add the root
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            // start bfs
            while (q.Count != 0)
            {
                // the count of the queue will be the length of the current level
                int LevelLength = q.Count;

                // go through each node at the current level by dequeuing up to the length
                for (int i = 0; i < LevelLength; i++)
                {
                    TreeNode node = q.Dequeue();

                    // if we are at the end of the level, we are at the right hand side!!
                    if (i == LevelLength - 1)
                    {
                        // add the node's value to the output
                        output.Add(node.val);
                    }

                    // enqueue children to the queue
                    if (node.left != null) { q.Enqueue(node.left); }
                    if (node.right != null) { q.Enqueue(node.right); }
                }
            }

            return output;
        }
    }
}
