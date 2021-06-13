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


    class IndexerDemo
    {
        private string[] fruits = new string[10];
        public string this[int i]
        {
            get
            {
                return fruits[i];
            }
            set
            {
                fruits[i] = value;
            }
        }
    }

    class PassCheck
    {
        private static string pass;
        static bool Letter()
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsLetter(pass[i])) return true;
            }
            return false;
        }
        static bool Digit()
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i])) return true;
            }
            return false;
        }
        static bool Symbol()
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsSymbol(pass[i])) return true;
            }
            return false;
        }
        static bool Caps()
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i])) return true;
            }
            return false;
        }  // atleast one letter caps
        static bool MinLength()
        {
            return pass.Length >= 6;
        }
        public static bool Check(string p_pass)
        {
            pass = p_pass;
            return Letter() || Digit() || Symbol() || Caps() || MinLength();
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
        #region minMax

        static int[] MinMax(int[] a)
        {
            int min = 9999999, max = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min) min = a[i];
                if (a[i] > max) max = a[i];
            }
            int[] ret = { min, max };
            return ret;
        } 
        #endregion

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

            #region Indexer

            IndexerDemo ind = new IndexerDemo();
            ind[0] = "apple";
            ind[1] = "mango";
            ind[2] = "grapes";
            ind[3] = "avocado";

            Console.WriteLine(ind[0]);
            Console.WriteLine(ind[2]);

            #endregion

            int[] t = { 9, 1, 4, 5, 22, 3, 45 };
            Console.WriteLine( $"Min: {MinMax(t)[0]}, Max: {MinMax(t)[1]}");

            if (PassCheck.Check("P@sswo4d"))
            {
                Console.WriteLine("pass ok");
            }
            else
            {
                Console.WriteLine("not ok");
            }

            Console.Read();
        }
    }
}
