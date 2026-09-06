// =====================================================================
// LC 58 · Length of Last Word（最后一个单词的长度）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定仅含字母和空格 ' ' 的字符串 s，返回最后一个单词的长度。
//         单词是仅由字母组成、不包含任何空格的最大子字符串。
// 【示例】"Hello World" → 5；"   fly me   to   the moon  " → 4
// =====================================================================
using System;

class LengthOfLastWordDemo
{
    public static void Run()
    {
        string s1 = "Hello World";
        string s2 = "   fly me   to   the moon  ";
        Console.WriteLine("\"" + s1 + "\" → " + LengthOfLastWord(s1) + "（期望 5）");
        Console.WriteLine("\"" + s2 + "\" → " + LengthOfLastWord(s2) + "（期望 4）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 0——打开本文件实现 TODO）");
    }

    // TODO：实现 LengthOfLastWord
    static int LengthOfLastWord(string s)
    {
        return 0;   // 占位，实现后删除
    }
}
