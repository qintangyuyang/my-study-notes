// =====================================================================
// LC 392 · Is Subsequence（判断子序列）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定字符串 s 和 t，判断 s 是否为 t 的子序列：从 t 中删除一些
//         字符（也可以不删）后能得到 s，剩余字符顺序不变。
// 【示例】s=abc, t=ahbgdc → true；s=axc, t=ahbgdc → false
// =====================================================================
using System;

class IsSubsequenceDemo
{
    public static void Run()
    {
        Console.WriteLine("abc in ahbgdc → " + IsSubsequence("abc", "ahbgdc") + "（期望 True）");
        Console.WriteLine("axc in ahbgdc → " + IsSubsequence("axc", "ahbgdc") + "（期望 False）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 false——打开本文件实现 TODO）");
    }

    // TODO：实现 IsSubsequence——s 是否为 t 的子序列（顺序保持）
    static bool IsSubsequence(string s, string t)
    {
        return false;   // 占位，实现后删除
    }
}
