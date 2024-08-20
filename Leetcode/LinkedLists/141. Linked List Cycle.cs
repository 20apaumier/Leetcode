using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.LinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class LinkedCycle
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }

            ListNode tortoise = head;
            ListNode hare = head.next;

            while (hare != null && hare.next != null)
            {
                if (tortoise == hare)
                {
                    return true;
                }

                hare = hare.next.next;
                tortoise = tortoise.next;
            }

            return false;
        }
    }
}
