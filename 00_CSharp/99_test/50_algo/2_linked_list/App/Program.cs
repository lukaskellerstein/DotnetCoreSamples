using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLL = new MyLinkedList();

            myLL.Add("AAA");
            myLL.Add("BBB");
            myLL.Add("CCC");
            myLL.Add("DDD");

            var i = 5;
        }
    }


    class Node
    {
        public string value { get; set; }
        public Node next { get; set; }

        public Node(string value)
        {
            this.value = value;
        }
    }


    class MyLinkedList
    {

        public MyLinkedList()
        {
            this.head = null;
            this.size = 0;
        }

        public Node head { get; set; }
        int size { get; set; }

        public void Add(string value)
        {

            var newNode = new Node(value);

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {

                var current = this.head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
            }

            this.size++;
        }
    }
}
