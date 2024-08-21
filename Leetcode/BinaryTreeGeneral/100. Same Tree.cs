using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinaryTreeGeneral
{
    public class SameTree
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            // only p or q can be different, because if they
            //if (p == null ^ q == null) { return false; } // xor, make sure only one is null
            if (p == null && q != null) { return false; }
            if (q == null && p != null) { return false; }

            if (p == null && q == null) { return true; }
            if (p.val != q.val) { return false; }

            return (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
        }
    }
}
