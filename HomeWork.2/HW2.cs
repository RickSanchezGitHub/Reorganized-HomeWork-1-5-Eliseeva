using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork._2
{
    public class HW2
    {
        public void SolutionTask1()
        {
            int a = HelpersForConsole.GetNumberFromUser("введите число а");
            int b = HelpersForConsole.GetNumberFromUser("введите число b");
            int result = HelpersForHW2.AddOrMultiplyOrDependingOnTheNumbers(a, b);
            HelpersForConsole.OutPutInConsole(1, $"{result}");
        }


        public void SolutionTask2()
        {
            int x = HelpersForConsole.GetNumberFromUser("введите координату х");
            int y = HelpersForConsole.GetNumberFromUser("введите координату у");
            int varificationResult = HelpersForHW2.FindNumberOfCoordinatePlace(x, y);

            HelpersForConsole.OutPutInConsole(2, $"{HelpersForHW2.OutPutCoordinatePlaneNumberForConsole(varificationResult)}");
        }
        

       
        public void SolutionTask3()
        {
            int a = HelpersForConsole.GetNumberFromUser("введите число а");
            int b = HelpersForConsole.GetNumberFromUser("введите число b");
            int c = HelpersForConsole.GetNumberFromUser("введите число c");
            string varificationResult = HelpersForHW2.SortVariables(a, b, c);
            HelpersForConsole.OutPutInConsole(3, $"{varificationResult}");
        }
        
        public void SolutionTask4()
        {
            int a = HelpersForConsole.GetNumberFromUser("введите число а");
            int b = HelpersForConsole.GetNumberFromUser("введите число b");
            int c = HelpersForConsole.GetNumberFromUser("введите число c");
            int discriminant = HelpersForHW2.FindTheDiscriminant(a, b, c);
            string resultEquation = HelpersForHW2.TestingOfDiscriminant(discriminant, a, b);
            HelpersForConsole.OutPutInConsole(4, $"{resultEquation}");
        }

        public void SolutionTask5()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число ");
            string result = HelpersForHW2.MakeNumber(number);
            HelpersForConsole.OutPutInConsole(5, $"{result}");
        }
    }
}
