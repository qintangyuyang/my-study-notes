// =====================================================================
// LC 242 · Valid Anagram（有效的字母异位词）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定两个字符串 s 和 t，判断 t 是否为 s 的字母异位词
//         （字母种类和出现次数完全相同，顺序可以不同）。
// 【示例】s=anagram, t=nagaram → true；s=rat, t=car → false
// =====================================================================
using System;

class ValidAnagramDemo
{
    public static void Run()
    {
        Console.WriteLine("anagram / nagaram → " + IsAnagram("anagram", "nagaram") + "（期望 True）");
        Console.WriteLine("rat / car → " + IsAnagram("rat", "car") + "（期望 False）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 false——打开本文件实现 TODO）");
    }

    // TODO：实现 IsAnagram
    static bool IsAnagram(string s, string t)
    {
        return false;   // 占位，实现后删除
    }
}
