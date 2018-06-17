using System;
using System.Collections.Generic;
using System.Text;

namespace Breadth_FirstSearch
{
    public class TreeNode<T>
    {
        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public T Value { get; }

        public TreeNode(T value, TreeNode<T> left = null, TreeNode<T> right = null)
        {
            this.Left = left;
            this.Right = right;
            this.Value = value;
        }
    }
}
