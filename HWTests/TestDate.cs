using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWTests
{
    public class TestDate
    {
        public static int[,] GetArrayForTestsGetMinElementInArray(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 0, 5, 9}, { 1, 4, 3, 0 } },
                1 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} },
                2 => new int[,] { { 4, 6, 8, 7, 1 }, { 3, 5, 8, 7, 2 }, {8, 7, 4, 3, 0,  } },
                _ => new int[,] { { } },
            };
        }
        public static int[,] GetArrayForTestsGetMaxElementInArray(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 0, 5, 9 }, { 1, 4, 3, 0 } },
                1 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                2 => new int[,] { { 4, 6, 8, 7, 1 }, { 3, 5, 8, 7, 2 }, { 8, 7, 4, 3, 0, } },
                _ => new int[,] { { } },
            };
        }
        public static int[,] GetArrayForTestsGetIndexMinOrMaxElementInArray(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 0, 5, 9 }, { 1, 4, 3, 0 } },
                1 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                2 => new int[,] { { 4, 6, 8, 7, 1 }, { 3, 5, 8, 1, 2 }, { 10, 7, 4, 3, 2, } },
                _ => new int[,] { { } },
            };
        }
        public static int[,] GetArrayForTestsGetIndexMaxOrMaxElementInArray(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 0, 5, 9 }, { 1, 4, 3, 0 } },
                1 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                2 => new int[,] { { 4, 6, 8, 7, 1 }, { 3, 5, 8, 1, 2 }, { 10, 7, 4, 3, 2, } },
                _ => new int[,] { { } },
            };
        }
        public static int[,] GetArrayForTestsElemtntHasMoreNeighbors(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 0, 5, 9 }, { 1, 4, 3, 0 }, { 4, 3, 6, 5 } },
                1 => new int[,] { { 5, 2, 3 }, { 4, 5, 3 }, { 7, 4, 9 } },
                2 => new int[,] { { 9, 6, 8, 7, 1 }, { 3, 5, 7, 1, 2 }, { 10, 7, 2, 3, 1, } },
                _ => new int[,] { { } },
            };
        }
        public static int[,] GetArrayToTestSwapElementsRelativeToMainDiagonal(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } },
                1 => new int[,] { {1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                2 => new int[,] { { 1, 2}, { 3, 4 } },
                3 => new int[,] { { 1 } },
                _ => new int[,] { { } },

            };
        }
        public static int[,] GetExpectedArrayToTestSwapElementsRelativeToMainDiagonal(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 5, 9, 13 }, { 2, 6, 10, 14 }, { 3, 7, 11, 12 }, { 4, 8, 12, 16 } },
                1 => new int[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } },
                2 => new int[,] { { 1, 3 }, { 2, 4 } },
                3 => new int[,] { { 1 } },
                _ => new int[,] { { } },

            };
        }
    }
}
