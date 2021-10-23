using Core;
using System;

namespace HomeWork._5
{
    public class HW5
    {
        public void SolutionTask1()
        {
            int countStrings = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество строк"));
            int countColumns = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество столбцов"));
            int[,] array = new int[countStrings, countColumns];
            WorkingWithArrayTwoDim.FillingRandomTwoDimArray(array);
            HelpersForConsole.ShowAnExistingArray(array);
            int minElement = WorkingWithArrayTwoDim.GetMinElementInArray(array);
            HelpersForConsole.OutPutInConsole(1, $"{minElement}");
        }

       

        public void SolutionTask2()
        {
            int countStrings = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество строк"));
            int countColumns = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество столбцов"));
            int[,] array = new int[countStrings, countColumns];
            WorkingWithArrayTwoDim.FillingRandomTwoDimArray(array);
            HelpersForConsole.ShowAnExistingArray(array);
            int maxElement = WorkingWithArrayTwoDim.GetMaxElementInArray(array);
            HelpersForConsole.OutPutInConsole(2, $"{maxElement}");
        }

        public void SolutionTask3()
        {
            int countStrings = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество строк"));
            int countColumns = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество столбцов"));
            int[,] array = new int[countStrings, countColumns];
            WorkingWithArrayTwoDim.FillingRandomTwoDimArray(array);
            HelpersForConsole.ShowAnExistingArray(array);
            HelpersForConsole.OutPutInConsole(3, $" {WorkingWithArrayTwoDim.GetIndexMinElementInArray(array)}");
        }

        public void SolutionTask4()
        {
            int countStrings = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество строк"));
            int countColumns = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество столбцов"));
            int[,] array = new int[countStrings, countColumns];
            WorkingWithArrayTwoDim.FillingRandomTwoDimArray(array);
            HelpersForConsole.ShowAnExistingArray(array);            
            HelpersForConsole.OutPutInConsole(3, $" {WorkingWithArrayTwoDim.GetIndexMaxElementInArray(array)}");
        }

        public void SolutionTask5()
        {
            int countStrings = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество строк"));
            int countColumns = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество столбцов"));
            int[,] array = new int[countStrings, countColumns];
            WorkingWithArrayTwoDim.FillingRandomTwoDimArray(array);
            HelpersForConsole.ShowAnExistingArray(array);
            int countMax = WorkingWithArrayTwoDim.ElemtntHasMoreNeighbors(array);
            HelpersForConsole.OutPutInConsole(5, $"{countMax}");
        }
       
        public void SolutionTask6()
        {
            int countStrings = int.Parse(HelpersForConsole.GetNumberFromUser("Введите количество строк/столбцов"));
            int countColumns = countStrings;
            int[,] array = new int[countStrings, countColumns];
            WorkingWithArrayTwoDim.FillingRandomTwoDimArray(array);
            HelpersForConsole.ShowAnExistingArray(array);
            WorkingWithArrayTwoDim.SwapElementsRelativeToMainDiagonal(array);
            HelpersForConsole.OutPutInConsole(6, " ");
            HelpersForConsole.ShowAnExistingArray(array);
        }

    }
}
