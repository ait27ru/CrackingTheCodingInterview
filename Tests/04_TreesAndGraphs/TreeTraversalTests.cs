namespace Solutions._04_TreesAndGraphs.Tests
{
    [TestClass()]
    public class TreeTraversalTests
    {
        [TestMethod()]
        public void InOrderTraversalTest()
        {
            // In-order traverse on a binary search tree visits the nodes in ascending order.

            // act
            var result = TreeTraversal.InOrderTraversal(TestData.binarySearchTree);

            // assert
            CollectionAssert.AreEqual(new List<int>() { 2, 4, 6, 8, 10, 20 }, result);
        }

        [TestMethod()]
        public void PreOrderTraversalTest()
        {
            // Pre-order traverse visits the root node first.

            // act
            var result = TreeTraversal.PreOrderTraversal(TestData.binarySearchTree);

            // assert
            CollectionAssert.AreEqual(new List<int>() { 8, 4, 2, 6, 10, 20 }, result);
        }

        [TestMethod()]
        public void PostOrderTraversalTest()
        {
            // Post-order traverse visits the root node last.

            // act
            var result = TreeTraversal.PostOrderTraversal(TestData.binarySearchTree);

            // assert
            CollectionAssert.AreEqual(new List<int>() { 2, 6, 4, 20, 10, 8 }, result);
        }

        private static class TestData
        {
            public static readonly TreeNode<int> binarySearchTree;

            static TestData()
            {
                /*
                 *             8
                 *           /   \  
                 *          4    10 
                 *         / \     \
                 *        2   6    20
                 */
                binarySearchTree = new TreeNode<int>(8);
                // Level 1
                binarySearchTree.Left = new TreeNode<int>(4);
                binarySearchTree.Right = new TreeNode<int>(10);
                // Level 2
                binarySearchTree.Left.Left = new TreeNode<int>(2);
                binarySearchTree.Left.Right = new TreeNode<int>(6);
                binarySearchTree.Right.Right = new TreeNode<int>(20);
            }
        }
    }
}