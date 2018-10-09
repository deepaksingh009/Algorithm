using System;
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


    }



}