using Leetcode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Binary_Tree_BFS
{
    public class BinaryTreeLevelOrderTraversal
    {
        public static List<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> output = new List<IList<int>>();
            if (root == null) { return output.ToList(); }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                int LengthOfLevel = q.Count;
                List<int> LevelList = new List<int>();

                for (int i = 0; i < LengthOfLevel; i++)
                {
                    TreeNode node = q.Dequeue();
                    LevelList.Add(node.val);

                    if (i == LengthOfLevel - 1) { output.Add(LevelList); }
                    if (node.left != null) { q.Enqueue(node.left); }
                    if (node.right != null) { q.Enqueue(node.right); }
                }
            }

            return output.ToList();
        }
    }
}
