using System;

namespace App
{
    static class MyTree
    {

        public static void Run()
        {
            var myTree = new BinaryTree();

            myTree.insert("15");
            myTree.insert("25");
            myTree.insert("10");
            myTree.insert("7");
            myTree.insert("22");
            myTree.insert("17");
            myTree.insert("13");
            myTree.insert("5");
            myTree.insert("9");
            myTree.insert("27");

            myTree.remove("15");

            var searchedNode = myTree.search(myTree.root, "13");

            var i = 5;
        }
    }


    class Node
    {
        public Node(string value)
        {
            this.value = value;
        }

        public string value { get; set; }

        public Node left { get; set; }
        public Node right { get; set; }

    }

    class BinaryTree
    {
        public Node root { get; set; }

        public void insert(string value)
        {
            var newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                insertNode(root, newNode);
            }
        }

        void insertNode(Node node, Node newNode)
        {

            // Where to put a new node? LEFT or RIGHT?

            var nodeValueInt = 0;
            var valueInt = 0;

            if (Int32.TryParse(node.value, out nodeValueInt) && Int32.TryParse(newNode.value, out valueInt))
            {

                // PUT into RIGHT
                if (valueInt > nodeValueInt)
                {
                    // is right node already exist ?
                    if (node.right == null)
                    {
                        node.right = newNode;
                    }
                    else
                    {
                        // go deeper
                        this.insertNode(node.right, newNode);
                    }
                }

                // PUT into LEFT
                if (valueInt < nodeValueInt)
                {
                    // is left node already exist ?
                    if (node.left == null)
                    {
                        node.left = newNode;
                    }
                    else
                    {
                        // go deeper
                        this.insertNode(node.left, newNode);
                    }
                }
            }
            else
            {
                System.Console.WriteLine("value should be convertable to Int32");
            }
        }

        public void remove(string value)
        {
            if (this.root != null)
            {
                this.root = this.removeNode(this.root, value);
            }
        }

        Node removeNode(Node node, string value)
        {

            var nodeValueInt = 0;
            var valueInt = 0;

            if (Int32.TryParse(node.value, out nodeValueInt) && Int32.TryParse(value, out valueInt))
            {

                if (valueInt > nodeValueInt)
                {
                    node.right = removeNode(node.right, value);
                    return node;
                }
                else if (valueInt < nodeValueInt)
                {
                    node.left = removeNode(node.left, value);
                    return node;
                }
                else
                {
                    // if node has no children
                    if (node.left == null && node.right == null)
                    {
                        return null;
                    }

                    // if node has one child
                    if (node.left != null && node.right == null)
                    {
                        node = node.left;
                        return node;
                    }

                    if (node.left != null && node.right == null)
                    {
                        node = node.right;
                        return node;
                    }

                    // if node has both children
                    if (node.left != null && node.right != null)
                    {

                        var minValue = findMinNode(node.right);
                        node.value = minValue;

                        node.right = removeNode(node.right, minValue);
                        return node;
                    }

                    // should never happened
                    return node;
                }

            }
            else
            {
                return null;
            }
        }

        string findMinNode(Node node)
        {
            if (node.left != null)
            {
                return findMinNode(node.left);
            }
            else
            {
                return node.value;
            }

        }

        public Node search(Node node, string value)
        {
            var nodeValueInt = 0;
            var valueInt = 0;

            if (Int32.TryParse(node.value, out nodeValueInt) && Int32.TryParse(value, out valueInt))
            {

                if (nodeValueInt == valueInt)
                {
                    return node;
                }
                else if (valueInt > nodeValueInt)
                {
                    return search(node.right, value);
                }
                else if (valueInt < nodeValueInt)
                {
                    return search(node.left, value);
                }


            }

            // should never happened
            return null;
        }

    }
}