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
            int result = WorkingForNmbers.AddOrMultiplyOrDependingOnTheNumbers(a, b);
            HelpersForConsole.OutPutInConsole(1, $"{result}");
        }


        public void SolutionTask2()
        {
            int x = HelpersForConsole.GetNumberFromUser("введите координату х");
            int y = HelpersForConsole.GetNumberFromUser("введите координату у");
            int varificationResult = WorkingForNmbers.FindNumberOfCoordinatePlace(x, y);

            HelpersForConsole.OutPutInConsole(2, $"{WorkingForNmbers.OutPutCoordinatePlaneNumber(varificationResult)}");
        }
        

       
        public void SolutionTask3()
        {
            int a = HelpersForConsole.GetNumberFromUser("введите число а");
            int b = HelpersForConsole.GetNumberFromUser("введите число b");
            int c = HelpersForConsole.GetNumberFromUser("введите число c");
            string varificationResult = WorkingForNmbers.SortVAriables(a, b, c);
            HelpersForConsole.OutPutInConsole(3, $"{varificationResult}");
        }
        
        public void SolutionTask4()
        {
            int a = HelpersForConsole.GetNumberFromUser("введите число а");
            int b = HelpersForConsole.GetNumberFromUser("введите число b");
            int c = HelpersForConsole.GetNumberFromUser("введите число c");
            double discriminant = WorkingForNmbers.FindTheDiscriminant(a, b, c);
            string resultEquation = WorkingForNmbers.TrustTheDiscriminant(discriminant, a, b);
            HelpersForConsole.OutPutInConsole(4, $"{resultEquation}");
        }

        public void SolutionTask5()
        {
            int number = HelpersForConsole.GetNumberFromUser("введите число ");
            int dozen = WorkingForNmbers.LookingForDozen(number);
            int unit = WorkingForNmbers.LookingForUnit(number);
            string result;
            if (dozen == 1)
            {
                result = WorkingForNmbers.ValidateTen(number);
            }
            else
            {
                result = $"{WorkingForNmbers.ValidateDozen(number)} {WorkingForNmbers.ValidateUnits(number)}";
            }
            HelpersForConsole.OutPutInConsole(5, $"{result}");
        }
    }
}
