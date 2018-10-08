using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class MatrixRotation
    {
        public int[,] CreateMatrix()
        {
            Console.WriteLine("Enter no of row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of column");
            int column = int.Parse(Console.ReadLine());

            int[,] vs = new int[row, column];


            for (int i = 0; i < row; i++)
            {

                Console.WriteLine("Enter column value for row" + i);

                for (int j = 0; j < column; j++)
                {
                    int columnvalue = int.Parse(Console.ReadLine());
                    vs[i, j] = columnvalue;

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
            return vs;



        }

        public void RoatateMatrix()
        {
            int[,] vs = CreateMatrix();

            int[,] finalMatrix = vs.Clone() as int[,];

            while (true)
            {
                int columnCount = 0;
                int rowcount = 0;
                int columnvalue = 0;
                int rowvalue = 0;

                columnCount = vs.GetLength(1);
                rowcount = vs.GetLength(0);



                //For Right Rotation

                for (int i = 0; i < rowcount; i++)
                {


                    for (int j = 1; j < columnCount; j++)
                    {
                        finalMatrix[i, j] = vs[i, j - 1];
                        columnvalue = j;

                    }
                    break;
                }
                //For Down Rotation
                for (int i = 0; i < rowcount - 1; i++)
                {
                    finalMatrix[i + 1, columnvalue] = vs[i, columnvalue];
                    rowvalue = i + 1;
                }
                //For Left Rotation
                for (int i = columnCount - 1; i > 0; i--)
                {
                    finalMatrix[rowvalue, i - 1] = vs[rowvalue, i];
                    columnvalue = i - 1;
                }
                //For Up Rotation
                for (int i = rowvalue; i > 0; i--)
                {
                    finalMatrix[i - 1, columnvalue] = vs[i, columnvalue];
                }
                break;


            }
            Console.WriteLine("After Rotation");
            for (int i = 0; i < finalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < finalMatrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0}\t", finalMatrix[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
