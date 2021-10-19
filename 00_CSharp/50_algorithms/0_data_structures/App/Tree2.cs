
// C# program to construct binary tree from 
// given array in level order fashion 
using System;


static class MyTree2
{
    public static void Run()
    {
        Tree t2 = new Tree();
        int[] arr = { 3, 4, 5, 1, 2 };
        t2.root = t2.insertLevelOrder(arr, t2.root, 0);
        t2.inOrder(t2.root);
    }
}

public class Tree
{
    public Node root;

    // Tree Node 
    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

    // Function to insert nodes in level order 
    public Node insertLevelOrder(int[] arr,
                            Node root, int i)
    {
        // Base case for recursion 
        if (i < arr.Length)
        {
            Node temp = new Node(arr[i]);
            root = temp;

            // insert left child 
            root.left = insertLevelOrder(arr,
                            root.left, 2 * i + 1);

            // insert right child 
            root.right = insertLevelOrder(arr,
                            root.right, 2 * i + 2);
        }
        return root;
    }

    // Function to print tree 
    // nodes in InOrder fashion 
    public void inOrder(Node root)
    {
        if (root != null)
        {
            inOrder(root.left);
            Console.Write(root.data + " ");
            inOrder(root.right);
        }
    }

}