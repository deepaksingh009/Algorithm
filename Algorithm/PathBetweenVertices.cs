﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class PathBetweenVertices
    {
        private readonly int[,] vs;
        public PathBetweenVertices(int range)
        {

            vs = new int[range, range];
        }

        public void Addedges(int row, int column)
        {
            vs[row, column] = 1;

        }

        public bool isreachable(int start, int end)
        {
            bool check = false;
            int startnode = 0;
            int endNode = 0;
            List<int> ls = new List<int>();

            List<int> es = new List<int>();
            while (true)
            {
                if (ls.Count == 0)
                {
                    ls = new List<int>();
                }
               
                //Forloopfromstartnode
                for (int i = 0; i < vs.GetLength(0); i++)
                {
                    if (vs[startnode, i] == 1)
                        ls.Add(i);

                }
                
                foreach (var item in ls)
                {
                    foreach (var item1 in es)
                    {
                        if (vs[item, item1] == 1)
                        {
                            check = true;
                        }
                        else if (item == item1)
                        {
                            check = true;
                        }
                    }
                }
                startnode++;
                endNode++;

            }



            //for (int i = 0; i < vs.GetLength(0); i++)
            //{
            //    for (int j = 0; j < vs.GetLength(1); j++)
            //    {
            //        if (vs[i, j] == 1)
            //        {
            //            if (vs[end, i] == 1)
            //            {
            //                check = true;

            //            }
            //            else
            //            { check = false; }
            //        }
            //    }
            //}
            return check;

        }


    }

}

#region Implemenatation
//PathBetweenVertices pathBetweenVertices = new PathBetweenVertices(6);
//pathBetweenVertices.Addedges(0,1);
//            pathBetweenVertices.Addedges(1,0);
//            pathBetweenVertices.Addedges(1,2);
//            pathBetweenVertices.Addedges(2,1);
//            pathBetweenVertices.Addedges(2,5);
//            pathBetweenVertices.Addedges(5,2);
//            pathBetweenVertices.Addedges(2,3);
//            pathBetweenVertices.Addedges(3,2);
//            pathBetweenVertices.Addedges(3,4);
//            pathBetweenVertices.Addedges(4,3);


//            int start = 0;
//int End = 4;
//bool check;
//check=pathBetweenVertices.isreachable(start, End);
//            Console.WriteLine("is path reachable from " + start + "to" + End + "=" + check);

//            start = 4;
//            End = 0;
//            check = pathBetweenVertices.isreachable(start, End);
//            Console.WriteLine("is path reachable from " + start + "to" + End + "=" + check);
#endregion