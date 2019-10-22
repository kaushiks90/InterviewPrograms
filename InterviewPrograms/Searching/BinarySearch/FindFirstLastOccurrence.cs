using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrograms.Searching.BinarySearch
{
    public class FindFirstLastOccurrence
    {
        //{1,2,3,4,4,4,5,6}
        public int FindFirstOccurrence(int[] arr,int searchElement)
        {
            int low = 0;
            int high = arr.Length - 1;
            int result = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == searchElement)
                {
                    result = mid;
                    high = mid - 1;
                }
                else if (arr[mid] < searchElement)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid + 1;
                }
            }
            return result;
        }

        public int FindLastOccurrence(int[] arr, int searchElement)
        {
            int low = 0;
            int high = arr.Length - 1;
            int result = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == searchElement)
                {
                    result = mid;
                    low = mid +1;
                }
                else if (arr[mid] < searchElement)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid + 1;
                }
            }
            return result;
        }
    }
}
