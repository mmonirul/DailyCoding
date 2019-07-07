using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyCodingProblem.Solutions.Problem23
{
    // Solution help https://galaiko.rocks/posts/dcp/maze/
    // https://en.wikipedia.org/wiki/Lee_algorithm
    // https://www.geeksforgeeks.org/shortest-path-in-a-binary-maze/
    public class Solution
    {
        public static void Test()
        {
            Console.WriteLine("In progress.. ");


        }
    }

    //public class BinaryTreeWithLock
    //{
    //    public class BinaryTreeNode
    //    {
    //        int val;
    //        bool locked = false;
    //        BinaryTreeNode parent;
    //        BinaryTreeNode leftChild;
    //        BinaryTreeNode rightChild;
    //        int lockedDescendantCount = 0;
    //    }

    //    public bool is_locked(BinaryTreeNode node)
    //    {
    //        return node.locked;
    //    }
    //    public bool lock(BinaryTreeNode node) {
    //        if(is_locked(node)) {
    //            return true;
    //        }
    //        if(!canLockOrUnlock(node)) {
    //            return false;
    //        }
    //        node.locked = true;
    //        BinaryTreeNode parentNode = node.parent;
    //        while(parentNode != null) {
    //            parentNode.lockedDescendantCount += 1;
    //            parentNode = parentNode.parent;
    //        }        
    //        return true;
    //    }
    //    public boolean unlock(BinaryTreeNode node)
    //    {
    //        if (!is_locked(node))
    //        {
    //            return true;
    //        }
    //        if (!canLockOrUnlock(node))
    //        {
    //            return false;
    //        }
    //        node.locked = false;
    //        BinaryTreeNode parentNode = node.parent;
    //        while (parentNode != null)
    //        {
    //            parentNode.lockedDescendantCount -= 1;
    //            parentNode = parentNode.parent;
    //        }
    //        return true;
    //    }
    //    private boolean canLockOrUnlock(BinaryTreeNode node)
    //    {
    //        if (node.lockedDescendantCount > 0)
    //        {
    //            return false;
    //        }
    //        BinaryTreeNode parentNode = node.parent;
    //        while (parentNode != null)
    //        {
    //            if (parentNode.locked)
    //            {
    //                return false;
    //            }
    //            parentNode = parentNode.parent;
    //        }
    //        return true;
    //    }
    //}


}