using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrograms.Searching.BinarySearch
{
    //{1,2,3,4,4,4,5,6}
    //4 occurs 3 times
    public class CountOccurrenceofNumber
    {
        public int TotalOccurrances(int[] arr, int searchElement)
        {
            FindFirstLastOccurrence obj = new FindFirstLastOccurrence();
            int firstElement = obj.FindFirstOccurrence(arr, searchElement);
            int lastElement = obj.FindLastOccurrence(arr, searchElement);
            return lastElement - firstElement + 1;
        }
    }
}
