using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class MatrixRotation
    {
        public void CreateMatrix()
        {
            Console.WriteLine("Enter no of row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of column");
            int column = int.Parse(Console.ReadLine());

            int[,] vs = new int[row,column];


            for (int i = 0; i < row; i++)
            {

                Console.WriteLine("Enter column value for row" + i);

                for (int j = 0; j < column; j++)
                {
                    int columnvalue = int.Parse(Console.ReadLine());
                    vs[i,j] = columnvalue;

                }

            }


            for (int i = 0; i < vs.GetLength(0); i++)
            {
                for (int j = 0; j < vs.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0}\t", vs[i, j]));
                }
                Console.WriteLine();
            }



        }
    }
}
