using System;
using System.Collections.Generic;
using System.Text;

namespace Breadth_FirstSearch
{
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(TreeNode<T> node)
        {
            this.root = node;
        }

        public bool BFS(T value)
        {
            var queue = new Queue<TreeNode<T>>();

            TreeNode<T> current;

            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                current = queue.Dequeue();

                if(current != null)
                {
                    if (current.Value.Equals(value))
                        return true;

                    else
                    {
                        queue.Enqueue(current.Left);
                        queue.Enqueue(current.Right);
                    }
                }
            }
            return false;
        }
    }
}
