using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Sorting
    {
        public void BubbleSort(int[] array)
        {
            // Outer loop - wall - iterate backwards starting from the end.

            for (int wall = array.Length - 1; wall > 0; wall--)
            {
                for (int i = 0; i < wall; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
