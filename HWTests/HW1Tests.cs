using Core;
using NUnit.Framework;
using System;

namespace HWTests
{
    public class HW1Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(13, 9, -36.5)]
        [TestCase(0, 7, 7.0)]
        public void Solution1CalcFormula(int number1, int number2, double expected)
        {
            // arrange

            // act

            double actual = HelpersForHW1.CalcFormula(number1, number2);

            // assert

            Assert.AreEqual(expected, actual);
        }
        [TestCase(25, 3, 8)]
        public void Solution3DivideTheNumber(int number1, int number2, int expected)
        {
            int actual = HelpersForHW1.DivideTheNumber(number1, number2);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(25, 4, 1)]
        public void Solution3RemainderOfDivisionOfNumber(int number1, int number2, double expected)
        {
            double actual = HelpersForHW1.GetRemainderOfDivisionOfNumber(number1, number2);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 4, 11, 3.5)]
        public void Solution4SolveLinearEquation(int a, int b, int c, double expected)
        {
            double actual = HelpersForHW1.SolveLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(5, 7, 4, 8, -1.0)]
        [TestCase(5, 8, 3, -5, 6.5)]
        [TestCase(5, 4, 9, 3, -0.25)]
        public void Solution5CalcCoefficientOfEquationK(int x1, int y1, int x2, int y2, double expected)
        {
            double actual = HelpersForHW1.CalcCoefficientOfEquationK(x1, y1, x2, y2);
            
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 3, 4, 5, 1)]
        [TestCase(1, 4, 5, 6, 3.5)]

        public void Solution5CalcCoefficientOfEquationB(int x1, int y1, int x2, int y2, double expected)
        {
            double actual = HelpersForHW1.CalcCoefficientOfEquationB(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }
        

    }
}