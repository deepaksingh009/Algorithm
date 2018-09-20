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

        }
    }
    

}