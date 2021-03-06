﻿using System;

namespace Breadth_FirstSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tree =
            new Tree<int>(new TreeNode<int>(7,
                new TreeNode<int>(19,
                    new TreeNode<int>(1),
                    new TreeNode<int>(12)),
                    new TreeNode<int>(31,
                new TreeNode<int>(21),
                new TreeNode<int>(14,
                    new TreeNode<int>(23),
                    new TreeNode<int>(6)))));

            tree.BFS(6);
        }
    }
}
