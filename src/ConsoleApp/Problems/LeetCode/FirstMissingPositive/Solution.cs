﻿namespace ConsoleApp.Problems.LeetCode.FirstMissingPositive;

public class Solution
{
    public int Solve(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (num <= 0 || num > nums.Length)
            {
                nums[i] = 0;
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            var value = Math.Abs(nums[i]);
            if (value > 0)
            {
                nums[value - 1] = nums[value - 1] == 0 ? -value : -Math.Abs(nums[value - 1]);
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > -1)
            {
                return i + 1;
            }
        }

        return nums.Length + 1;
    }
}