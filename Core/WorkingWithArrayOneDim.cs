using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class WorkingWithArrayOneDim
    {
        public static void FillingRandomAnOneDimArray(int[] array)
        {
            Random rnd = new Random();
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = rnd.Next(100);
            }
        }
        public static int GetMinArrayElement(int[] array)
        {
            int minArrayElement = array[0];
            for (int index = 0; index < array.Length; index++)
            {
                if (minArrayElement >= array[index])
                {
                    minArrayElement = array[index];
                }
            }
            return minArrayElement;
        }
        public static int GetMaxArrayElement(int[] array)
        {
            int maxArrayElement = array[0];
            for (int index = 0; index < array.Length; index++)
            {
                if (maxArrayElement <= array[index])
                {
                    maxArrayElement = array[index];
                }
            }
            return maxArrayElement;
        }
        public static int GetIndexMinArrayElement(int[] array)
        {
            int minElement = array[0];
            int indexMinElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (minElement >= array[i])
                {
                    minElement = array[i];
                    indexMinElement = i;
                }
            }
            return indexMinElement;
        }
        public static int GetIndexMaxArrayElemen(int[] array)
        {
            int maxElenemt = array[0];
            int indexMaxElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxElenemt <= array[i])
                {
                    maxElenemt = array[i];
                    indexMaxElement = i;
                }
            }
            return indexMaxElement;
        }
        public static int CountArrayElementsWithOddIndex(int[] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                count++;
            }
            return count;
        }
        public static  void ArrayReverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int index = array.Length - 1;
                int t = array[i];
                array[i] = array[array.Length - (i + 1)];
                array[array.Length - (i + 1)] = t;
            }
        }
        public static int CountOddElementsAnArray(int[] array)
        {
            int count = 0;
            for (int index = 0; index < array.Length; index += 2)
            {
                  count++;                
            }
            return count;
        }
        public static  void SwapHalvesOfArrayInPlaces(int[] array) 
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp1 = array[i];
                int tmp2 = array[(array.Length - 1) - i];
                array[(array.Length - 1) - i] = tmp1;
                array[i] = tmp2;
            }
        }
        public static void SortArrayByAscendingSelection(int[] array)
        {
            int legthT = array.Length;
            int index = 0;
            for (int i = legthT -= 1; i >= 0; i--)
            {
                int max = array[i];
                for (int k = legthT; k >= 0; k--)
                {
                    if (max <= array[k])
                    {
                        max = array[k];
                        index = k;
                    }
                }
                array[index] = array[i];
                array[i] = max;
                legthT -= 1;
            }
        }
        public static void SortArrayByBubbleInDescerdingOrder(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        int max = array[i];
                        array[i] = array[k];
                        array[k] = max;
                    }
                }
            }
        }
    }
    
}
