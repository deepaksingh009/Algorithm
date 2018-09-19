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
            node.data = data;
            node.next = head;
            head = node;
        }

        public int GetFirstAdded()
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

        public void InsertAfter(int node1, int data)
        {
            Node addnode = new Node();
            addnode.data = data;
            Node node = head;

            while (node.next != null)
            {
                if (node.data == node1)
                {
                    addnode.next = node.next;

                    node.next = addnode;
                    break;
                }
                node = node.next;
            }

        }

        public void InsertFirst(int data)
        {
            Node node = new Node
            {
                data = data,
                next = head
            };
            head = node;
        }


        public void InsertLast(int data)
        {
            

            Node node1 = new Node();
            node1.data = data;
            node1.next = null;

            Node node = head;

            while (node.next!=null)
            {
                Node temp = node;
                
                node = node.next;
                if (node.next == null)
                {

                    node.next = node1;
                    node = node.next;
                }

            }

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
