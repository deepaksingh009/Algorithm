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
            List<int> ls = new List<int>();
            List<int> es = new List<int>();
            while (true)
            {
                //Forloopfromstartnode
                for (int i = 0; i < vs.GetLength(0); i++)
                {
                    if (vs[start, i] == 1)
                        ls.Add(i);

                }

                //ForLoopFromLastnode

                for (int i = 0; i < vs.GetLength(0); i++)
                {

                    if (vs[end, i] == 1)
                        es.Add(i);
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