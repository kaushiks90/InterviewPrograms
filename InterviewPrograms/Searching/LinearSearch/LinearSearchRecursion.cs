namespace InterviewPrograms.Searching.LinearSearch
{
    public class LinearSearchRecursion
    {
        public int DriverFunction(int[] arr, int SearhElement,int i)
        {

            if (i>arr.Length-1)
            {
                return -1;
            }
            else if (arr[i] != SearhElement)
            {
                return DriverFunction(arr, SearhElement, i + 1);
            }
            else
            {
                return i;
            }
        }

    }
}
