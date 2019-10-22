using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrograms.Searching.LinearSearch
{
    public class LinearSearchIterative
    {
        public int DriverFunction(int[] arr,int SearhElement)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == SearhElement)
                {
                    return i;
                }

            }
            return -1;
        }
    }
}
