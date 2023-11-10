using System.Runtime.CompilerServices;

namespace Codility_MaxProductOfThree
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 3;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                // Sort the array in ascending order
                Array.Sort(A);

                // The maximal product can be one of the following:
                // 1. Product of the three largest elements
                // 2. Product of the two smallest elements and the largest element
                return Math.Max(A[N - 1] * A[N - 2] * A[N - 3], A[0] * A[1] * A[N - 1]);
            }

            return int.MinValue;
        }
    }
}
