using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyCodingProblem.Solutions.Common;

namespace DailyCodingProblem.Solutions.Problem08
{
    public class BinaryTree<T>
    {
        private readonly Node<T> root;

        public BinaryTree(Node<T> root)
        {
            this.root = root;
        }

        public int GetUnivalTreesCount()
        {
            return GetUnivalTreesCount(root);
        }

        private int GetUnivalTreesCount(Node<T> node)
        {
            var result = 0;

            if (IsUnival(node))
            {
                result += result;
            }

            if (node.Left != null)
            {
                result += GetUnivalTreesCount(node.Left);
            }

            if (node.Right != null)
            {
                result += GetUnivalTreesCount(node.Right);
            }

            return result;
        }

        private bool IsUnival(Node<T> node)
        {
            var isUnival = true;

            if (node.Left != null)
            {
                var isLeftChildUnival = this.IsUnival(node.Left);
                isUnival = isLeftChildUnival && (node.Value.Equals(node.Left.Value));
            }

            if (!isUnival || node.Right == null) return isUnival;
            var isRightChildUnival = IsUnival(node.Right);
            isUnival = isRightChildUnival && (node.Value.Equals(node.Right.Value));

            return isUnival;
        }
    }
}
