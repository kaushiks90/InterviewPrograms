using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrograms.Searching.BinarySearch
{
    public class SearchElementinSortedArray
    {
        public int SearchinSortedArray(int [] arr,int searchElement)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (searchElement == arr[mid])
                {
                    return mid;
                }
                if (arr[mid] <= arr[high])
                {
                    if(searchElement>arr[mid] && searchElement <= arr[high])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
                else
                {
                    if(arr[low]<=searchElement && searchElement < arr[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }
            return -1;
        }
    }
}
