using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class TESTS
    {
        public List<int> CreateList(List<int> numberList,int longht, Random number)
        {
            for (int i = 0; i < longht; i++)
            {
                int num = number.Next(1, 1000001);
                numberList.Add(num);
            }
            return numberList;
        }

        public void setMatrix(List<int> original, List<List<int>> M)
        {
            List<int> bubbleSort = new List<int>(original);
            List<int> insertionSort = new List<int>(original);
            List<int> mergeSort = new List<int>(original);
            List<int> quickSortL = new List<int>(original);
            List<int> quickSortH = new List<int>(original);
            List<int> linqSort = new List<int>(original);
            M.Add(bubbleSort);
            M.Add(insertionSort);
            M.Add(mergeSort);
            M.Add(quickSortL);
            M.Add(quickSortH);
            M.Add(linqSort);
        }
        public void Excecute(Sort sort, List<int> bubbleSort, List<int> insertionSort, List<int> mergeSort, List<int> quickSortL, List<int> quickSortH, List<int> linqSort, int Corrida, int longht)
        {
            Console.WriteLine("Prueba de tiempo de respuesta de los algoritmos n. " + Corrida.ToString()+"\nLargo de lista a prueba: " + longht.ToString() + "\n");
            double bubbleTime = sort.BubbleSort(bubbleSort);
            Console.WriteLine("Bubblesort time: " + bubbleTime + " milliseconds");

            double insertionTime = sort.InsertionSort(insertionSort);
            Console.WriteLine("Insertionsort time: " + insertionTime + " milliseconds");

            double mergeTime = sort.MergeSortInit(mergeSort);
            Console.WriteLine("Mergesort time: " + mergeTime + " milliseconds");

            double quickTimeL = sort.QuickSort(quickSortL, true);
            Console.WriteLine("Quicksort Lomuto time: " + quickTimeL + " milliseconds");

            double quickTimeH = sort.QuickSort(quickSortH, false);
            Console.WriteLine("Quicksort Hoare time: " + quickTimeH + " milliseconds");

            double listTime = sort.LinqSort(linqSort);
            Console.WriteLine("C# listsort time: " + listTime + " milliseconds");

            Console.WriteLine("--------------------------------------------------\n");
        }

    }


}
