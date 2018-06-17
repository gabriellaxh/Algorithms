using System;
using System.Collections.Generic;
using System.Text;

namespace Depth_FirstSearch
{
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(TreeNode<T> node)
        {
            this.root = node;
        }

        public bool DFS(T value)
        {
            var stack = new Stack<TreeNode<T>>();

            TreeNode<T> current;

            stack.Push(root);

            while (stack.Count != 0)
            {
                current = stack.Pop();

                if (current != null)
                {
                    if (current.Value.Equals(value))
                        return true;

                    else
                    {
                        stack.Push(current.Right);
                        stack.Push(current.Left);
                    }
                }
            }
            return false;
        }
    }
}
