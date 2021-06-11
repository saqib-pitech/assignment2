using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class JaggedArray
    {
        static int[][] jaggedArray = new int[][]
        {
            new int[] { 1,2,3,4,5 },
            new int[] { 6,7,8,9 },
            new int[] { 10,11 }
        };
        /*static int[2][,] jaggedArray2 = new int[2][,]
        {
            new int[,] {{1,2},{3,4}},
            new int[,] {{5,6},{7,8}}
        };*/

        public static void Test()
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
        }
    }

    

    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            JaggedArray.Test();

            #region string builder
            StringBuilder sb = new StringBuilder("Engine");
            sb.Append(new char[] { 'e', 'r' });
            sb.Insert(0, "senior ");
            sb.AppendFormat(" - {0}{1}", "pi", 'T');
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            sb.Replace('s', 'S');
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            #endregion

            #region Generic Swap
                int a = 1, b = 2;
                Swap<int>(ref a, ref b);
                Console.WriteLine($"{a},{b}");
            #endregion
            s
            Console.Read();
        }
    }
}
