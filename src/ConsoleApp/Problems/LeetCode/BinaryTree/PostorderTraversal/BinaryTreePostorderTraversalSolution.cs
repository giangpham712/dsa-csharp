﻿using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.PostorderTraversal;

/*
 * Recursive solution
 
 */
public class BinaryTreePostorderTraversalSolution
{
    public IList<int> Solve(TreeNode? root)
    {
        var traversal = new List<int>();

        if (root == null)
        {
            return traversal;
        }

        Traverse(root, traversal);
        
        return traversal;
    }

    public void Traverse(TreeNode node, List<int> traversal)
    {
        if (node.left != null)
        {
            Traverse(node.left, traversal);
        }
        
        if (node.right != null)
        {
            Traverse(node.right, traversal);
        }
        
        traversal.Add(node.val);
    }
}