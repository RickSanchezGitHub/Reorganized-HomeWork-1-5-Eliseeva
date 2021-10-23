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
            int result = WorkingForNmbers.CalcPow(number, power);
            HelpersForConsole.OutPutInConsole(1, $"{result}");
        }

        public void SolutionTask2()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число");
            HelpersForConsole.OutPutInConsole(2, $" ");
            for (int i = 1; i <= 1000; i++)
            {
                int index = WorkingForNmbers.SearchForNumbersDivisibleByNumber(number, i);
                Console.WriteLine(index);
            }
        }

        public void SolutionTask3()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число");
            int result = WorkingForNmbers.GetCountNumbersWhoseSquareLessThanNumber(number);
            HelpersForConsole.OutPutInConsole(3, $"{result}");
        }

        public void SolutionTask4()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число");
            int result = WorkingForNmbers.GetLargestDivisor(number);
            HelpersForConsole.OutPutInConsole(4, $"{result}");
        }

        public void SolutionTask5()
        {
            int startRange = HelpersForConsole.GetNumberFromUser("введите число a");
            int endRange = HelpersForConsole.GetNumberFromUser("введите число b");
            int result = WorkingForNmbers.GetCountOfNumbersDivisibleBySevenWithinRange(startRange, endRange);
            HelpersForConsole.OutPutInConsole(5, $"{result}");
        }

        public void SolutionTask6()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число");
            int result = WorkingForNmbers.NumberOfFibonacciSeries(number);
            HelpersForConsole.OutPutInConsole(6, $"{result}");
        }
        
        public void SolutionTask7()
        {
            int number1 = HelpersForConsole.GetNumberFromUser("введите первое число");
            int number2 = HelpersForConsole.GetNumberFromUser("введите второе число");
            int result = WorkingForNmbers.GetGreatestCommonDivisor(number1, number2);
            HelpersForConsole.OutPutInConsole(7, $"{result}");
        }
       
        public void SolutionTask8()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите первое число");
            double result = WorkingForNmbers.GetNumberByMethodOfHalfDivision(number);
            HelpersForConsole.OutPutInConsole(8, $"{result}");
        }
        
        public void SolutionTask9()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите первое число");
            int count = WorkingForNmbers.GetQuantityOddDigits(number);
            HelpersForConsole.OutPutInConsole(9, $"{count}");
        }
        
        public void SolutionTask10()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите  число");
            int result = WorkingForNmbers.MirrorNumber(number);
            HelpersForConsole.OutPutInConsole(10, $"{result}");
        }

        public void SolutionTask11()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите  число");
            HelpersForConsole.OutPutInConsole(11, $" ");
            WorkingForNmbers.ShowNumberSumOfEvenGreaterThanSumOfOdd(number);

        }

        public void SolutionTask12()
        {
            int number1 = HelpersForConsole.GetNumberFromUser("Введите первое число: ");
            int number2 = HelpersForConsole.GetNumberFromUser("Введите второе число: ");
            HelpersForConsole.OutPutInConsole(12, " ");
            WorkingForNmbers.CheckIdenticalDigistInNumbers(number1, number2);
        }
        
    }
}
