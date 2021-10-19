using System;

namespace App
{
    class Program
    {
        // A binary tree node has data, pointer to  
        //left child && a pointer to right child / 
        public class Node
        {
            public int data;
            public Node left, right;
        };

        // Returns true if given tree is BST.  
        static Boolean isBST(Node root, Node l, Node r)
        {
            // Base condition  
            if (root == null)
                return true;

            // if left node exist then check it has  
            // correct data or not i.e. left node's data  
            // should be less than root's data  
            if (l != null && root.data <= l.data)
                return false;

            // if right node exist then check it has  
            // correct data or not i.e. right node's data  
            // should be greater than root's data  
            if (r != null && root.data >= r.data)
                return false;

            // check recursively for every node.  
            return isBST(root.left, l, root) &&
                isBST(root.right, root, r);
        }

        // Helper function that allocates a new node with the  
        //given data && null left && right pointers. / 
        static Node newNode(int data)
        {
            Node node = new Node();
            node.data = data;
            node.left = node.right = null;
            return (node);
        }

        // Driver code 
        public static void Main(String[] args)
        {

            Node root = newNode(4);
            root.left = newNode(2);
            root.right = newNode(5);
            root.left.left = newNode(1);
            root.left.right = newNode(3);

            if (isBST(root, null, null))
                Console.Write("Is BST");
            else
                Console.Write("Not a BST");
        }


    }
}
