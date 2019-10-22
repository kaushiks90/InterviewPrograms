using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrograms.Searching.BinarySearch
{
   public class BinarySearchIterative
    {
        public int DriverFunction(int[] arr, int searchElement)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (searchElement == arr[mid])
                {
                    return mid+1;
                }
                else if (searchElement > arr[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
