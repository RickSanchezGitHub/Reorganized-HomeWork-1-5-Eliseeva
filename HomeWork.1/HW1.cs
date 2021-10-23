using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class HW1
    {
        public void SolutionTask1 ()
        {
            int number1 = HelpersForConsole.GetNumberFromUser("введите число а");
            int number2 = HelpersForConsole.GetNumberFromUser("введите число b");
            double result = WorkingForNmbers.CalcFormula(number1, number2);
            HelpersForConsole.OutPutInConsole(1, $"{result}");
        }


        public void SolutionTask2()
        {
            string  strA = Convert.ToString(HelpersForConsole.GetNumberFromUser("Введите знвчение а"));
            string  strB = Convert.ToString(HelpersForConsole.GetNumberFromUser("Введите знвчение b"));
            HelpersForConsole.OutPutInConsole(2, $" ");
            WorkingForNmbers.SwapStrings(ref strA, ref strB);
        }

        public void SolutionTask3()
        {
            int number1 = HelpersForConsole.GetNumberFromUser("введите число а");
            int number2 = HelpersForConsole.GetNumberFromUser("введите число b");
            int resultDivision = WorkingForNmbers.DivideTheNumber(number1, number2);
            int resultRemains = WorkingForNmbers.RemainderOfDivisionOfNumber(number1, number2);
            HelpersForConsole.OutPutInConsole(3, $"{resultDivision} {resultRemains}");
        }

        public void SolutionTask4()
        {
            int a = HelpersForConsole.GetNumberFromUser("введите число а");
            int b = HelpersForConsole.GetNumberFromUser("введите число b");
            int c = HelpersForConsole.GetNumberFromUser("введите число c");
            double x = SolveLinearEquation(a, b, c);
            HelpersForConsole.OutPutInConsole(4, $" x = {x}");

        }
        private double SolveLinearEquation(int a, int b, int c)
        {
            double resulrX = (c - b) / a;
            return resulrX;
        }
        public void SolutionTask5()
        {
            int x1 = HelpersForConsole.GetNumberFromUser("введите координату х1");
            int y1 = HelpersForConsole.GetNumberFromUser("введите координату у1");
            int x2 = HelpersForConsole.GetNumberFromUser("введите координату х2");
            int y2 = HelpersForConsole.GetNumberFromUser("введите координату y2");
            double k = WorkingForNmbers.CalcCoefficientOfEquationK(x1, y1, x2, y2);
            double b = WorkingForNmbers.CalcCoefficientOfEquationB(x1, y1, x2, y2);
            HelpersForConsole.OutPutInConsole(5, $"Y ={k}X+{b}");
        } 
    }
}
