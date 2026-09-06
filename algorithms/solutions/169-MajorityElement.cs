// =====================================================================
// LC 169 · Majority Element（多数元素）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定大小为 n 的数组，找到其中的多数元素：出现次数大于 n/2 的
//         元素。可以假设数组非空，且多数元素一定存在。
// 【示例】[2,2,1,1,1,2,2] → 2
// =====================================================================
using System;

class MajorityElementDemo
{
    public static void Run()
    {
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
        Console.WriteLine("nums=[2,2,1,1,1,2,2] → " + MajorityElement(nums) + "（期望 2）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 0——打开本文件实现 TODO）");
    }

    // TODO：实现 MajorityElement——返回出现次数超过一半的元素
    static int MajorityElement(int[] nums)
    {
        return 0;   // 占位，实现后删除
    }
}
