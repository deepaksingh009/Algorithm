using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithm
{
    class Graph
    {
        public Node head = null;
        public void Addnode(int data)
        {
            Node node = new Node();
            // node = head;
            node.data = data;
            node.next = head;
            head = node;
        }

        public int getlastnode()
        {
            Node node = head;
            int data = 0;
            while (node != null)
            {
                data = node.data;
                node = node.next;
            }
            return data;
        }
    }

    public class Node
    {
        public Node()
        {
            this.next = null;
            this.data = 0;
        }
        public Node next { get; set; }
        public int data { get; set; }
    }


}
