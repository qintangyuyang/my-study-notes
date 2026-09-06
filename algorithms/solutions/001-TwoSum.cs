// =====================================================================
// 题号：001　题目：两数之和（Two Sum）　难度：简单
// 来源：LeetCode 1
// ---------------------------------------------------------------------
// 【题目】给定一个整数数组 nums 和一个目标值 target，找出数组中两个数
//         之和等于 target 的下标。假设每个输入只有一个答案，且不能重复
//         使用同一个元素。
// 【示例】nums = [2, 7, 11, 15], target = 9 → 返回 [0, 1]（2 + 7 = 9）
// 【思路】边遍历边记录「值 → 下标」到 Dictionary，对每个数查
//         target - 当前值 是否已经出现过：出现过就找到答案。
//         用空间换时间，把暴力双层循环 O(n²) 降到 O(n)。
// 【复杂度】时间 O(n)，空间 O(n)
// 【完成日期】2026-09-06
// =====================================================================
using System;
using System.Collections.Generic;

// 已完成示例 —— 新题复制本文件结构即可
class TwoSumDemo
{
    public static void Run()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(nums, target);
        Console.WriteLine("nums = [2, 7, 11, 15], target = 9");
        Console.WriteLine("结果下标：[" + result[0] + ", " + result[1] + "]   （期望 [0, 1]）");
    }

    static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();   // key = 数值，value = 下标
        for (int i = 0; i < nums.Length; i++)
        {
            int need = target - nums[i];        // 还差多少
            if (map.ContainsKey(need))
            {
                return new[] { map[need], i };  // 之前出现过 → 找到
            }
            map[nums[i]] = i;                   // 没见过 → 记下来
        }
        return new[] { -1, -1 };                // 题目保证有解，这里兜底
    }
}
