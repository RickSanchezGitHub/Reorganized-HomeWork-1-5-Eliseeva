using Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWTests
{
    public class HW4Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 4, 2, 3, 0 }, 0)]
        [TestCase(new int[] { 5, 2, -3, 3 }, -3)]
        public void Solution1GetMinArrayElementTests(int[] array, int expected)
        {
            int actual = WorkingWithArrayOneDim.GetMinArrayElement(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 0, 2, 4, 0 }, 4)]
        [TestCase(new int[] { 5, 2, -3, 3 }, 5)]
        public void Solution2GetMaxArrayElementTests(int[] array, int expected)
        {
            int actual = WorkingWithArrayOneDim.GetMaxArrayElement(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 0, 2, 4, 0 }, 3)]
        [TestCase(new int[] { 5, 2, -3, 3 }, 2)]
        public void Solution3GetIndexMinArrayElementTests(int[] array, int expected)
        {
            int actual = WorkingWithArrayOneDim.GetIndexMinArrayElement(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 0, 2, 4, 0 }, 2)]
        [TestCase(new int[] { 5, 2, -3, 3 }, 0)]
        public void Solution4GetIndexMaxArrayElementTests(int[] array, int expected)
        {
            int actual = WorkingWithArrayOneDim.GetIndexMaxArrayElement(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 0, 2, 4, 0, 5, 4, 7 }, 3)]
        [TestCase(new int[] { 5, 2, -3, 3 }, 2)]
        public void Solution5CountArrayElementsWithOddIndexTests(int[] array, int expected)
        {
            int actual = WorkingWithArrayOneDim.CountArrayElementsWithOddIndex(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        public void Solution6ArrayReversTests(int[] array, int[] expected)
        {
            int[] actual = array;
            WorkingWithArrayOneDim.ArrayReverse(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 2, 4, 5, 4, 7 }, 2)]
        [TestCase(new int[] { 5, 2, 7, 3 }, 3)]
        public void Solution7CountOddElementsAnArrayTests(int[] array, int expected)
        {
            int actual = WorkingWithArrayOneDim.CountOddElementsAnArray(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]

        public void Solution8SwapHalvesOfArrayInPlacesTests(int[] array, int[] expected)
        {
            int[] actual= array;
            WorkingWithArrayOneDim.SwapHalvesOfArrayInPlaces(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 3, 4, 6, 4, 1, 2 }, new int[] { 1, 2, 3, 4, 4, 6 })]
        [TestCase(new int[] { 4, 5, 3, 1, 2 } , new int[] { 1, 2, 3, 4, 5 })]
        public void Solution9SortArrayByAscendingSelectionTests(int[] array, int[] expected)
        {
            int[] actual = array;
            WorkingWithArrayOneDim.SortArrayByAscendingSelection(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 3, 4, 6, 4, 1, 2 }, new int[] { 1, 2, 3, 4, 4, 6 })]
        [TestCase(new int[] { 4, 5, 3, 1, 2 }, new int[] { 1, 2, 3, 4, 5 })]
        public void Solution10SortArrayByBubbleInDescerdingOrderTests(int[] array, int[] expected)
        {
            int[] actual = array;
            WorkingWithArrayOneDim.SortArrayByBubbleInDescerdingOrder(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
