using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Questions
{
    /*
        You are given an integer array nums.

        In one move, you may increase the value of any single element nums[i] by 1.

        Return the minimum total number of moves required so that all elements in nums become equal.

        My notes:
        Since we can only increase each digit, need to find the max element and then increase each one by 1 to get to max and count how many times
        Can subtract max - element to get total
        My solution was slower than others.  LINQ has additional overhead.  I could have done this to get max:
            int max = int.MinValue;
            foreach(int num in nums) {
                max = Math.Max(max, num);
            }

        Example 1:

        Input: nums = [2,1,3]

        Output: 3

        Explanation:

        To make all elements equal:

        Increase nums[0] = 2 by 1 to make it 3.
        Increase nums[1] = 1 by 1 to make it 2.
        Increase the updated nums[1] = 2 by 1 to make it 3.
        Now, all elements of nums are equal to 3. The minimum total moves is 3.

        Example 2:

        Input: nums = [4,4,5]

        Output: 2

        Explanation:

        To make all elements equal:

        Increase nums[0] = 4 by 1 to make it 5.
        Increase nums[1] = 4 by 1 to make it 5.
        Now, all elements of nums are equal to 5. The minimum total moves is 2.



        Constraints:

        1 <= nums.length <= 100
        1 <= nums[i] <= 100         
     */

    public class _3736 : IQuestionSolving
    {
        public void Solve()
        {
            var arr1 = new int[] { 4, 4, 5 };
            var result = MinMoves(arr1);
            Console.WriteLine(result);
        }

        public int MinMoves(int[] nums)
        {
            var max = nums.Max();
            var moves = 0;
            foreach (int i in nums)
                moves += max - i;
            return moves;
        }
    }
}
