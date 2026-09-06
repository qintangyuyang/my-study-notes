// =====================================================================
// LC 219 · Contains Duplicate II（存在重复元素 II）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定数组 nums 和整数 k，是否存在两个不同的下标 i、j，使得
//         nums[i] == nums[j] 且 |i - j| <= k。
// 【示例】[1,2,3,1], k=3 → true；[1,0,1,1], k=1 → true；[1,2,3,1,2,3], k=2 → false
// =====================================================================
using System;

class ContainsDuplicateDemo
{
    public static void Run()
    {
        Console.WriteLine("用例1 [1,2,3,1], k=3 → " + ContainsNearbyDuplicate(new[] { 1, 2, 3, 1 }, 3) + "（期望 True）");
        Console.WriteLine("用例2 [1,0,1,1], k=1 → " + ContainsNearbyDuplicate(new[] { 1, 0, 1, 1 }, 1) + "（期望 True）");
        Console.WriteLine("用例3 [1,2,3,1,2,3], k=2 → " + ContainsNearbyDuplicate(new[] { 1, 2, 3, 1, 2, 3 }, 2) + "（期望 False）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 false——打开本文件实现 TODO）");
    }

    // TODO：实现 ContainsNearbyDuplicate——存在值相等且下标差 <= k 的一对元素
    static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        return false;   // 占位，实现后删除
    }
}
