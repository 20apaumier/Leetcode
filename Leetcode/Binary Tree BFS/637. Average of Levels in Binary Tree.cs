using Leetcode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Binary_Tree_BFS
{
    public class BinaryTreeAverageLevels
    {
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> averages = new List<double>();
            if (root == null) { return averages; }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                int LengthOfLevel = q.Count;
                double LevelCount = 0.00;

                for (int i = 0; i < LengthOfLevel; i++)
                {
                    TreeNode node = q.Dequeue();
                    LevelCount += node.val;

                    if (i == LengthOfLevel - 1)
                    {
                        averages.Add(LevelCount / LengthOfLevel);
                    }

                    if (node.left != null) { q.Enqueue(node.left); }
                    if (node.right != null) { q.Enqueue(node.right); }
                }
            }

            return averages;
        }
    }
}
