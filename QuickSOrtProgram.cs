using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class QuickSOrtProgram
    {
        static public int Partition(int[] arrayObjs, int left, int right)
        {

            int pivot = arrayObjs[left];
            int pivotIndex = left;

            while (left < right)
            {
                while (arrayObjs[left] <= pivot && left < right)
                    left++;

                while (arrayObjs[right] > pivot)
                    right--;


                if (left < right)
                {
                    int temp = arrayObjs[right];

                    arrayObjs[right] = arrayObjs[left];

                    arrayObjs[left] = temp;
                }
                else
                {
                    int temp = arrayObjs[right];

                    arrayObjs[right] = arrayObjs[pivotIndex];

                    arrayObjs[pivotIndex] = temp;

                    return right;
                }

            }

            return right;
        }



        static public void SortQuick(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);

                if (pivotIndex > 1)
                    SortQuick(arr, left, pivotIndex - 1);

                if (pivotIndex + 1 < right)
                    SortQuick(arr, pivotIndex + 1, right);
            }
        }



        static void Main(string[] args)
        {

            Console.WriteLine("\nProgram for sorting a numeric array using Quick Sorting");
            Console.Write("\nEnter number of Array Items: ");

            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nQuickSort Output:");

            SortQuick(numbers, 0, max - 1);

            for (int i = 0; i < max; i++)
                Console.WriteLine(numbers[i]);

            Console.ReadLine();

        }
    }
}
