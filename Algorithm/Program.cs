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

            Program matrix90DegreeRotation = new Program();
            matrix90DegreeRotation.HashTheHostImplementation();



            Console.ReadKey();
        }
        public void HashTheHostImplementation()
        {
            int input = 0;
            input = int.Parse(Console.ReadLine());
            int[,] vs = new int[input, input];

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {

                    if (i == j)
                    {
                        vs[i, j] = -1;
                    }
                    else
                    {
                        vs[i, j] = 0;
                    }

                }
            }


            for (int i = 0; i < input; i++)
            {
                string[] inputstring = Console.ReadLine().Split(' ');

                for (int s = 1; s < inputstring.Length; s++)
                {
                    int indexvalue = Convert.ToInt32(inputstring[s]);
                    vs[i, indexvalue - 1] = 1;
                }
            }

            int finalcount = 0;
            for (int i = 0; i < vs.GetLength(0); i++)
            {
                for (int j = 0; j < vs.GetLength(1); j++)
                {
                    if (vs[i, j] == 0)
                    {
                        finalcount++;
                    }

                }
            }

            Console.WriteLine(finalcount);

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