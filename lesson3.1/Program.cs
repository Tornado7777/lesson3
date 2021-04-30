//Написать программу, выводящую элементы двухмерного массива по диагонали.
using System;

namespace lesson3._1
{
    class Program
    {
          

        static void Main(string[] args)
        {
            int[,] m = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            for (int i = 0; i < m.GetLength(0); i++)
            {
                Console.WriteLine(m[i,i]);
            }
            Console.ReadKey();
        }
    }
}
