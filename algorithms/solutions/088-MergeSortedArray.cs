// =====================================================================
// LC 88 · Merge Sorted Array（合并两个有序数组）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】两个升序数组 nums1 和 nums2。nums1 长度 m+n，前 m 个是有效元素，
//         后 n 个是 0 占位。把 nums2 合并进 nums1，结果整体升序且不返回
//         新数组（就地完成）。
// 【示例】nums1=[1,2,3,0,0,0], m=3；nums2=[2,5,6], n=3 → [1,2,2,3,5,6]
// =====================================================================
using System;

class MergeSortedArrayDemo
{
    public static void Run()
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        Merge(nums1, 3, nums2, 3);
        Console.WriteLine("合并结果：" + string.Join(", ", nums1) + "（期望 1, 2, 2, 3, 5, 6）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，数组不会变化——打开本文件实现 TODO）");
    }

    // TODO：实现 Merge——把 nums2 就地合并进 nums1 并整体升序
    static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
    }
}
