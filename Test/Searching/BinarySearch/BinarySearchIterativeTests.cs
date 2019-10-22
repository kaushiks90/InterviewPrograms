using InterviewPrograms.Searching.BinarySearch;
using Xunit;

namespace UnitTest.Searching.BinarySearch
{
    public class BinarySearchIterativeTests
    {
        [Fact]
        [InlineData(new int[] { 1,2,3,4,5},1)]
        public void DriverFunction_Should_Return_ValidResult()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int searchElement = 4;
            BinarySearchIterative bb = new BinarySearchIterative();
            int res = bb.DriverFunction(arr, searchElement);
            Assert.Equal(4, res);
        }

        [Fact]
        public void DriverFunction_Should_Return_NegativeOne()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int searchElement = 0;
            BinarySearchIterative bb = new BinarySearchIterative();
            int res = bb.DriverFunction(arr, searchElement);
            Assert.Equal(-1, res);
        }
    }
}
