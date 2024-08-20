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
            ListNode head = new ListNode(3);
            ListNode originalHead = head;

            // add values to head
            head.next = new ListNode(2);
            head = head.next;
            head.next = new ListNode(0);
            head = head.next;
            head.next = new ListNode(-4);
            head = head.next; 

            // Act
            bool result = LinkedCycle.HasCycle(originalHead);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void HasCycleTest2()
        {
            // Arrange
            ListNode head = new ListNode(1);
            ListNode originalHead = head;

            // add values to head
            head.next = new ListNode(2);

            // Act
            bool result = LinkedCycle.HasCycle(originalHead);
            bool expected = true;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void HasCycleTest3()
        {
            // Arrange
            ListNode head = new ListNode(1);

            // Act
            bool result = LinkedCycle.HasCycle(head);
            bool expected = false;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}