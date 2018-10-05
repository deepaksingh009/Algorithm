using System;
using System.Collections.Generic;
using System.IO;
using Dijkstra.NET.Extensions;
using Dijkstra.NET.Model;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            MatrixRotation matrixRotation = new MatrixRotation();
            matrixRotation.RoatateMatrix();
            

            Console.ReadKey();
        }
        
        public static void Factorcalculation()
        {

            //int input = int.Parse(Console.ReadLine());


            int[] listofinput = new int[] { };
            //List<int> listofinput = new List<int>();
            //for (int i = 0; i < input; i++)
            //{

            //    int f = int.Parse(Console.ReadLine());
            //    listofinput[i] = f;
            //}
            List<long> outputresult = new List<long>();

            for (int s = 0; s < listofinput.Length; s++)
            {


                int integer = listofinput[s];
                List<long> vs = new List<long>();

                //for (int i = 1; i <= input; i++)
                //{

                for (int j = 1; j <= integer / 2; j++)
                {
                    if (integer % j == 0)
                    {
                        vs.Add(j);

                    }
                }
                //}

                int test = integer / 4;
                bool check = vs.Contains(test);
                long output = 0;
                if (check == true)
                {
                    output = Convert.ToInt64(Math.Pow(test, 4));

                }
                else
                {
                    output = -1;
                }
                outputresult.Add(output);

                //Console.WriteLine(output);

            }
            foreach (long item in outputresult)
            {
                // decimal dec = Decimal.Parse(item, System.Globalization.NumberStyles.Number);
                Console.WriteLine(item.ToString());
                System.IO.File.WriteAllText(@"D:\Deepak\Algorithm\TestFolder\WriteText.txt", item.ToString());
            }
        }
    }



}