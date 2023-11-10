# Codility-MaxProductOfThree
A non-empty array A consisting of N integers is given.</br> 
The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R] (0 ≤ P < Q < R < N).

For example, array A such that:</br> 
A[0] = -3</br> 
A[1] = 1</br> 
A[2] = 2</br> 
A[3] = -2</br> 
A[4] = 5</br> 
A[5] = 6</br> 
contains the following example triplets:</br> 
(0, 1, 2), product is −3 * 1 * 2 = −6</br> 
(1, 2, 4), product is 1 * 2 * 5 = 10</br> 
(2, 4, 5), product is 2 * 5 * 6 = 60</br> 
Your goal is to find the maximal product of any triplet.

Write a function:</br> 
class Solution { public int solution(int[] A); }</br> 
that, given a non-empty array A, returns the value of the maximal product of any triplet.

For example, given array A such that:</br> 
A[0] = -3</br> 
A[1] = 1</br> 
A[2] = 2</br> 
A[3] = -2</br> 
A[4] = 5</br> 
A[5] = 6</br> 
the function should return 60, as the product of triplet (2, 4, 5) is maximal.

Write an efficient algorithm for the following assumptions:</br> 
N is an integer within the range [3..100,000];</br> 
each element of array A is an integer within the range [−1,000..1,000].
