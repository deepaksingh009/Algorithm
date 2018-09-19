using System;
using System.Collections.Generic;
using Dijkstra.NET.Extensions;
using Dijkstra.NET.Model;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {


            Graph graph = new Graph();
            graph.Addnode(1);
            graph.Addnode(2);
            graph.Addnode(3);
            graph.Addnode(4);
            graph.InsertFirst(0);
            graph.InsertLast(5);
            graph.InsertAfter(3, 6);


            int intVal = graph.GetFirstAdded();
            System.Console.WriteLine(intVal);

            // GenericList<int> gll = new GenericList<int>();
            // gll.AddNode(5);
            // gll.AddNode(4);
            // gll.AddNode(3);
            // int intVal1 = gll.GetFirstAdded();
            // //The following line displays 5.
            //System.Console.WriteLine(intVal1);
            // Console.ReadKey();


        }
    }
    //public class Node
    //{
    //    public Node next;
    //    public Object data;
    //}
    //public class LinkedList
    //{
    //    private Node head;
    //    public void printAllNodes()
    //    {
    //        Node current = head;
    //        while (current != null)
    //        {
    //            Console.WriteLine(current.data);
    //            current = current.next;
    //        }
    //    }
    //    public void Add(Object data)
    //    {
    //        Node toAdd = new Node();
    //        toAdd.data = data;
    //        Node current = head;
    //        printAllNodes();
    //        current.next = toAdd;
    //    }
    //}

    //public class GenericList<T>
    //{
    //    private class Node
    //    {
    //        //Each node has a reference to the next node in the list.
    //        public Node Next;
    //       // Each node holds a value of type T.
    //        public T Data;
    //    }

    //   // The list is initially empty.
    //    private Node head = null;

    //   // Add a node at the beginning of the list with t as its data value.
    //    public void AddNode(T t)
    //    {
    //        Node newNode = new Node
    //        {
    //            Next = head,
    //            Data = t
    //        };
    //        head = newNode;
    //    }

    //    //The following method returns the data value stored in the last node in
    //    // the list.If the list is empty, the default value for type T is
    //    // returned.
    //    public T GetFirstAdded()
    //    {
    //        //The value of temp is returned as the value of the method. 
    //        // The following declaration initializes temp to the appropriate
    //        // default value for type T. The default value is returned if the
    //        // list is empty.
    //        T temp = default(T);

    //        Node current = head;
    //        while (current != null)
    //        {
    //            temp = current.Data;
    //            current = current.Next;
    //        }
    //        return temp;
    //    }
    //}

}