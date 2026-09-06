// =====================================================================
// LC 167 · Two Sum II - Input Array Is Sorted（两数之和 II）· 中等
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定升序数组 numbers 和目标值 target，找出和等于 target 的两个数，
//         返回它们的下标（下标从 1 开始）。不能重复使用同一个元素。
// 【示例】numbers=[2,7,11,15], target=9 → [1, 2]
// =====================================================================
using System;

class TwoSumIIDemo
{
    public static void Run()
    {
        int[] numbers = { 2, 7, 11, 15 };
        int[] result = TwoSum(numbers, 9);
        Console.WriteLine("numbers=[2,7,11,15], target=9 → [" + result[0] + ", " + result[1] + "]（期望 [1, 2]，下标从 1 开始）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前返回 [-1, -1]——打开本文件实现 TODO）");
    }

    // TODO：实现 TwoSum——数组已升序，返回 1 起始的两个下标
    static int[] TwoSum(int[] numbers, int target)
    {
        return new[] { -1, -1 };   // 占位，实现后删除
    }
}
