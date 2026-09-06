// =====================================================================
// LC 14 · Longest Common Prefix（最长公共前缀）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定若干字符串，找出它们的最长公共前缀；没有则返回空串。
// 【示例】["flower","flow","flight"] → "fl"；["dog","racecar","car"] → ""
// =====================================================================
using System;

class LongestCommonPrefixDemo
{
    public static void Run()
    {
        string[] tests = { "flower", "flow", "flight" };
        string r1 = LongestCommonPrefix(tests);
        Console.WriteLine("[\"flower\",\"flow\",\"flight\"] → \"" + r1 + "\"（期望 \"fl\"）");
        string r2 = LongestCommonPrefix(new string[0]);
        Console.WriteLine("空数组 → \"" + r2 + "\"（期望 \"\"）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回空串——打开本文件实现 TODO）");
    }

    // TODO：实现 LongestCommonPrefix
    static string LongestCommonPrefix(string[] strs)
    {
        return "";   // 占位，实现后删除
    }
}
