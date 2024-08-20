using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.LinkedLists
{
    public class MergeSortedLinkedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Create a dummy node to start the merged list
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            // Traverse both lists
            while (list1 != null && list2 != null)
            {
                // compare values and add the smaller one
                // then increment the node which you added
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                // continue loop
                current = current.next;
            }

            // If one list is longer, append the rest
            if (list1 != null)
            {
                current.next = list1;
            }
            if (list2 != null)
            {
                current.next = list2;
            }

            // Return the merged list excluding the first dummy
            return dummy.next;
        }
    }
}
