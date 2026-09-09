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
    }

    // TODO：实现 LongestCommonPrefix
    static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0 || strs[0].Length == 0)
        {
            return "";
        }
        if (strs.Length == 1)
        {
            return strs[0][0].ToString();
        }
        bool IsDo = true;
        int j = 0;
        string result = "";
        while (IsDo)
        {
            for (int i = 0; i < strs.Length - 1; i++)
            {
                if (j >= strs[i].Length || j >= strs[i + 1].Length)
                {
                    IsDo = false;
                    break;
                }
                if (strs[i][j] != strs[i + 1][j])
                {
                    IsDo = false;
                    break;
                }
            }
            if (IsDo)
            {
                result = result + strs[0][j];
            }
            j++;
        }
        return result;
    }
}
