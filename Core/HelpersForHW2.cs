using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class HelpersForHW2
    {
        public static int AddOrMultiplyOrDependingOnTheNumbers(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }
        public static int FindNumberOfCoordinatePlace(int x, int y)
        {
            int quarterNumber;
            if( x == 0 && y == 0)
            {
                quarterNumber = 0;
            }
            else
            {
                if ( x > 0)
                {
                    if (y > 0)
                    {
                        quarterNumber = 1;
                    }
                    else
                    {
                        if (y == 0)
                        {
                            quarterNumber = 5;
                        }
                        else
                        {
                            quarterNumber = 4;
                        }
                    }
                }
                else
                {
                    if (x == 0)
                    {
                        if (y > 0 )
                        {
                            quarterNumber = 6;
                        }
                        else
                        {
                            quarterNumber = 7;
                        }
                    }
                    else
                    {
                        if (y > 0)
                        {
                            quarterNumber = 2;
                        }
                        else
                        {
                            if (y == 0)
                            {
                                quarterNumber = 8;
                            }
                            else
                            {
                                quarterNumber = 3;
                            }
                        }
                    }
                }
            }
            return quarterNumber;
        }
        public static string OutPutCoordinatePlaneNumberForConsole(int quarterNumber)
        {
            string strQuarter;
            switch (quarterNumber)
            {
                case 1:
                    strQuarter = "точка принадлежит первой четверти";
                    break;
                case 2:
                    strQuarter = "точка принадлежит второй четверти";
                    break;
                case 3:
                    strQuarter = "точка принадлежит третьей четверти";
                    break;
                case 4:
                    strQuarter = "точка принадлежит четвертой четверти";
                    break;
                case 0:
                    strQuarter = "точка находится в центре координат";
                    break;
                case 5:
                    strQuarter = "точка находится на горизонтали 1 четверти";
                    break;
                case 6:
                    strQuarter = "точка находится на вертикали 1 четверти";
                    break;
                case 7:
                    strQuarter = "точка находится на вертикали 3 четверти";
                    break;
                case 8:
                    strQuarter = "точка находится на горизонтали 3 четверти";
                    break;
                default:
                    strQuarter = "точка находится вне нашего понимания";
                    break;
            }
            return strQuarter;
        }
        public static string SortVariables(int a, int b, int c)
        {
            string varificationResult;
            if (a <= b && a <= c && b <= c)
            {
                varificationResult = $"{a},{b},{c}";
            }
            else if (a <= b && a <= c && c <= b)
            {
                varificationResult = $"{a},{c},{b}";
            }
            else if (b <= a && b <= c && a <= c)
            {
                varificationResult = $"{b},{a},{c}";
            }
            else if (b <= c && b <= a && c <= a)
            {
                varificationResult = $"{b},{c},{a}";
            }
            else if (c <= b && c <= a && a <= b)
            {
                varificationResult = $"{c},{a},{b}";
            }
            else
            {
                varificationResult = $"{c},{b},{a}";
            }
            return varificationResult;
        }
        public static string TestingOfDiscriminant(double discriminant, int a, int b)
        {
            string resultEquation;
            if (discriminant > 0)
            {
                resultEquation = SolutionIfDscrGreaterThanZero(discriminant, a, b);
            }
            else if (discriminant == 0)
            {
                resultEquation = SolutionIfDscrIsZero( a, b);
            }
            else
            {
                resultEquation = SolutionIfDscrLessThanZero();
            }
            return resultEquation;
        }
        public static int FindTheDiscriminant(int a, int b, int c)
        {
            double discriminant = Math.Pow(b, 2) - (4 * a * c);
            return (int)discriminant;
        }
        public static string SolutionIfDscrLessThanZero()
        {
            string result = "Данное решение находится за пределами вашего понимания, так как D < 0";
            
            return result;
        }
        public static string SolutionIfDscrIsZero(int a, int b)
        {
            double x1 = -b / 2 * a;
            string result = $"Решение уравнения ax ^ 2 + bx + c = 0 : x1 = { x1}";
            return result;
        }
        public static string SolutionIfDscrGreaterThanZero(double discriminant, int a, int b)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            string result = $"Решение уравнения ax^2 + bx + c = 0 : x1 = {x1}, x2 = {x2}";
            return result;
        }
        public static int GetNumberOfDozens(int number)
        {
            int result = number / 10;
            return result;
        }
        public static int GetNumberOfUnits(int number)
        {
            int result = number % 10;
            return result;
        }
        public static string ValidateUnits(int number)
        {
            int unit = GetNumberOfUnits(number);
            string strUnit;
            switch (unit)
            {
                case 1:
                    strUnit = "один";
                    break;
                case 2:
                    strUnit = "два";
                    break;
                case 3:
                    strUnit = "три";
                    break;
                case 4:
                    strUnit = "четыре";
                    break;
                case 5:
                    strUnit = "пять";
                    break;
                case 6:
                    strUnit = "шерсть";
                    break;
                case 7:
                    strUnit = "семь";
                    break;
                case 8:
                    strUnit = "восемь";
                    break;
                case 9:
                    strUnit = "девять";
                    break;
                case 0:
                    strUnit = " ";
                    break;
                default:
                    strUnit = "шо-то пошло не так";
                    break;
            }
            return strUnit;
        }
        public static string ValidateDozen(int number)
        {
            int dozen = GetNumberOfDozens(number);
            string strDozen;
            switch (dozen)
            {
                case 2:
                    strDozen = "двадцать ";
                    break;
                case 3:
                    strDozen = "тридцать ";
                    break;
                case 4:
                    strDozen = "сорок";
                    break;
                case 5:
                    strDozen = "пятьдесят ";
                    break;
                case 6:
                    strDozen = "шестьдесят ";
                    break;
                case 7:
                    strDozen = "семьдесят ";
                    break;
                case 8:
                    strDozen = "восемьдесят";
                    break;
                case 9:
                    strDozen = "девяносто ";
                    break;
                default:
                    strDozen = "шо-то пошло не так ";
                    break;
            }
            return strDozen;
        }
        public static string ValidateTen(int number)
        {
            int unit = GetNumberOfUnits(number);
            string strTen;
            switch (unit)
            {
                case 0:
                    strTen = "десять";
                    break;
                case 1:
                    strTen = "одиннадцать";
                    break;
                case 2:
                    strTen = "двенадцать";
                    break;
                case 3:
                    strTen = "тринадцать";
                    break;
                case 4:
                    strTen = "четырнадцать";
                    break;
                case 5:
                    strTen = "пятнадцать";
                    break;
                case 6:
                    strTen = "шерстьнадцать";
                    break;
                case 7:
                    strTen = "семнадцать";
                    break;
                case 8:
                    strTen = "восемнадцать";
                    break;
                case 9:
                    strTen = "девятьнадцать";
                    break;
                default:
                    strTen = "шо-то пошло не так";
                    break;
            }
            return strTen;
        }
        public static string MakeNumber(int number)
        {
            string result;
            int dozen = HelpersForHW2.GetNumberOfDozens(number);
            if (dozen == 1)
            {
                result = HelpersForHW2.ValidateTen(number);
            }
            else
            {
                result = HelpersForHW2.ValidateDozen(number) + HelpersForHW2.ValidateUnits(number);
            }
            return result;
        }
    }
}
