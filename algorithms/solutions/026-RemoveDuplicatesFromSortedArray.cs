// =====================================================================
// LC 26 · Remove Duplicates from Sorted Array（删除有序数组重复项）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定升序数组 nums，请原地删除重复出现的元素，使每个元素只出现
//         一次，返回删除后数组的新长度。不要用额外数组空间。
// 【示例】[0,0,1,1,1,2,2,3,3,4] → 新长度 5，数组前 5 项为 0,1,2,3,4
// =====================================================================
using System;

class RemoveDuplicatesDemo
{
    public static void Run()
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int k = RemoveDuplicates(nums);
        Console.WriteLine("返回长度：" + k + "（期望 5）");
        Console.Write("数组前 " + k + " 项：");
        for (int i = 0; i < k; i++) Console.Write(nums[i] + " ");
        Console.WriteLine();
    }

    static int RemoveDuplicates(int[] nums)
    {
        int k = 0;
        if (nums.Length == 0) return 0;
        if(nums.Length == 1) return 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[k])
            {
                k++;
                nums[k] = nums[i];
            }
        }
        return k + 1;
    }
}
