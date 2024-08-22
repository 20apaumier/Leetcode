using Leetcode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests.BinarySearchTree.Tests
{
    public static class BinarySearchTreeHelper
    {
        public static TreeNode BuildSearchTree(List<int?> nodes)
        {
            if (nodes == null || nodes.Count == 0)
                return null;

            TreeNode root = null;
            foreach (var data in nodes)
            {
                if (data.HasValue)
                {
                    root = AddToSearchTree(root, new TreeNode(data.Value));
                }
            }
            return root;
        }

        public static TreeNode AddToSearchTree(TreeNode root, TreeNode node)
        {
            if (root == null)
                return node;

            if (node.val < root.val)
            {
                root.left = AddToSearchTree(root.left, node);
            }
            else
            {
                root.right = AddToSearchTree(root.right, node);
            }
            return root;
        }
    }
}
