using Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWTests
{
    public class HW5Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 0)]
        public void Solution1GetMinElementInArray(int indexArray, int expected)
        {
            int[,] arrayToTest = TestDate.GetArrayForTestsGetMinElementInArray(indexArray);
            int actual = WorkingWithArrayTwoDim.GetMinElementInArray(arrayToTest);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(0, 9)]
        [TestCase(1, 9)]
        [TestCase(2, 8)]
        public void Solution2GetMaxElementInArray(int indexArray, int expected)
        {
            int[,] arrayToTest = TestDate.GetArrayForTestsGetMaxElementInArray(indexArray);
            int actual = WorkingWithArrayTwoDim.GetMaxElementInArray(arrayToTest);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(0, "1 3")]
        [TestCase(1, "0 0")]
        [TestCase(2, "1 3")]
        public void Solution3GetIndexMinElementInArray(int indexArray, string expected)
        {
            int[,] arrayToTest = TestDate.GetArrayForTestsGetIndexMinOrMaxElementInArray(indexArray);
            string actual = WorkingWithArrayTwoDim.GetIndexMinElementInArray(arrayToTest);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(0, "0 3")]
        [TestCase(1, "2 2")]
        [TestCase(2, "2 0")]
        public void Solution4GetIndexMaxElementInArray(int indexArray, string expected)
        {
            int[,] arrayToTest = TestDate.GetArrayForTestsGetIndexMaxOrMaxElementInArray(indexArray);
            string actual = WorkingWithArrayTwoDim.GetIndexMaxElementInArray(arrayToTest);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(0, 4)]
        [TestCase(1, 4)]
        [TestCase(2, 5)]
        public void Solution5GetIndexMaxElementInArray(int indexArray, int expected)
        {
            int[,] arrayToTest = TestDate.GetArrayForTestsElemtntHasMoreNeighbors(indexArray);
            int actual = WorkingWithArrayTwoDim.ElemtntHasMoreNeighbors(arrayToTest);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]

        public void Solution6SwapElementsRelativeToMainDiagonalTests(int indexArray, int indexExpected)
        {
            int[,] arrayToTest = TestDate.GetArrayToTestSwapElementsRelativeToMainDiagonal(indexArray);
            int[,] arrayExpected = TestDate.GetExpectedArrayToTestSwapElementsRelativeToMainDiagonal(indexExpected);
            WorkingWithArrayTwoDim.SwapElementsRelativeToMainDiagonal(arrayToTest);
            Assert.AreEqual(arrayToTest, arrayExpected);
        }
    }
}
