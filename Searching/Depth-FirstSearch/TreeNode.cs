using System;
using System.Collections.Generic;
using System.Text;

namespace Depth_FirstSearch
{
    public class TreeNode<T>
    {
        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public T Value { get; }

        public TreeNode(T value, TreeNode<T> leftChild = null, TreeNode<T> rightChild = null)
        {
            this.Value = value;
            this.Left = leftChild;
            this.Right = rightChild;
        }
    }
}
