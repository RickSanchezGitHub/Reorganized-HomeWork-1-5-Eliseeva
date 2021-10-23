using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class WorkingForNmbers
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
        // Домашка 2 начинается тють
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
            if (x > 0 && y > 0)
            {
                quarterNumber = 1;
            }
            else if (x < 0 && y > 0)
            {
                quarterNumber = 2;
            }
            else if (x < 0 && y < 0)
            {
                quarterNumber = 3;
            }
            else if (x > 0 && y < 0)
            {
                quarterNumber = 4;
            }
            else
            {
                quarterNumber = 0;
            }
            return quarterNumber;
        }
        public static string OutPutCoordinatePlaneNumber(int quarterNumber)
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
                default:
                    strQuarter = "точка находится на координатных осях";
                    break;
            }
            return strQuarter;
        }
        public static string SortVAriables(int a, int b, int c)
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
        public static string TrustTheDiscriminant(double discriminant, int a, int b)
        {
            string resultEquation;
            if (discriminant > 0)
            {
                resultEquation = SolutionIfDscrGreaterThanZero(discriminant, a, b);
            }
            else if (discriminant == 0)
            {
                resultEquation = SolutionIfDscrIsZero(discriminant, a, b);
            }
            else
            {
                resultEquation = SolutionIfDscrLessThanZero(discriminant, a);
            }
            return resultEquation;
        }
        public static  double FindTheDiscriminant(int a, int b, int c)
        {
            double discriminant = Math.Pow(b, 2) - (4 * a * c);
            return discriminant;
        }
        public static string SolutionIfDscrLessThanZero(double discriminant, int a)
        {
            string result = "Данное решение находится за пределами вашего понимания, так как D < 0";
            return result;
        }
        public static string SolutionIfDscrIsZero(double discriminant, int a, int b)
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
        public static int LookingForDozen(int number)
        {
            int result = number / 10;
            return result;
        }
        public static  int LookingForUnit(int number)
        {
            int result = number % 10;
            return result;
        }
        public static string ValidateUnits(int number)
        {
            int unit = LookingForUnit(number);
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
            int dozen = LookingForDozen(number);
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
            int unit = LookingForUnit(number);
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
        // здеся начинается домашка под номером 3
        public static int CalcPow(int number, int power)
        {
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result = result * number;
            }
            return result;
        }
        public static int SearchForNumbersDivisibleByNumber(int number, int i)
        {
            int result = 1;
            if (i % number == 0)
            {
                result = i;
            }
            return result;
        }
        public static int GetCountNumbersWhoseSquareLessThanNumber(int number)
        {
            int count = 0;
            while (count * count < number)
            {
                count++;
            }
            return count;
        }
        public static int GetLargestDivisor(int number)
        {
            int count = 0;
            int result = 1;
            do
            {
                count++;
                if (number % count == 0 && count != number)
                {
                    result = count;
                }
            }
            while (count < number);
            return result;
        }
        public static int GetCountOfNumbersDivisibleBySevenWithinRange(int startRange, int endRange)
        {
            int count = Math.Min(startRange, endRange);
            int result = 0;
            while (count < Math.Max(startRange, endRange))
            {
                if (count % 7 == 0)
                {
                    result = result + count;
                }
                count++;
            }
            return count;
        }
        public static int NumberOfFibonacciSeries(int fibonachiN)
        {
            int count = 2;
            int odd = 1; // нечетное слогаемое
            int even = 1; // четное слагаемое
            if (fibonachiN <= 2)
            {
                return odd;
            }
            else
            {
                do
                {
                    if (count % 2 != 0)
                    {
                        even = odd + even; // четные члены последовательности
                        count++;
                    }
                    else
                    {
                        odd = odd + even; // нечетные члены последовательности
                        count++;
                    }
                }
                while (count < fibonachiN);

                if (count % 2 == 0)
                {
                    return even;
                }
                else
                {
                    return odd;
                }
            }
        }
        public static int GetGreatestCommonDivisor(int number1, int number2)
        {
            while (number1 != 0 && number2 != 0)
            {
                if (number1 < number2)
                {
                    number2 = number2 % number1;
                }
                else
                {
                    number1 = number1 % number2;
                }
            }
            int result = number1 + number2;
            return result;
        }
        public static double GetNumberByMethodOfHalfDivision(int number)
        {
            double min = 0;
            double max = number;
            double centre = number / 2;
            double length = number;
            bool flag = false;
            double resultMethod = 0;

            while (!flag)
            {
                if (Math.Pow(centre, 3) > number)
                {
                    max = centre;
                    length = max - min;
                    centre = min + length / 2;

                }
                else
                {
                    min = centre;
                    length = max - min;
                    centre = min + length / 2;
                }
                double result = Math.Pow(centre, 3);
                if ((number >= result && number - result < 0.0000000000001) || (number <= result && result - number < 0.0000000000001))
                {
                    flag = true;
                    resultMethod = centre;
                }
            }
            return resultMethod;
        }
        public static int GetQuantityOddDigits(int number)
        {
            int count = 0;
            while (number != 0)
            {
                int unit = number % 10;
                if (unit % 2 != 0)
                {
                    count++;
                }
                number /= 10;
            }
            return count;
        }
        public static int MirrorNumber(int number)
        {
            int unnumber = 0;
            while (number != 0)
            {
                int unit = number % 10;
                number /= 10;
                unnumber = unnumber * 10 + unit;
            }
            return unnumber;
        }
        public static void ShowNumberSumOfEvenGreaterThanSumOfOdd(int number)
        {
            int count = 1;
            while (count < number)
            {
                int numberCount = FindNumberSumOfEvenGreaterThanSumOfOdd(count);
                Console.WriteLine(numberCount);
                count++;
            }

        }
         private static int FindNumberSumOfEvenGreaterThanSumOfOdd(int count)
        {
            int unit;
            int oddSum = 0;
            int evenSum = 0;
            int countif = count;
            while (countif != 0)
            {
                unit = countif % 10;
                if (unit % 2 != 0)
                {
                    oddSum = +unit;
                }
                else
                {
                    evenSum = +unit;
                }
                countif /= 10;
            }
            if (oddSum < evenSum)
            {
                return count;
            }
            else
            {
                return countif;
            }
         }
        public static void CheckIdenticalDigistInNumbers(int number1, int number2)
        {
            bool fleg = false;
            int count1 = 0;
            int cloneNumber1 = 0;
            int cloneNumber2 = 0;
            int count2 = 0;
            cloneNumber1 = number1;
            cloneNumber2 = number2;

            do
            {
                count1 = cloneNumber1 % 10;
                cloneNumber1 /= 10;
                cloneNumber2 = number2;
                do
                {
                    count2 = cloneNumber2 % 10;
                    cloneNumber2 /= 10;

                    if (count1 == count2)
                    {
                        fleg = true;
                        break;
                    }
                }
                while (cloneNumber2 != 0);
            }
            while (cloneNumber1 != 0);

            if (fleg)
            {
                Console.WriteLine("Yes, you are WIN");
            }
            else
            {
                Console.WriteLine("no, you are dead");
            }
        }
    }
}
