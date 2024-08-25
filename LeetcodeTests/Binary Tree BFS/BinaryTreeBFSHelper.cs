using Leetcode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests.Binary_Tree_BFS
{
    public class BinaryTreeBFSHelper
    {
        public static TreeNode? BuildTree(List<int?> nodes)
        {
            int n = nodes.Count;
            if (n == 0) return null;
            Queue<TreeNode> parentQueue = new();
            TreeNode root = new(nodes[0] ?? throw new InvalidOperationException());
            TreeNode curParent = root;
            for (int i = 1; i < n; i++)
            {
                var node = nodes[i];
                if (i % 2 == 1)
                {
                    if (node != null)
                    {
                        curParent.left = new TreeNode(node.Value);
                        parentQueue.Enqueue(curParent.left);
                    }
                }
                else
                {
                    if (node != null)
                    {
                        curParent.right = new TreeNode(node.Value);
                        parentQueue.Enqueue(curParent.right);
                    }

                    curParent = parentQueue.Dequeue();
                }
            }
            return root;
        }
    }
}
