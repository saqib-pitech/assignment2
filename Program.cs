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

    class StringBuilderDemo
    {
        //StringBuilder
    }

    class Program
    {
        static void Main(string[] args)
        {
            JaggedArray.Test();
            Console.Read();
        }
    }
}
