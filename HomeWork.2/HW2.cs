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
            int result = HeplersForHW2.AddOrMultiplyOrDependingOnTheNumbers(a, b);
            HelpersForConsole.OutPutInConsole(1, $"{result}");
        }


        public void SolutionTask2()
        {
            int x = HelpersForConsole.GetNumberFromUser("введите координату х");
            int y = HelpersForConsole.GetNumberFromUser("введите координату у");
            int varificationResult = HeplersForHW2.FindNumberOfCoordinatePlace(x, y);

            HelpersForConsole.OutPutInConsole(2, $"{HeplersForHW2.OutPutCoordinatePlaneNumber(varificationResult)}");
        }
        

       
        public void SolutionTask3()
        {
            int a = HelpersForConsole.GetNumberFromUser("введите число а");
            int b = HelpersForConsole.GetNumberFromUser("введите число b");
            int c = HelpersForConsole.GetNumberFromUser("введите число c");
            string varificationResult = HeplersForHW2.SortVAriables(a, b, c);
            HelpersForConsole.OutPutInConsole(3, $"{varificationResult}");
        }
        
        public void SolutionTask4()
        {
            int a = HelpersForConsole.GetNumberFromUser("введите число а");
            int b = HelpersForConsole.GetNumberFromUser("введите число b");
            int c = HelpersForConsole.GetNumberFromUser("введите число c");
            double discriminant = HeplersForHW2.FindTheDiscriminant(a, b, c);
            string resultEquation = HeplersForHW2.TrustTheDiscriminant(discriminant, a, b);
            HelpersForConsole.OutPutInConsole(4, $"{resultEquation}");
        }

        public void SolutionTask5()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число ");
            int dozen = HeplersForHW2.LookingForDozen(number);
            int unit = HeplersForHW2.LookingForUnit(number);
            string result;
            if (dozen == 1)
            {
                result = HeplersForHW2.ValidateTen(number);
            }
            else
            {
                result = $"{HeplersForHW2.ValidateDozen(number)} {HeplersForHW2.ValidateUnits(number)}";
            }
            HelpersForConsole.OutPutInConsole(5, $"{result}");
        }
    }
}
