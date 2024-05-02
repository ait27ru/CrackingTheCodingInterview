namespace Solutions._04_TreesAndGraphs
{
    public class TreeTraversal
    {
        public static List<T> InOrderTraversal<T>(TreeNode<T> root)
        {
            var list = new List<T>();
            TraverseInOrder(root, list.Add);
            return list;
        }

        public static List<T> PreOrderTraversal<T>(TreeNode<T> root)
        {
            var list = new List<T>();
            TraversePreOrder(root, list.Add);
            return list;
        }
        public static List<T> PostOrderTraversal<T>(TreeNode<T> root)
        {
            var list = new List<T>();
            TraversePostOrder(root, list.Add);
            return list;
        }

        private static void TraverseInOrder<T>(TreeNode<T>? node, Action<T> visit)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, visit);
                visit(node.Value);
                TraverseInOrder(node.Right, visit);
            }
        }

        private static void TraversePreOrder<T>(TreeNode<T>? node, Action<T> visit)
        {
            if (node != null)
            {
                visit(node.Value);
                TraversePreOrder(node.Left, visit);
                TraversePreOrder(node.Right, visit);
            }
        }
        private static void TraversePostOrder<T>(TreeNode<T>? node, Action<T> visit)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, visit);
                TraversePostOrder(node.Right, visit);
                visit(node.Value);
            }
        }
    }
}
