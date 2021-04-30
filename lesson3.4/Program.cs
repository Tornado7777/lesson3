/*«Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, 
 * где Х — элементы кораблей, а О — свободные клетки */
using System;

namespace lesson3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] SeaWar =
            {
                {'O','X','X','O','O','O','O','O','O','X'},
                {'O','O','O','O','X','X','X','O','O','X'},
                {'X','O','O','O','O','O','O','O','O','O'},
                {'X','O','O','O','O','O','X','O','O','O'},
                {'X','O','X','O','O','O','O','O','O','O'},
                {'X','O','O','O','O','O','O','O','O','O'},
                {'O','O','O','O','O','O','O','O','X','O'},
                {'O','O','O','O','X','X','X','O','O','O'},
                {'O','X','X','O','O','O','O','O','O','O'},
                {'O','O','O','O','O','O','X','O','O','O'}
            };
            for (int i = 0; i < SeaWar.GetLength(0); i++)
            {
                int j = 0;
                while (j < SeaWar.GetLength(1))
                {
                    Console.Write(SeaWar[i, j]);
                    if (SeaWar.GetLength(1) == (j+1))
                    {
                        Console.Write("\n");
                    }
                    j++;
                }
            }
            Console.ReadKey();
            
        }
    }
}
