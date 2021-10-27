using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class HelpersForHW1
    {
        public static double CalcFormula(int a, int b)
        {
            if (a == b)
            {
                throw new ArgumentException("а и b должны быть разными");
            }
            double result = (5 * a + b * b * 1.0) / (b - a);
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
            if (number2 == 0)
            {
                throw new ArgumentException("второе число не может быть нулем");
            }
            int result = number1 / number2;
            return result;
        }
        public static int GetRemainderOfDivisionOfNumber(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new ArgumentException("второе число не может быть нулем");
            }
            int result = number1 % number2;
            return result;
        }
        public static double SolveLinearEquation(int a, int b, int c)
        {
            double resulrX = 1.0*(c - b) / a;
            return resulrX;
        }
        public static double CalcCoefficientOfEquationK(int x1, int y1, int x2, int y2) 
        {
            if (x1 == x2)
            {
                throw new ArgumentException("x1 и x2 должны быть разными");
            }
            double coefficiantK = (y2 - y1 * 1.0) / (x2 - x1);
            return coefficiantK;
        }
        public static double CalcCoefficientOfEquationB(int x1, int y1, int x2, int y2)
        {
            double coefficiantB = y1 - HelpersForHW1.CalcCoefficientOfEquationK(x1, y1, x2, y2) * x1*1.0;
            return coefficiantB;
        }

    }
}
