using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class HelpersFowHW1
    {
        public static double CalcFormula(int a, int b)
        {
            double result = (5 * a + b * b) / (b - a);
            return result;
        }
        public static void SwapStrings(ref string strA, ref string strB)
        {
            string tmp = strA;
            strA = strB;
            strB = tmp;
        }
        public static int DivideTheNumber(int number1, int number2)
        {
            int result = number1 / number2;
            return result;
        }
        public static int RemainderOfDivisionOfNumber(int number1, int number2)
        {
            int result = number1 % number2;
            return result;
        }
        public static double CalcCoefficientOfEquationK(int x1, int y1, int x2, int y2)
        {
            double coefficiantK = (y2 - y1) / (x2 - x1);
            return coefficiantK;
        }
        public static double CalcCoefficientOfEquationB(int x1, int y1, int x2, int y2)
        {
            double coefficiantB = y1 - (y2 - y1) / (x2 - x1) * x1;
            return coefficiantB;
        }
        public static double SolveLinearEquation(int a, int b, int c)
        {
            double resulrX = (c - b) / a;
            return resulrX;
        }
    }
}
