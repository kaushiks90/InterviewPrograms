using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrograms.Searching.BinarySearch
{
    //How Many times the array is rotated
    //[12,13,14,15,2,3,4]
    public class CountSortedArrayRotation
    {
        public int RotatedArrayCount(int[] arr)
        {
            int high = arr.Length - 1;
            int low = 0;
            while (low <= high)
            {
                if (arr[low] <= arr[high])
                {
                    return low;
                }
                int mid = (low + (high - low) )/ 2;
                int next = arr[mid + 1] % arr.Length - 1;
                int prev = arr[mid - 1] % arr.Length - 1;

                if (arr[mid] < arr[next] && arr[mid]<arr[prev])
                {
                    return mid;
                }
                else if (arr[mid] < arr[high])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
