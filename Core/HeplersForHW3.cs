using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class HeplersForHW3
    {
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
