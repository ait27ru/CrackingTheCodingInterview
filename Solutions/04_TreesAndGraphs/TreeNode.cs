﻿namespace Solutions._04_TreesAndGraphs
{
    public class TreeNode<T>(T value)
    {
        public T Value { get; set; } = value;
        public TreeNode<T>? Left { get; set; }
        public TreeNode<T>? Right { get; set; }
    }
}
