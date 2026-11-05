using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Questions
{
    /*
     * 1. Two Sum
     * https://leetcode.com/problems/two-sum/description/
     * 
        You are given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.

        My Notes:
        First thought is to use nested loops.  Be sure to skip the index in the second loop
        For a faster version, the second for statement could be:
        for (int j = i + 1; j < nums.Length; j++)
        This way it doesn't need to duplicate any checks.  
            The if (j== i) continue; can be removed in that scenario

        Example 1:

        Input: nums = [2,7,11,15], target = 9

        Output: [0,1]

        Explanation:

        The sum of nums[0] and nums[1] is 2 + 7 = 9, which equals the target. Therefore, the indices [0, 1] are returned.

        Example 2:

        Input: nums = [3,2,4], target = 6

        Output: [1,2]

        Explanation:

        The sum of nums[1] and nums[2] is 2 + 4 = 6, which equals the target. Therefore, the indices [1, 2] are returned.

        Example 3:

        Input: nums = [3,3], target = 6

        Output: [0,1]

        Explanation:

        The sum of nums[0] and nums[1] is 3 + 3 = 6, which equals the target. Therefore, the indices [0, 1] are returned.

 

        Constraints:

        2 <= nums.length <= 104
        -109 <= nums[i] <= 109
        -109 <= target <= 109
        Only one valid answer exists.
 

        Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
     */
    public class _1 : IQuestionSolving
    {
        public void Solve()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var result = TwoSum(nums, target);
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i) continue;
                    if (nums[i] + nums[j] == target) return new int[] { i, j };
                }
            }
            return new int[] { };
        }
    }
}
