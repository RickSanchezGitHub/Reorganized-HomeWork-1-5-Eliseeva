using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class WorkingWithArrayTwoDim
    {
        public static void FillingRandomTwoDimArray(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10);
                }
            }
        }

        public static int GetMinElementInArray(int[,] array)
        {
            int minElement = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (minElement >= array[i, j])
                    {
                        minElement = array[i, j];
                    }
                }
            }
            return minElement;
        }
        public static int GetMaxElementInArray(int[,] array)
        {
            int maxElement = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxElement <= array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }
            }
            return maxElement;
        }
        public static string GetIndexMinElementInArray(int[,] array)
        {
            int indexi = 0;
            int indexj = 0;
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min >= array[i, j])
                    {
                        min = array[i, j];
                        indexi = i;
                        indexj = j;
                    }
                }
            }
            string indexElement = $"{indexi} {indexj}";
            return indexElement;
        }
        public static string GetIndexMaxElementInArray(int[,] array)
        {
            int indexi = 0;
            int indexj = 0;
            int maxElement = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxElement <= array[i, j])
                    {
                        maxElement = array[i, j];
                        indexi = i;
                        indexj = j;
                    }
                }
            }
            string indexMaxElement = $"{indexi} {indexj}";
            return indexMaxElement;
        }
        public static int ElemtntHasMoreNeighbors(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int up;
                    int down;
                    int left;
                    int right;
                    if (i - 1 >= 0)
                    {
                        up = array[i - 1, j];
                    }
                    else
                    {
                        up = array[i, j] - 1;
                    }
                    if (i + 1 < array.GetLength(0))
                    {
                        down = array[i + 1, j];
                    }
                    else
                    {
                        down = array[i, j] - 1;
                    }
                    if (j - 1 >= 0)
                    {
                        left = array[i, j - 1];
                    }
                    else
                    {
                        left = array[i, j] - 1;
                    }
                    if (j + 1 < array.GetLength(1))
                    {
                        right = array[i, j + 1];
                    }
                    else
                    {
                        right = array[i, j] - 1;
                    }
                    if (array[i, j] > up && array[i, j] > down && array[i, j] > left && array[i, j] > right)
                    {
                        count++;

                    }
                }
            }
            return count;
        }
        public static  void SwapElementsRelativeToMainDiagonal(int[,] array)
        {
            int indexJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = array.GetLength(1) - 1; j > indexJ; j--)
                {
                    int tmp = array[i, j];
                    int a = array[i, j] = array[j, i];
                    int b = array[j, i] = tmp;
                }
                indexJ++;
            }
        }
    }
}
