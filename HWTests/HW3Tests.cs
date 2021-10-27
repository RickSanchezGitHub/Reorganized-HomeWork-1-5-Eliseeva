using Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWTests
{
    public class HW3Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(2,10,1024)]
        [TestCase(1, 0, 1)]
        public void Solution1CalcPowTests(int number, int power, int expected)
        {
            int actual = HelpersForHW3.CalcPow(number, power);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10,4)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]

        public void Solution3GetCountNumbersWhoseSquareLessThanNumbertests(int number, int expected)
        {
            int actual = HelpersForHW3.GetCountNumbersWhoseSquareLessThanNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5)]
        public void Solution4GetLargestDivisorTest(int number, int expected)
        {
            int actual = HelpersForHW3.GetLargestDivisor(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 22,42)]

        public void Solution5GetCountOfNumbersDivisibleBySevenWithinRangeTest(int startRange, int endRange, int expected)
        {
            int actual = HelpersForHW3.GetCountOfNumbersDivisibleBySevenWithinRange(startRange, endRange);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]

        public void Solution6NumberOfFibonacciSeriesTests(int fibonachiN, int expected)
        {
            int actual = HelpersForHW3.GetTheSequenceNumberOfTheFibonacciSeries(fibonachiN);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(4, 3, 1)]
        [TestCase(5, 5, 5)]
        [TestCase(10, 5, 5)]
        [TestCase(0, 3, 3)]

        public void Solution7GetGreatestCommonDivisorTests(int number1, int number2, int expected)
        {
            int actual = HelpersForHW3.GetGreatestCommonDivisor(number1, number2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 2)]
        [TestCase(10, 2.15)]
        public void Solution8GetNumberByMethodOfHalfDivisionTests(int number, double expected)
        {
            double actual = HelpersForHW3.GetNumberByMethodOfHalfDivision(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(23456, 2)]
        public void Solution9GetQuantityOddDigitsTest(int number, int expected)
        {
            int actual = HelpersForHW3.GetQuantityOddDigits(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(123, 321)]
        [TestCase(3256, 6523)]
        public void Solution10MirrorNumber(int number, int expected)
        {
            int actual = HelpersForHW3.GetMirrorNumber(number);
            Assert.AreEqual(expected, actual);
        }
    }
    
}
