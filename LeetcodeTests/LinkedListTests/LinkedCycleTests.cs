using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.LinkedLists;

namespace LeetcodeTests.LinkedListTests
{
    [TestClass()]
    public class LinkedCycleTests
    {
        [TestMethod()]
        public void HasCycleTest()
        {
            // Arrange
            var node1 = new ListNode(3);
            var node2 = new ListNode(2);
            node1.next = node2;
            node2.next = new ListNode(0);
            node2.next.next = new ListNode(-4);
            node2.next.next.next = node2;

            // Act
            bool expected = true;
            bool actual = LinkedCycle.HasCycle(node1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void HasCycleTest2()
        {
            // Arrange
            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            node1.next = node2;
            node2.next = node1;

            // Act
            bool expected = true;
            bool actual = LinkedCycle.HasCycle(node1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void HasCycleTest3()
        {
            // Arrange
            var node1 = new ListNode(1);

            // Act
            bool expected = false;
            bool actual = LinkedCycle.HasCycle(node1);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}