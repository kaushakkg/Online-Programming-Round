using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class FindMissingItem
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nProgram for find missing number between 1 and 100 in an arrary");
            Console.Write("\nEnter number of Array Items: ");

            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

                Console.WriteLine("\nMissing No. Between 1 and 100 Output:\n");

            int[] forSearch = Enumerable.Range(1, 100).ToArray();
            int[] missingItems = forSearch.Except(numbers).ToArray();

            for (int i = 0; i < missingItems.Count(); i++)
                Console.Write(missingItems[i].ToString()+", ");

            Console.ReadLine();

        }
    }
}
