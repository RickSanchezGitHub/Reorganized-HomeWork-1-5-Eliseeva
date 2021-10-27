using Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWTests
{
    public class HW2Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(4, 3, 7)]
        [TestCase(4, 4, 16)]
        [TestCase(2,3,-1)]
        public void Solution1AddOrMultiplyOrDependingOnTheNumbersTests(int a, int b, int expected)
        {
            int actual = HelpersForHW2.AddOrMultiplyOrDependingOnTheNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(-1, 1, 2)]
        [TestCase(-1, -1, 3)]
        [TestCase(1, -1, 4)]
        [TestCase(1, 0, 5)]
        [TestCase(0, 1, 6)]
        [TestCase(0, -1, 7)]
        [TestCase(-1, 0, 8)]
        public void Solution2FindNumberOfCoordinatePlaceTests(int x, int y, int expected)
        {
            int actual = HelpersForHW2.FindNumberOfCoordinatePlace(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, "точка принадлежит первой четверти")]
        [TestCase(2, "точка принадлежит второй четверти")]
        [TestCase(3, "точка принадлежит третьей четверти")]
        [TestCase(4, "точка принадлежит четвертой четверти")]
        [TestCase(5, "точка находится на горизонтали 1 четверти")]
        [TestCase(6, "точка находится на вертикали 1 четверти")]
        [TestCase(7, "точка находится на вертикали 3 четверти")]
        [TestCase(8, "точка находится на горизонтали 3 четверти")]
        [TestCase(0, "точка находится в центре координат")]

        public void Solution2OutPutCoordinatePlaneNumberTests(int quarterNumber, string expected)
        {
            string actual = HelpersForHW2.OutPutCoordinatePlaneNumberForConsole(quarterNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 9, 7, 25)]
        public void Solution4FindTheDiscriminantTest(int a, int b, int c, int expected)
        {
            int actual = HelpersForHW2.FindTheDiscriminant(a, b, c);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(58, 5)]
        [TestCase(10, 1)]
        public void Solution5LookingForDozenTests(int number, int expected)
        {
            int actual = HelpersForHW2.GetNumberOfDozens(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(58, 8)]
        [TestCase(10, 0)]
        public void Solution5LookingForUnitTests(int number, int expected)
        {
            int actual = HelpersForHW2.GetNumberOfUnits(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10, "десять")]
        [TestCase(12, "двенадцать")]
        [TestCase(20, "двадцать  ")]
        [TestCase(66, "шестьдесят шерсть")]
        public void Solution5MakeNumberTests(int number, string expected)
        {
            string actual = HelpersForHW2.MakeNumber(number);
            Assert.AreEqual(expected, actual);
        }



    }
}
