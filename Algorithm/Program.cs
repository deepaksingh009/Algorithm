using System;
using System.Collections.Generic;
using System.IO;
using Dijkstra.NET.Extensions;
using Dijkstra.NET.Model;

namespace Algorithm
{
    public class Models
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }
        public int X { get; set; }


    }
    class Program
    {
        public void NoOfMarks()
        {
            List<int> vs = new List<int>();

            int TestCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < TestCase; i++)
            {

                int NoOfQuestion = 0;
                NoOfQuestion = int.Parse(Console.ReadLine().Split(' ')[0]);
                if (NoOfQuestion == 1)
                {
                    vs.Add(NoOfQuestion * 3);
                }
                else
                {
                    vs.Add((NoOfQuestion * 3) - 1);
                }
            }

            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
        }



        public void TIcketBooking()
        {

            //A: It denotes the cost of one ticket of the flight. 6000
            //B: It denotes the number of total available seats in the flight.10
            //C: If the numbers of available seats are less than or equal to c, then the cost of the flight ticket increases to d 5.
            //D: It denotes the new hiked cost.6500
            //X: It denotes family member; 7

            //Input format A B C D X
            Models models = new Models();
            int totalcost = 0;
            int leftno = 0;
            var test = Console.ReadLine().Split(' ');
            models.A = Convert.ToInt32(test[0]);
            models.B = Convert.ToInt32(test[1]);
            models.C = Convert.ToInt32(test[2]);
            models.D = Convert.ToInt32(test[3]);
            models.X = Convert.ToInt32(test[4]);
            if (models.B < models.C)
            {
                leftno = models.B - models.C;
            }
            else
            {

                leftno = models.C - models.B;
            }
            totalcost = models.A * leftno;
            if (models.C <= models.X)
            {

                leftno = models.X - leftno;
                totalcost = totalcost + (models.D * leftno);
            }
            else if (models.X <= models.C)
            {

            }

            Console.WriteLine(totalcost);




        }

        static void Main(string[] args)
        {
            //int input = Convert.ToInt32(Console.ReadLine());
            //for (int j = 0; j < input; j++)
            //{
            //    string[] inputs = Console.ReadLine().Split(' ');
            //    int n = Convert.ToInt32(inputs[0]);
            //    int a = Convert.ToInt32(inputs[1]);
            //    int b = Convert.ToInt32(inputs[2]);
            //    int k = getK(a, b);
            //    int possibilities = 0;
            //    if (n >= k)
            //        possibilities = (((n + 1) * (n + 2) / 2) - ((n + 1 - k) * (n + 2 - k) / 2));
            //    else possibilities = (n + 1) * (n + 2) / 2;

            //    Console.WriteLine(possibilities);
            //}
            getinput();
            Console.ReadKey();
        }

        public static int getK(int a, int b)
        {
            int x = a;
            int y = b;
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return (x + y) / a;
        }

        public static int getinput()
        {
            string[] vs = Console.ReadLine().Split(' ');

            string str = string.Empty;
            int closeounter = 0;
            int opencounter = 0;
            int checkpositive = 0;
            int checknegative = 0;
            foreach (var item in vs)
            {

                if (item=="+")
                {
                    if (closeounter > 0 && checknegative>0)
                    {
                        str = str +')'+ item;
                    }
                    else 
                    {
                        str = str + item;
                      // closeounter++;
                    }
                    checkpositive++;

                }
                else if(item=="-")
                {
             
                    if (opencounter > 0 && checkpositive!=0) 
                    {
                        str = str + ')' + item;
                        opencounter--;
                        closeounter++;
                        checkpositive = 0;
                        checknegative++;
                    }
                    else if(closeounter!=0)
                    {
                        str = str + item  ;
                        
                    }
                    else
                    {
                        str = str + item + '(';
                        opencounter++;
                    }
                }
                else
                {
                    str = str + item;
                }

            }

            while(closeounter<opencounter)
            {
                str = str + ')';
                closeounter++;
            }

            Console.Write(str);


            return 0;
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