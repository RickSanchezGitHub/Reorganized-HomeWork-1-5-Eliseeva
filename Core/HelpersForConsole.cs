using System;

namespace Core
{
    public static class HelpersForConsole
    {
        //общие помощники для работы с консолью
        public static int GetNumberFromUser(string message)
        {
            Console.WriteLine($"\n {message}");
            int  number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return number;
        }
        public static void OutPutInConsole( int numberSolution, string message)
        {
            Console.WriteLine($"\n Решением  задачи номер {numberSolution} является {message}");
        }
        // помощники для работы с одномерными массивами
        public static void OutPutOneDimArrayToConsole(int[] array) 
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"{array[index]} \t ");
            }
            Console.WriteLine();
        }
        // помощники для работы с двумерными массивами
        public static void ShowAnExistingArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"\t {array[i, j]}");
                }
                Console.WriteLine();
            }
        }

    }
}
