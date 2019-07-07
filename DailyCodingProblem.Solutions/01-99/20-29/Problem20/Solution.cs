using System;
using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem20
{
    public class Solution
    {


        //Ref.: Uncompleted ....
        public static void Test()
        {
            var a = new ListNode(0) { Next = new ListNode(9) { Next = new ListNode(1) } };
            a.Next = new ListNode(2) { Next = new ListNode(4) };
            var b = new ListNode(3) { Next = new ListNode(2) { Next = new ListNode(4) } };

            var result = GetIntersectionNodeWithHash(a, b);

            Console.WriteLine(result);
        }

        //Approach 1: Brute Force (527ms)
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode pa = headA, pb;
            while (pa != null)
            {
                for (pb = headB; pb != null; pb = pb.Next)
                {
                    if (pa == pb)
                    {
                        return pa;
                    }
                }
                pa = pa.Next;
            }
            return null;
        }

        //Approach 2: Hash Table(10ms)

        public static ListNode GetIntersectionNodeWithHash(ListNode headA, ListNode headB)
        {
            var nodes = new HashSet<ListNode>();
            ListNode pa = headA;
            while (pa != null)
            {
                nodes.Add(pa);
                pa = pa.Next;
            }
            if (nodes.Count == 0)
            {
                return null;
            }
            ListNode pb = headB;
            while (pb != null)
            {
                if (nodes.Contains(pb))
                {
                    return pb;
                }
                pb = pb.Next;
            }
            return null;
        }

        public ListNode GetIntersectionNodeWithTwoPointer(ListNode headA, ListNode headB)
        {
            ListNode pa = headA, pb = headB;
            while (pa != pb)
            {
                pa = (pa != null) ? pa.Next : headB;
                pb = (pb != null) ? pb.Next : headA;
            }
            return pa;
        }
    }

    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int x)
        {
            Val = x;
        }
    }

}