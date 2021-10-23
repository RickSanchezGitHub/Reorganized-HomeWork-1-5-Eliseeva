using Core;
using System;

namespace HomeWork._4
{
    public class HW4
    {

        public void SolutionTask1()
        {
            int length = HelpersForConsole.GetNumberFromUser("Введите длину массива");
            int[] array = new int[length];
            WorkingWithArrayOneDim.FillingRandomAnOneDimArray(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
            int result = WorkingWithArrayOneDim.GetMinArrayElement(array);
            HelpersForConsole.OutPutInConsole(1, $"{result}");
        }
       
        public void SolutionTask2()
        {
            int length = HelpersForConsole.GetNumberFromUser("Введите длину массива");
            int[] array = new int[length];
            WorkingWithArrayOneDim.FillingRandomAnOneDimArray(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
            int result =WorkingWithArrayOneDim.GetMaxArrayElement(array);
            HelpersForConsole.OutPutInConsole(2, $"{result}");
        }
        
        public void SolutionTask3()
        {
            int length = HelpersForConsole.GetNumberFromUser("Введите длину массива");
            int[] array = new int[length];
            WorkingWithArrayOneDim.FillingRandomAnOneDimArray(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
            int indexMin = WorkingWithArrayOneDim.GetIndexMinArrayElement(array);
            HelpersForConsole.OutPutInConsole(3, $"{indexMin}");
        }

        public void SolutionTask4()
        {
            int length = HelpersForConsole.GetNumberFromUser("Введите длину массива");
            int[] array = new int[length];
            WorkingWithArrayOneDim.FillingRandomAnOneDimArray(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
            int indexMaxElement = WorkingWithArrayOneDim.GetIndexMaxArrayElemen(array);
            HelpersForConsole.OutPutInConsole(4, $"{indexMaxElement}");
        }

        public void SolutionTask5()
        {
            int length = HelpersForConsole.GetNumberFromUser("Введите длину массива");
            int[] array = new int[length];
            WorkingWithArrayOneDim.FillingRandomAnOneDimArray(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
            int countOddElements = WorkingWithArrayOneDim.CountArrayElementsWithOddIndex(array);
            HelpersForConsole.OutPutInConsole(5, $"{countOddElements}");
        }
       
        public void SolutionTask6()
        {
            int length = HelpersForConsole.GetNumberFromUser("Введите длину массива");
            int[] array = new int[length];
            WorkingWithArrayOneDim.FillingRandomAnOneDimArray(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
            WorkingWithArrayOneDim.ArrayReverse(array);
            HelpersForConsole.OutPutInConsole(6, $" ");
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
        }        
        public void SolutionTask7()
        {
            int length = HelpersForConsole.GetNumberFromUser("Введите длину массива");
            int[] array = new int[length];
            WorkingWithArrayOneDim.FillingRandomAnOneDimArray(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
            int countOddElements = WorkingWithArrayOneDim.CountArrayElementsWithOddIndex(array);
            HelpersForConsole.OutPutInConsole(7, $"{countOddElements}");
        }

        public void SolutionTask8() 
        {
            int length = HelpersForConsole.GetNumberFromUser("Введите длину массива");
            int[] array = new int[length];
            WorkingWithArrayOneDim.FillingRandomAnOneDimArray(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
            HelpersForConsole.OutPutInConsole(8, $" ");
            WorkingWithArrayOneDim.SwapHalvesOfArrayInPlaces(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
        }

        public void SolutionTask9()
        {
            int length = HelpersForConsole.GetNumberFromUser("Введите длину массива");
            int[] array = new int[length];
            WorkingWithArrayOneDim.FillingRandomAnOneDimArray(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
            HelpersForConsole.OutPutInConsole(9, $" ");
            WorkingWithArrayOneDim.SortArrayByAscendingSelection(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
        }
        public void SolutionTask10()
        {
            int length = HelpersForConsole.GetNumberFromUser("Введите длину массива");
            int[] array = new int[length];
            WorkingWithArrayOneDim.FillingRandomAnOneDimArray(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
            HelpersForConsole.OutPutInConsole(10, $" ");
            WorkingWithArrayOneDim.SortArrayByBubbleInDescerdingOrder(array);
            HelpersForConsole.OutPutOneDimArrayToConsole(array);
        }
    }
}
