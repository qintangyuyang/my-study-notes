// =====================================================================
// LC 27 · Remove Element（移除元素）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定数组 nums 和一个值 val，原地移除所有数值等于 val 的元素，
//         返回移除后数组的新长度。（元素顺序可以改变）
// 【示例】nums=[3,2,2,3], val=3 → 新长度 2（前 2 个元素为 2）
// =====================================================================
using System;

class RemoveElementDemo
{
    public static void Run()
    {
        int[] nums = { 3, 2, 2, 3 };
        int k = RemoveElement(nums, 3);
        Console.WriteLine("nums=[3,2,2,3], val=3 → 返回长度：" + k + "（期望 2）");
        Console.Write("数组前 " + k + " 项：");
        for (int i = 0; i < k; i++) Console.Write(nums[i] + " ");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 0——打开本文件实现 TODO）");
    }

    // TODO：实现 RemoveElement——原地移除等于 val 的元素，返回新长度
    static int RemoveElement(int[] nums, int val)
    {
        return 0;   // 占位，实现后删除
    }
}
