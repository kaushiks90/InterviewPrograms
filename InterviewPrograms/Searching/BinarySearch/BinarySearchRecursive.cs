namespace InterviewPrograms.Searching.BinarySearch
{
    public class BinarySearchRecursive
    {
        public int DriverFunction(int[] arr, int low, int high,int searchElement)
        {
            if (low <= high)
            {
                int mid = (low + (high - low)) / 2;
                if (arr[mid] == searchElement)
                {
                    return mid;
                }
                else if(searchElement<mid)
                {
                    return DriverFunction(arr, low, mid - 1, searchElement);
                }
                else
                {
                    return DriverFunction(arr, mid+1, high, searchElement);
                }
            }
            return -1;
        }
    }
}
