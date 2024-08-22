using Leetcode.BinaryTreeGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests.BinarySearchTree.Tests
{
    public static class BinarySearchTreeHelper
    {
        public static TreeNode BuildSearchTree(int[] nums)
        {
            // find the middle element of the array. this is the root
            // and will ensure that the tree will be balanced
            // create a new TreeNode with the middle as its value
            // recursively construct the left subtree using the left half of the array
            // recursively construct the right subtree using the right half of the array
            // return the root node


            if (nums == null || nums.Length == 0)
                return null;

            return BuildSearchTreeHelper(nums, 0, nums.Length - 1);
        }

        public static TreeNode BuildSearchTreeHelper(int[] nums, int left, int right)
        {
            if (left > right) { return null; }

            // find middle
            int mid = left + (right - left) / 2;

            // create a tree node
            TreeNode root = new TreeNode(nums[mid]);

            // recusively construct left subtree
            root.left = BuildSearchTreeHelper(nums, left, mid - 1);

            // recursively construct right subtree
            root.right = BuildSearchTreeHelper(nums, mid + 1, right);


            return root;
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length <= 0)
            {
                return null;
            }

            int mid = nums.Length / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = SortedArrayToBST(nums[..mid]);
            node.right = SortedArrayToBST(nums[mid..]);
            return node;
        }
    }
}
