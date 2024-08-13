using Leetcode;

namespace LeetcodeTests
{
    [TestClass]
    public class MergeSortedArraysTests
    {
        [TestMethod]
        public void TestMergeSorted()
        {
            // Arrange
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3;
            int[] nums2 = [2, 5, 6];
            int n = 3;
            int[] expected = [1, 2, 2, 3, 5, 6];

            // Act
            MergeSortedArrays.Merge(nums1, m, nums2, n);
            int[] actual = nums1;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMergeSorted2()
        {
            // Arrange
            int[] nums1 = [1];
            int m = 1;
            int[] nums2 = [];
            int n = 0;
            int[] expected = [1];

            // Act
            MergeSortedArrays.Merge(nums1, m, nums2, n);
            int[] actual = nums1;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMergeSorted3()
        {
            // Arrange
            int[] nums1 = [0];
            int m = 0;
            int[] nums2 = [1];
            int n = 1;
            int[] expected = [1];

            // Act
            MergeSortedArrays.Merge(nums1, m, nums2, n);
            int[] actual = nums1;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}