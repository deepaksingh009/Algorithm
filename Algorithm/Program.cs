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

            Program.Factorcalculation();
            Console.ReadKey();
        }

        public static void Factorcalculation()
        {
           
            //int input = int.Parse(Console.ReadLine());

         
            int[] listofinput = new int[] { 30,
23,
17,
18,
19,
1,
27,
2,
14,
12,
30,
13,
21,
28,
22,
9,
24,
11,
8,
20,
6,
29,
15,
10,
26,
7,
3,
5,
16,
4,
25};
            //List<int> listofinput = new List<int>();
            //for (int i = 0; i < input; i++)
            //{

            //    int f = int.Parse(Console.ReadLine());
            //    listofinput[i] = f;
            //}
            List<double> outputresult = new List<double>();
            for (int s = 0; s <listofinput.Length; s++)
            {


                int integer = listofinput[s];
                List<int> vs = new List<int>();

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
                double output = 0;
                if (check == true)
                {
                    output = Math.Pow(test, 4);
                    
                }
                else
                {
                    output = -1;
                }
                outputresult.Add(output);

                //Console.WriteLine(output);

            }
            foreach (var item in outputresult)
            {
                Console.WriteLine(item);
            }
        }
    }



}