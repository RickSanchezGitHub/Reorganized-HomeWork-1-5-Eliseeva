using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork._3
{
    public class HW3
    {
        public void SolutionTask1()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число ");
            int power = HelpersForConsole.GetNumberFromUser("введите степень");
            int result = HeplersForHW3.CalcPow(number, power);
            HelpersForConsole.OutPutInConsole(1, $"{result}");
        }

        public void SolutionTask2()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число");
            HelpersForConsole.OutPutInConsole(2, $" ");
            for (int i = 1; i <= 1000; i++)
            {
                int index = HeplersForHW3.SearchForNumbersDivisibleByNumber(number, i);
                Console.WriteLine(index);
            }
        }

        public void SolutionTask3()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число");
            int result = HeplersForHW3.GetCountNumbersWhoseSquareLessThanNumber(number);
            HelpersForConsole.OutPutInConsole(3, $"{result}");
        }

        public void SolutionTask4()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число");
            int result = HeplersForHW3.GetLargestDivisor(number);
            HelpersForConsole.OutPutInConsole(4, $"{result}");
        }

        public void SolutionTask5()
        {
            int startRange = HelpersForConsole.GetNumberFromUser("введите число a");
            int endRange = HelpersForConsole.GetNumberFromUser("введите число b");
            int result = HeplersForHW3.GetCountOfNumbersDivisibleBySevenWithinRange(startRange, endRange);
            HelpersForConsole.OutPutInConsole(5, $"{result}");
        }

        public void SolutionTask6()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число");
            int result = HeplersForHW3.NumberOfFibonacciSeries(number);
            HelpersForConsole.OutPutInConsole(6, $"{result}");
        }
        
        public void SolutionTask7()
        {
            int number1 = HelpersForConsole.GetNumberFromUser("введите первое число");
            int number2 = HelpersForConsole.GetNumberFromUser("введите второе число");
            int result = HeplersForHW3.GetGreatestCommonDivisor(number1, number2);
            HelpersForConsole.OutPutInConsole(7, $"{result}");
        }
       
        public void SolutionTask8()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите первое число");
            double result = HeplersForHW3.GetNumberByMethodOfHalfDivision(number);
            HelpersForConsole.OutPutInConsole(8, $"{result}");
        }
        
        public void SolutionTask9()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите первое число");
            int count = HeplersForHW3.GetQuantityOddDigits(number);
            HelpersForConsole.OutPutInConsole(9, $"{count}");
        }
        
        public void SolutionTask10()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите  число");
            int result = HeplersForHW3.MirrorNumber(number);
            HelpersForConsole.OutPutInConsole(10, $"{result}");
        }

        public void SolutionTask11()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите  число");
            HelpersForConsole.OutPutInConsole(11, $" ");
            HeplersForHW3.ShowNumberSumOfEvenGreaterThanSumOfOdd(number);

        }

        public void SolutionTask12()
        {
            int number1 = HelpersForConsole.GetNumberFromUser("Введите первое число: ");
            int number2 = HelpersForConsole.GetNumberFromUser("Введите второе число: ");
            HelpersForConsole.OutPutInConsole(12, " ");
            HeplersForHW3.CheckIdenticalDigistInNumbers(number1, number2);
        }
        
    }
}
